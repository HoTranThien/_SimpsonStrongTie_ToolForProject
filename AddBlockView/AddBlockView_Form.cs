using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using Microsoft.Office.Interop.Excel;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;


namespace Add_Block_View
{
    public partial class AddBlockView_Form : Form
    {
        public AddBlockView_Form()
        {
            InitializeComponent();
        }
        List<DrawingViews> ListDWG = new List<DrawingViews>();
        List<string> MissingFile = new List<string>();
        List<string> MissingNote = new List<string>();
        List<DrawingViews> RemovingItem = new List<DrawingViews>();

        string FindDrawingName(string fullname)
        {
            string longname = Path.GetFileNameWithoutExtension(fullname);
            int index = longname.LastIndexOf("-");
            return longname.Remove(index, longname.Count() - index);
        }
        private void btn_dialog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog OD = new CommonOpenFileDialog();
            OD.IsFolderPicker = true;
            OD.Multiselect = false;
            if(OD.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_Source.Text = OD.FileName;
            }
        }

        private void btn_dialogexcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODE = new OpenFileDialog();
            ODE.Title = "Select Excel File";
            ODE.Filter = "(*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*";
            ODE.Multiselect = false;
            if (ODE.ShowDialog() == DialogResult.OK)
            {
                txt_excel.Text = ODE.FileName;
            }
        }


        private void btn_6V_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_excel.Text) || (string.IsNullOrEmpty(txt_excel.Text)))
            {
                MessageBox.Show("Lacking input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddViews(6);
        }
        private void btn_3V_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_excel.Text) || (string.IsNullOrEmpty(txt_excel.Text)))
            {
                MessageBox.Show("Lacking input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddViews(3);
        }

        public void AddViews(int Iview)
        {
            btn_error.Text = "0";
            ListDWG.Clear();
            MissingFile.Clear();
            MissingNote.Clear();
            RemovingItem.Clear();
            //List out the drawings
            string SaveFolder = Path.Combine(txt_Source.Text, "Result");
            if (!Directory.Exists(SaveFolder))
                Directory.CreateDirectory(SaveFolder);

            foreach (string item in Directory.GetFiles(txt_Source.Text))
            {
                if (Path.GetExtension(item) == ".dwg")
                {
                    if (Path.GetFileNameWithoutExtension(item).ToLower().Contains("front"))
                    {
                        string newdrawing = Path.Combine(SaveFolder, string.Format(FindDrawingName(item) + ".dwg"));
                        DrawingViews dv = new DrawingViews(item, "", "", "", "", "", newdrawing);
                        ListDWG.Add(dv);
                    }
                }
            }
            foreach (string it in Directory.GetFiles(txt_Source.Text))
            {
                int existed = 0;
                if (Path.GetExtension(it) == ".dwg")
                {
                    foreach (DrawingViews dr in ListDWG)
                    {
                        if (Path.GetFileNameWithoutExtension(dr.Drawing) == FindDrawingName(it))
                        {
                            existed = 1;
                            string name = Path.GetFileNameWithoutExtension(it);
                            if (name.ToLower().Contains("top")) dr.Top = it;
                            else if (name.ToLower().Contains("bottom")) dr.Bottom = it;
                            else if (name.ToLower().Contains("left")) dr.Left = it;
                            else if (name.ToLower().Contains("right")) dr.Right = it;
                            else if (name.ToLower().Contains("iso")) dr.ISO = it;
                        }
                    }
                    if ((existed == 0) && !MissingFile.Contains(FindDrawingName(it)))
                    {
                        MissingFile.Add(FindDrawingName(it));
                    }
                }
            }
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = xlApp.Workbooks.Open(txt_excel.Text);
            Microsoft.Office.Interop.Excel.Worksheet ws = wb.Worksheets[1];
            for (int i = 1; i <= ws.UsedRange.Rows.Count; i++)
            {
                foreach (var item in ListDWG)
                {
                    string drawingname = Path.GetFileNameWithoutExtension(item.Drawing);
                    
                    string cellvalue = ws.Cells[i, 1].Value;
                    if (cellvalue.ToLower().Contains(drawingname.ToLower())) item.Note = ws.Cells[i, 2].Value;
                }
            }
            wb.Close();
            
            foreach (var it in ListDWG)
            {
                if (string.IsNullOrEmpty(it.Note) && !MissingNote.Contains(Path.GetFileNameWithoutExtension(it.Drawing)))
                {
                    MissingNote.Add(Path.GetFileNameWithoutExtension(it.Drawing));
                    RemovingItem.Add(it);
                }
                if ((string.IsNullOrEmpty(it.Front) || string.IsNullOrEmpty(it.Top) || string.IsNullOrEmpty(it.Bottom) || string.IsNullOrEmpty(it.Left) || string.IsNullOrEmpty(it.Right) || string.IsNullOrEmpty(it.ISO)) && !MissingFile.Contains(Path.GetFileNameWithoutExtension(it.Drawing)))
                {
                    MissingFile.Add(Path.GetFileNameWithoutExtension(it.Drawing));
                    RemovingItem.Add(it);
                }
            }
            foreach (var i in RemovingItem)
            {
                ListDWG.Remove(i);
            }
            foreach (var item in ListDWG)
            {
                Document dwg = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Database db = dwg.Database;
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    List<BlockReference> ListBTR = new List<BlockReference>();
                    ListBTR.Clear();

                    BlockTableRecord frontBl = CreateNewBlock(trans, bt, item.Front);
                    BlockTableRecord leftBl = CreateNewBlock(trans, bt, item.Left);
                    BlockTableRecord rightBl = CreateNewBlock(trans, bt, item.Right);
                    BlockTableRecord topBl = CreateNewBlock(trans, bt, item.Top);
                    BlockTableRecord bottomBl = CreateNewBlock(trans, bt, item.Bottom);
                    BlockTableRecord ISOBl = CreateNewBlock(trans, bt, item.ISO);

                    BlockReference brFront = new BlockReference(Point3d.Origin, frontBl.Id);
                    BlockReference brLeft = new BlockReference(Point3d.Origin, leftBl.Id);
                    BlockReference brRight = new BlockReference(Point3d.Origin, rightBl.Id);
                    BlockReference brTop = new BlockReference(Point3d.Origin, topBl.Id);
                    BlockReference brBottom = new BlockReference(Point3d.Origin, bottomBl.Id);
                    BlockReference brISO = new BlockReference(Point3d.Origin, ISOBl.Id);

                    double X0max = Math.Abs(brFront.Bounds.Value.MaxPoint.X);
                    double X0min = Math.Abs(brFront.Bounds.Value.MinPoint.X);
                    double Y0max = Math.Abs(brFront.Bounds.Value.MaxPoint.Y);
                    double Y0min = Math.Abs(brFront.Bounds.Value.MinPoint.Y);

                    //Find new positions
                    List<BlockReference> Views = new List<BlockReference>();
                    Views.Add(brFront);//0
                    Views.Add(brLeft);//1
                    Views.Add(brRight);//2
                    Views.Add(brTop);//3
                    Views.Add(brBottom);//4
                    Views.Add(brISO);//5
                    double[,] Bounds = new double[6,2];
                    int count = 0;
                    foreach( var vi in Views)
                    {
                        Bounds[count,0] = Math.Abs(vi.Bounds.Value.MaxPoint.X - vi.Bounds.Value.MinPoint.X);
                        Bounds[count,1] = Math.Abs(vi.Bounds.Value.MaxPoint.Y - vi.Bounds.Value.MinPoint.Y);
                        count++;
                    }
                    
                    double MaxX = (Bounds[0, 0] + Bounds[1, 0] + Bounds[2, 0]) * (1 + 2 / 3);
                    double MaxY = (Bounds[0, 1] + Bounds[1, 1] + Bounds[2, 1]) * (1 + 2 / 3);
                    double gap = MaxX > MaxY ? MaxX * 0.1 : MaxY * 0.1;

                    brLeft.Position = FindPoint(X0max, X0min, Y0max, Y0min,gap, brLeft, "Left");
                    brRight.Position = FindPoint(X0max, X0min, Y0max, Y0min,gap, brRight, "Right");
                    brTop.Position = FindPoint(X0max, X0min, Y0max, Y0min,gap, brTop, "Top");
                    brBottom.Position = FindPoint(X0max, X0min, Y0max, Y0min,gap, brBottom, "Bottom");
                    brISO.Position = FindPoint(X0max, X0min, Y0max, Y0min,gap, brISO, "ISO");

                    if (Iview == 6)
                    {
                        ListBTR.Add(brFront);
                        ListBTR.Add(brLeft);
                        ListBTR.Add(brRight);
                        ListBTR.Add(brTop);
                        ListBTR.Add(brBottom);
                        ListBTR.Add(brISO);
                    }
                    else if(Iview==3)
                    {
                        ListBTR.Add(brFront);
                        ListBTR.Add(brTop);
                        ListBTR.Add(brISO);
                    }
                    
                    BlockTableRecord ms = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    foreach (var it in ListBTR)
                    {
                        ms.AppendEntity(it);
                        trans.AddNewlyCreatedDBObject(it, true);
                    }

                    //Add text
                    double NfontSize = (Bounds[0,0] + 2*gap) / (item.Note.Length*3/2);
                    double MfontSize = gap / 3;
                    
                    Point3d TextPosition = new Point3d(brFront.Position.X, brTop.Bounds.Value.MinPoint.Y - gap, 0);

                    MText AddedText = new MText();
                    AddedText.SetDatabaseDefaults();
                    AddedText.Location = TextPosition;
                    AddedText.Contents = item.Note;
                    AddedText.TextHeight = NfontSize <= MfontSize? NfontSize : MfontSize;
                    AddedText.Attachment = AttachmentPoint.MiddleCenter;
                    

                    ms.AppendEntity(AddedText);
                    trans.AddNewlyCreatedDBObject(AddedText, true);

                    ms.UpgradeOpen();

                    db.CloseInput(true);


                    if (File.Exists(item.Drawing)) 
                    {
                        File.Delete(item.Drawing);
                        dwg.Database.SaveAs(item.Drawing, false, DwgVersion.AC1014, dwg.Database.SecurityParameters);
                    }
                    else dwg.Database.SaveAs(item.Drawing, false, DwgVersion.AC1014, dwg.Database.SecurityParameters);

                    ms.Erase();
                    //trans.Commit();
                }

            }
            //System.Windows.Forms.Application.ExitThread();
            int error = MissingFile.Count + MissingNote.Count;
            btn_error.Text = error.ToString();
            MessageBox.Show("Completed!!!");
        }
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
        public Point3d FindPoint(double X0max, double X0min, double Y0max, double Y0min, double gap, BlockReference btr,string po)
        {
            //double[] max = new double[4] { X0max, X0min, Y0max, Y0min };
            double Xmax = 0;
            double Xmin = 0;
            double Ymax = 0;
            double Ymin = 0;
            Xmax = Math.Abs(btr.Bounds.Value.MaxPoint.X);
            Xmin = Math.Abs(btr.Bounds.Value.MinPoint.X);
            Ymax = Math.Abs(btr.Bounds.Value.MaxPoint.Y);
            Ymin = Math.Abs(btr.Bounds.Value.MinPoint.Y);

            Point3d pos;

            switch (po)
            {
                case "Front":
                    pos = new Point3d(0, 0, 0);
                    break;
                case "Left":
                    pos = new Point3d(X0max + Xmin + gap, 0, 0);
                    break;
                case "Right":
                    pos = new Point3d( - X0min - Xmax - gap, 0, 0);
                    break;
                case "Top":
                    pos = new Point3d(0, -Y0min - Ymax - gap, 0);
                    break;
                case "Bottom":
                    pos = new Point3d(0, Y0max + Ymin + gap, 0);
                    break;
                case "ISO":
                    pos = new Point3d(Xmin + X0max + gap, -Y0min-Ymax - gap, 0);
                    break;
                default:
                    pos = new Point3d(0, 0, 0);
                    break;
            }
            return pos;
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            int error = MissingFile.Count + MissingNote.Count;
            string message;
            if (error == 0)
            {
                message = string.Format("{0} Error", error);
            }
            else
            {
                message = string.Format("{0} Errors:", error);
                foreach (var item in MissingFile)
                {
                    message = string.Format(message + "\n" + item + ": Missing File");
                }
                foreach (var item in MissingNote)
                {
                    message = string.Format(message + "\n" + item + ": Missing Note");
                }
            }
            MessageBox.Show(message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
