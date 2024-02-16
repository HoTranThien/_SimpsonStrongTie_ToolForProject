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

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace Add_Views_Inline
{
    public partial class AddViewsInline_Form : Form
    {
        public AddViewsInline_Form()
        {
            InitializeComponent();
        }

        //Class contain filename and the number to sort
        public class SortFiles
        {
            public string link { get; set; }
            public int num { get; set; }
            public SortFiles(string li, int nu)
            {
                link = li;
                num = nu;
            }
        }

        //Function to create the block table AutoCAD
        public BlockTableRecord CreateNewBlock(Transaction trans, BlockTable bt, string dwgPath)
        {

            BlockTableRecord btr = new BlockTableRecord();
            btr.Name = Path.GetFileNameWithoutExtension(dwgPath);
            bt.UpgradeOpen();
            ObjectId BlId = bt.Add(btr);
            trans.AddNewlyCreatedDBObject(btr, true);
            DBObjectCollection DBOb = new DBObjectCollection();

            Database extDb = new Database(false, true);

            using (Transaction extTrans = extDb.TransactionManager.StartTransaction())
            {
                extDb.ReadDwgFile(dwgPath, FileOpenMode.OpenForReadAndAllShare, false, null);
                BlockTable extBlckTb = extTrans.GetObject(extDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                BlockTableRecord extBlckTbRc = extTrans.GetObject(SymbolUtilityServices.GetBlockModelSpaceId(extDb), OpenMode.ForRead) as BlockTableRecord;
                //extBlckTb[BlockTableRecord.ModelSpace] <-> SymbolUtilityServices.GetBlockModelSpaceId(extDb)

                foreach (ObjectId id in extBlckTbRc)
                {
                    Entity es = extTrans.GetObject(id, OpenMode.ForRead) as Entity;
                    if (es != null)
                    {
                        Entity newEnt = es.Clone() as Entity;
                        newEnt.ColorIndex = es.ColorIndex;
                        newEnt.Color = es.Color;
                        DBOb.Add(newEnt);
                    }
                }
                extDb.CloseInput(true);
            }

            foreach (Entity ent in DBOb)
            {
                btr.AppendEntity(ent);
                trans.AddNewlyCreatedDBObject(ent, true);
            }
            return btr;
        }

        //Find new Y position at the center point of the View
        public double MoveToCenterY(BlockReference br)
        {
            double ymax = br.Bounds.Value.MaxPoint.Y;
            double ymin = br.Bounds.Value.MinPoint.Y;
            double average = (ymax + Math.Abs(ymin)) / 2;
            return -(average - Math.Abs(ymin));
        }

        public string[] GetFiles(string path)
        {
            if (Directory.GetFiles(path).Length > 0)
            {
                return Directory.GetFiles(path);
            }
            else if (Directory.GetDirectories(path) != null)
            {
                path = Directory.GetDirectories(path)[0];
                return GetFiles(path);
            }
            else
            {
                return null;
            }
        }
        private void btn_dialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txt_Source.Text = dialog.SelectedPath;
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            //Check link folder
            if (string.IsNullOrWhiteSpace(txt_Source.Text))
            {
                MessageBox.Show("Please input the link folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(txt_Source.Text))
            {
                MessageBox.Show("The Link folder is not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = string.Format(txt_Source.Text + @"\" + "_RESULT");
            if (!Directory.Exists(result)) Directory.CreateDirectory(result);

            foreach (var folder in Directory.GetDirectories(txt_Source.Text))
            {
                if (folder == result) continue;
                string filename = new DirectoryInfo(folder).Name;

                //Filename of the result DWG
                string fullFileName = string.Format(result + @"\" + filename + ".dwg");

                List<SortFiles> ListFile = new List<SortFiles>();
                List<int> SortNum = new List<int>();
                string[] Files = new string[3];
                foreach (var fi in GetFiles(folder))
                {
                    string fina = Path.GetFileNameWithoutExtension(fi);
                    string num = fina.Substring(fina.IndexOf("_") + 1, fina.LastIndexOf("_") - (fina.IndexOf("_") + 1));
                    ListFile.Add(new SortFiles(fi, int.Parse(num)));
                    SortNum.Add(int.Parse(num));
                }
                //Sort the list filename
                SortNum.Sort();
                for (int i = 0; i < SortNum.Count; i++)
                {
                    foreach (var item in ListFile)
                    {
                        if (item.num == SortNum[i]) Files[i] = item.link;
                    }
                }

                //Add Block Views
                Document dwg = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Database db = dwg.Database;
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    List<BlockReference> ListBTR = new List<BlockReference>();
                    ListBTR.Clear();

                    BlockTableRecord middleBl = CreateNewBlock(trans, bt, Files[1]);
                    BlockTableRecord leftBl = CreateNewBlock(trans, bt, Files[0]);
                    BlockTableRecord rightBl = CreateNewBlock(trans, bt, Files[2]);

                    BlockReference brMiddle = new BlockReference(Point3d.Origin, middleBl.Id);
                    BlockReference brLeft = new BlockReference(Point3d.Origin, leftBl.Id);
                    BlockReference brRight = new BlockReference(Point3d.Origin, rightBl.Id);
                    ListBTR.Add(brMiddle);
                    ListBTR.Add(brLeft);
                    ListBTR.Add(brRight);

                    //Arrange views
                    //X Axis
                    double sizeMiddle = brMiddle.Bounds.Value.MaxPoint.X;
                    double sizeLeft = brLeft.Bounds.Value.MaxPoint.X;
                    double sizeRight = brRight.Bounds.Value.MaxPoint.X;
                    double gap = sizeMiddle/2;

                    brMiddle.Position = new Point3d(0, MoveToCenterY(brMiddle), 0);
                    brLeft.Position = new Point3d(-sizeLeft - sizeMiddle - gap, MoveToCenterY(brLeft), 0);
                    brRight.Position = new Point3d(sizeRight + sizeMiddle + gap, MoveToCenterY(brRight), 0);
                    BlockTableRecord ms = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    foreach (var it in ListBTR)
                    {
                        ms.AppendEntity(it);
                        trans.AddNewlyCreatedDBObject(it, true);
                    }


                    ms.UpgradeOpen();

                    db.CloseInput(true);


                    if (File.Exists(fullFileName))
                    {
                        File.Delete(fullFileName);
                        dwg.Database.SaveAs(fullFileName, false, DwgVersion.AC1014, dwg.Database.SecurityParameters);
                    }
                    else dwg.Database.SaveAs(fullFileName, false, DwgVersion.AC1014, dwg.Database.SecurityParameters);

                    ms.Erase();

                }

            }
            MessageBox.Show("Done!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();
        }
    }
}
