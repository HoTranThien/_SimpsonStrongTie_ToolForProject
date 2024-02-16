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
using iText.Kernel.Pdf;

namespace PdfRotationForSAP
{
    public partial class PDFRotation_Form : Form
    {
        public PDFRotation_Form()
        {
            InitializeComponent();
        }
        class PdfFile
            {
                public string FullPath { get; set; }
                
                
                public string Name
                {
                    get
                    {
                        return Path.GetFileName(FullPath);
                    }

                }
                public PdfFile(string fp)
                {
                    FullPath = fp;
                }
            }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.IsFolderPicker = true;
            if (open.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtFolderOutput.Text = open.FileName;
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (!chk_landscape.Checked && !chk_Portrait.Checked)
            {
                MessageBox.Show("Please choose the option!", "Warning", MessageBoxButtons.OK);
                return;
            }
            foreach (var itm in lb.Items)
            {
                if (itm is PdfFile)
                {
                    var itmlb = itm as PdfFile;
                    string inputfilepath = itmlb.FullPath;
                    string outputfilepath = Path.Combine(txtFolderOutput.Text, itmlb.Name);
                    if (File.Exists(outputfilepath) ==false)
                    {
                        PdfDocument pdfdoc = new PdfDocument(new PdfReader(inputfilepath), new PdfWriter(outputfilepath));
                        for (int p = 1; p <= pdfdoc.GetNumberOfPages(); p++)
                        {
                            PdfPage page = pdfdoc.GetPage(p);
                            int rotate = page.GetRotation();
                            double heightpage = page.GetPageSize().GetHeight();
                            double Widthpage = page.GetPageSize().GetWidth();

                            if ((heightpage < Widthpage) && chk_landscape.Checked)
                                page.SetRotation(270);
                            else if ((heightpage>= Widthpage) && chk_Portrait.Checked) 
                                page.SetRotation(180);
                        }
                        pdfdoc.Close();
                    }
                    else
                    {
                        MessageBox.Show(itmlb.Name + " is existed. Do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                        var dialogResult = MessageBox.Show(itmlb.Name + " is existed. Do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }    
            MessageBox.Show("Complete!!!","PDF Rotation for SAP",MessageBoxButtons.OK);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            CommonOpenFileDialog OpenSelect = new CommonOpenFileDialog();
            OpenSelect.IsFolderPicker = true;
            if (OpenSelect.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(OpenSelect.FileName, "*.pdf", SearchOption.TopDirectoryOnly);
                txtFolderInput.Text = OpenSelect.FileName;
                foreach (var file in files)
                {
                    PdfFile il = new PdfFile(file);
                    lb.Items.Add(il);
                }
                lb.DisplayMember = "Name";
            }

        }
    }
}
