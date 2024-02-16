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
using Excel = Microsoft.Office.Interop.Excel;


namespace MoveFilesIntoFolder
{
    public partial class CopyFilesIntoFolder : Form
    {
        public CopyFilesIntoFolder()
        {
            InitializeComponent();
        }

        class rowExcel
        {
            public string filePath { get; set; }
            public string folderPath { get; set; }
            public string newFolderName { get; set; }
            public string newFolder { get; set; }

            public rowExcel(string file_Path, string folder_Path, string new_Folder_Name)
            {
                filePath = file_Path;
                folderPath = folder_Path;
                newFolderName = new_Folder_Name;
                var index = folderPath.LastIndexOf(@"\") + 1;
                newFolder = folderPath.Remove(index);
                newFolder = newFolder.Insert(newFolder.Count(),newFolderName);
            }
        }
        List<rowExcel> Summary = new List<rowExcel>();
        List<string> Error = new List<string>();

        public bool CheckLinkExcel()
        {
            if (File.Exists(txt_link.Text)) return true;
            else return false;
        }
        
        public void ChangeStateButton(bool state)
        {
            btn_copy.Enabled = state;
            btn_rename.Enabled = state;
            btn_zip.Enabled = state;
        }
        public void ReadExcel(string link)
        {
            Summary.Clear();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(link);
            Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            Excel.Range xlRange = xlWorksheet.UsedRange;

            for (int i = 2; i <= xlRange.Rows.Count; i++)
            {
                rowExcel item = new rowExcel(xlRange.Cells[i,1].Value2, xlRange.Cells[i, 2].Value2, xlRange.Cells[i, 3].Value2);
                Summary.Add(item);
            }
            xlWorkbook.Close();
        }

        private void btn_dialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Multiselect = false;
            OD.Title = "Select the Excel File";
            OD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                txt_link.Text = OD.FileName;
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Error.Clear();
            for (int i = 0; i < Summary.Count; i++)
            {
                if (File.Exists(Summary[i].filePath) && Directory.Exists(Summary[i].folderPath))
                {
                    string filename = Path.GetFileName(Summary[i].filePath);
                    string newfilepath = string.Format(Summary[i].folderPath + @"\" + filename);
                    File.Copy(Summary[i].filePath, newfilepath);
                }
                else Error.Add(string.Format("Line {0}",i+2));
            }
            MessageBox.Show("Done!!!");
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            
            foreach(var fo in Summary)
            {
                string newfoder = "";
                if (Directory.Exists(fo.folderPath))
                {
                    var index = fo.folderPath.LastIndexOf(@"\") + 1;
                    newfoder = fo.folderPath.Remove(index);
                    newfoder = newfoder.Insert(newfoder.Count(), fo.newFolderName);
                }
                if(fo.folderPath != newfoder && !string.IsNullOrWhiteSpace(newfoder))
                {
                    Directory.Move(fo.folderPath, newfoder);
                }
            }
            MessageBox.Show("Done!!!");
        }

        private void btn_zip_Click(object sender, EventArgs e)
        {
            foreach(var fo in Summary)
            {
                string folderPath = "";
                if (Directory.Exists(fo.folderPath)) folderPath = fo.folderPath;
                else if (Directory.Exists(fo.newFolder)) folderPath = fo.newFolder;
                string zip = string.Format(folderPath + ".zip");
                if(!File.Exists(zip))
                {
                    System.IO.Compression.ZipFile.CreateFromDirectory(folderPath, zip);
                    //System.IO.Compression.ZipFile.ExtractToDirectory(zip, folderPath);
                }
            }
            MessageBox.Show("Done!!!");
        }

        private void txt_link_TextChanged(object sender, EventArgs e)
        {
            ChangeStateButton(false);
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            if (!CheckLinkExcel()) return;
            ReadExcel(txt_link.Text);
            ChangeStateButton(true);
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            if (Error.Count == 0) MessageBox.Show("NONE!");
            else
            {
                string message = "ERROR AT:\n";
                foreach (var item in Error)
                {
                    message = message + item + "\n";
                }
                MessageBox.Show(message,"ERROR LIST",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }
    }
}
