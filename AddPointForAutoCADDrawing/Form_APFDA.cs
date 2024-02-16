using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

using Teigha.Runtime;
using IntelliCAD;
using IntelliCAD.EditorInput;
using IntelliCAD.ApplicationServices;
using Teigha.Geometry;
using Teigha.DatabaseServices;

namespace Microsoft_Print_to_PDF
{
    public partial class Form_APFDA : Form
    {
        public Form_APFDA()
        {
            InitializeComponent();
        }

        public List<string> ListFilePath = new List<string>();
        public int sum = 0;
        public int count = 0;
        public string newfolder;
        bool unitmetric = true;
        private void btn_source_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenSource = new System.Windows.Forms.OpenFileDialog();
            OpenSource.Multiselect = true;
            OpenSource.Title = "Select File";
            OpenSource.Filter = "(*.DWG;*.IDW)|*.DWG;*.IDW|All files (*.*)|*.*";
            if (OpenSource.ShowDialog() == DialogResult.OK)
            {
                ListFilePath.Clear();
                lv_source.Clear();
                int i = 0;
                
                foreach (var file in OpenSource.FileNames)
                {
                    ListFilePath.Add(file);
                    lv_source.Items.Add(System.IO.Path.GetFileName(file));
                    lv_source.Items[i].ImageIndex = 0;
                    i = i + 1;
                }
                int quantity = OpenSource.FileNames.Length;
                if (quantity == 1) lb_quantity.Text = "1 Drawing Selected";
                else lb_quantity.Text = string.Format("{0} Drawings Selected", quantity);
            }

        }
        public string ChangeFilenameToSave(string item)
        {
            string newfilename = string.Format(Path.GetFileNameWithoutExtension(item) + "_For PDF.dwg");
            return Path.Combine(newfolder, newfilename);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            newfolder = Path.Combine(Path.GetDirectoryName(ListFilePath[0]), "For PDF");
            if (!Directory.Exists(newfolder)) Directory.CreateDirectory(newfolder);
            DocumentCollection Docs = IntelliCAD.ApplicationServices.Application.DocumentManager;

            foreach (string item in ListFilePath)
            {
                Document Doc = Docs.Open(item, false);
                //if(unitmetric == true)
                //{
                //    Doc.Database.Insunits = UnitsValue.Millimeters;
                //}
                //else Doc.Database.Insunits = UnitsValue.Inches;
                Docs.MdiActiveDocument = Doc;
                Database acCurDb = Docs.MdiActiveDocument.Database;

                // Start a transaction
                using (Transaction Trans = acCurDb.TransactionManager.StartTransaction())
                {

                    // Open the Layer table for read
                    LayerTable LayTab;
                    LayTab = Trans.GetObject(acCurDb.LayerTableId,
                                                       OpenMode.ForRead) as LayerTable;
                    string sLayerName = "Point";
                    if (LayTab.Has(sLayerName) == false)
                    {
                        // Upgrade the Layer table for write
                        LayTab.UpgradeOpen();
                        LayerTableRecord LayTabRec = new LayerTableRecord();
                        LayTabRec.Name = sLayerName;
                        LayTabRec.Color = Teigha.Colors.Color.FromColorIndex(Teigha.Colors.ColorMethod.ByAci, 1);
                        LayTabRec.IsPlottable = true;
                        LayTabRec.LineWeight = LineWeight.LineWeight000;

                        // Append the new layer to the Layer table and the transaction
                        LayTab.Add(LayTabRec);
                        Trans.AddNewlyCreatedDBObject(LayTabRec, true);
                    }

                    // Open the Block table for read
                    BlockTable BlkTbl;
                    BlkTbl = Trans.GetObject(acCurDb.BlockTableId,
                                                       OpenMode.ForRead) as BlockTable;
                    // Open the Block table record Model space for write
                    BlockTableRecord BlkTblRec;
                    BlkTblRec = Trans.GetObject(BlkTbl[BlockTableRecord.ModelSpace],
                                                          OpenMode.ForWrite) as BlockTableRecord;

                    DBObjectCollection objs = Trans.GetAllObjects();
                    double MinX, MaxX, MinY, MaxY;
                    MinX = 0; MaxX = 0; MinY = 0; MaxY = 0;
                    int count = 0;
                    foreach (ObjectId id in BlkTblRec)
                    {
                        try
                        {
                            DBObject dbo = Trans.GetObject(id, OpenMode.ForWrite) as DBObject;
                            Point3d Min = dbo.Bounds.Value.MinPoint;
                            Point3d Max = dbo.Bounds.Value.MaxPoint;
                            if (count == 0)
                            {
                                MinX = Min.X;
                                MaxX = Max.X;
                                MinY = Min.Y;
                                MaxY = Max.Y;
                            }
                            else
                            {
                                if (Min.X <= MinX) MinX = Min.X;
                                if (Max.X >= MaxX) MaxX = Max.X;
                                if (Min.Y <= MinY) MinY = Min.Y;
                                if (Max.Y >= MaxY) MaxY = Max.Y;
                            }
                            count++;
                        }
                        catch
                        {
                            continue;
                        }

                    }
                    double length;
                    double gap;
                    if (unitmetric == true)
                    {
                        gap = 40;
                    }
                    else gap = 1;
                    Point3d MidPoint = new Point3d((MinX + MaxX) / 2, (MinY + MaxY) / 2, 0);
                    Point3d MinPoint;
                    Point3d MaxPoint;
                    if (MaxX - MinX > MaxY - MinY)
                    {
                        length = MaxX - MinX;
                    }
                    else
                    {
                        length = MaxY - MinY;
                    }
                    MaxPoint = new Point3d(MidPoint.X + length / 2 + gap, MidPoint.Y + length / 2 + gap, 0);
                    MinPoint = new Point3d(MidPoint.X - length / 2 - gap, MidPoint.Y - length / 2 - gap, 0);
                    DBPoint StPoint = new DBPoint(MinPoint);
                    StPoint.Layer = sLayerName;
                    DBPoint EnPoint = new DBPoint(MaxPoint);
                    EnPoint.Layer = sLayerName;

                    BlkTblRec.AppendEntity(StPoint);
                    BlkTblRec.AppendEntity(EnPoint);
                    Trans.AddNewlyCreatedDBObject(StPoint, true);
                    Trans.AddNewlyCreatedDBObject(EnPoint, true);
                    Trans.Commit();
                    Doc.CloseAndSave(ChangeFilenameToSave(item));
                    string bak = Path.ChangeExtension(item, ".bak");
                    if (File.Exists(bak))
                    {
                        File.Delete(bak);
                    }
                }
            }
            MessageBox.Show("Complete!!!");
            System.Windows.Forms.Application.Exit();
        }

        private void btn_SaveDWG_Click(object sender, EventArgs e)
        {
            DocumentCollection Docs = IntelliCAD.ApplicationServices.Application.DocumentManager;

            foreach (string item in ListFilePath)
            {
                Document Doc = Docs.Open(item, false);
                //if (unitmetric == true)
                //{
                //    Doc.Database.Insunits = UnitsValue.Millimeters;
                //}
                //else Doc.Database.Insunits = UnitsValue.Inches;
                Doc.CloseAndSave(item);
                string bak = Path.ChangeExtension(item, "bak");
                if (File.Exists(bak)) File.Delete(bak);
            }
            System.Windows.Forms.Application.Exit();
        }

        private void btn_unit_Click(object sender, EventArgs e)
        {
            if (btn_unit.Text == "MM")
            {
                btn_unit.Text = "INCH";
                btn_unit.BackColor = Color.DarkBlue;
                unitmetric = false;
            }
            else
            {
                btn_unit.Text = "MM";
                btn_unit.BackColor = Color.DarkRed;
                unitmetric = true;
            }
        }
    }
}
