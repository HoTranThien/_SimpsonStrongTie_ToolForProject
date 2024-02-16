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
using System.Windows;
using Microsoft.Office.Interop.Excel;

namespace Microsoft_Print_to_PDF
{
    public partial class Form_ATFDA : Form
    {
        public Form_ATFDA()
        {
            InitializeComponent();
        }
        
        public class ItemExcel
        {
            string pa;
            public string ModifiledModel { get; set; }
            public string Description { get; set; }
            public string AddedText { get; set; }
            public string Filename { get; set; }
            public ItemExcel(string fi,string mod, string des)
            {
                ModifiledModel = mod;
                Description = des;
                Filename = fi;
                AddedText = string.Format(mod + "\n" + des);
            }
        }

        public List<ItemExcel> ListItemExcel = new List<ItemExcel>();
        public List<string> ListFilePath = new List<string>();
        public int sum = 0;
        public int count = 0;
        public void ReadExcelFile()
        {
            ListItemExcel.Clear();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = xlApp.Workbooks.Open(txt_Excel.Text);
            Microsoft.Office.Interop.Excel.Worksheet ws = wb.Worksheets[1];
            for (int i = 1; i <= ws.UsedRange.Rows.Count; i++)
            {
                ItemExcel it = new ItemExcel(ws.Cells[i, 1].Value2, ws.Cells[i, 2].Value2, ws.Cells[i, 3].Value2);
                ListItemExcel.Add(it);
            }
            wb.Close();
        }
        public void Announcement(int a)
        {
            switch (a)
            {
                case 0:
                    { 
                        txt_Announcement.Text = "Please collect your files! ";
                        break;
                    }
                case 1:
                    {
                        txt_Announcement.Text = "Please collect the excel file! ";
                        break;
                    }
                case 2:
                    {
                        txt_Announcement.Text = "Ready! ";
                        break;
                    }
                case 3:
                    {
                        txt_Announcement.Text = "In Progress ... Reading The Excel File ";
                        break;
                    }
                case 4:
                    {
                        txt_Announcement.Text = "In Progress ... Adding Text ";
                        break;
                    }
                case 100:
                    {
                        txt_Announcement.Text = "Complete!!! ";
                        break;
                    }
            }
        }
        private void btn_source_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenSource = new OpenFileDialog();
            OpenSource.Multiselect = true;
            OpenSource.Title = "Select File";
            OpenSource.Filter = "(*.DWG;*.IDW)|*.DWG;*.IDW|All files (*.*)|*.*";
            if (OpenSource.ShowDialog() == DialogResult.OK)
            {
                txt_Announcement.Text = "Ready!";
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
            }
            
        }

        private void btn_dialogExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExcelDialog = new OpenFileDialog();
            ExcelDialog.Multiselect = false;
            ExcelDialog.Title = "Select Excel File";
            ExcelDialog.Filter = "(*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (ExcelDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Excel.Text = ExcelDialog.FileName;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if(lv_source.Items.Count == 0)
            {
                Announcement(0);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Excel.Text) && File.Exists(txt_Excel.Text))
            {
                Announcement(1);
                return;
            }
            sum = ListFilePath.Count;
            Announcement(3);
            ReadExcelFile();
            Announcement(4);
            foreach (string item in ListFilePath)
            {
                count = count + 1;
                Document doc = IntelliCAD.ApplicationServices.Application.DocumentManager.Open(item,false);
                Database docDB = doc.Database;
                // Start a transaction
                using (Transaction Trans = docDB.TransactionManager.StartTransaction())
                {
                    // Open the Block table for read
                    BlockTable BlkTbl;
                    BlkTbl = Trans.GetObject(docDB.BlockTableId, OpenMode.ForWrite) as BlockTable;
                    
                    // Open the Block table record Model space for write
                    BlockTableRecord BlkTblRec;
                    BlkTblRec = Trans.GetObject(BlkTbl[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    //Find the positon of added Text
                    double AddedTextHeigth = 0.1875;
                    Point3d TextPosition = new Point3d(0, 0, 0);
                    foreach (ObjectId id in BlkTblRec)
                    {
                        try
                        {
                            BlockReference br = Trans.GetObject(id, OpenMode.ForWrite) as BlockReference;
                            TextPosition = new Point3d(br.Bounds.Value.MinPoint.X, br.Bounds.Value.MinPoint.Y - AddedTextHeigth*0, br.Bounds.Value.MinPoint.Z);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    
                    //Create a new text style
                    TextStyleTable TextStyleTblRec = (TextStyleTable)Trans.GetObject(docDB.TextStyleTableId, OpenMode.ForWrite,false);
                    TextStyleTableRecord newstyle = new TextStyleTableRecord();
                    newstyle.Name = "AddedText";
                    TextStyleTblRec.Add(newstyle);
                    newstyle.Font = new Teigha.GraphicsInterface.FontDescriptor("Arial", false, false,0,0);
                    newstyle.TextSize = AddedTextHeigth;

                    MText AddedText = new MText();
                    AddedText.SetDatabaseDefaults();
                    AddedText.Location = TextPosition;
                    AddedText.TextStyleId = newstyle.Id;
                    foreach(ItemExcel ie in ListItemExcel)
                    {
                        if (Path.GetFileNameWithoutExtension(item) == ie.Filename)
                        {
                            AddedText.Contents = ie.AddedText;
                            break;
                        }
                        else AddedText.Contents = "CAN'T FIND";
                    }

                    BlkTblRec.AppendEntity(AddedText);
                    Trans.AddNewlyCreatedDBObject(AddedText, true);

                    //Save the changes and dispose of the transaction
                    Trans.Commit();
                }
                doc.CloseAndSave(item);
                string bak = Path.ChangeExtension(item, ".bak");
                if(File.Exists(bak))
                {
                    File.Delete(bak);
                }
            }
            Announcement(100);
            System.Windows.Forms.Application.Exit();
        }

        private void Form_ATFDA_Load(object sender, EventArgs e)
        {
            Announcement(0);
        }
    }
}
