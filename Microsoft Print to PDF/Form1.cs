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
using Inventor;

namespace Microsoft_Print_to_PDF
{
    public partial class ExportToPDF : Form
    {
        public ExportToPDF()
        {
            InitializeComponent();
        }
        List<string> FilesToExport = new List<string>();
        public void ButtonNationMode(string nation)
        {
            if(nation == "NA")
            {
                btn_nation.Image = img_Nation.Images[0];
                btn_nation.Text = "NA (Letter)";
            }
            else
            {
                btn_nation.Image = img_Nation.Images[1];
                btn_nation.Text = "EU (A4)";
            }
        }

        public void ExportBlackAndWihite(bool Insame, DrawingDocument dwgDoc)
        {
            var sheets = dwgDoc.Sheets[1];
            var printer = dwgDoc.PrintManager as DrawingPrintManager;
            int sts = 0;
            bool haveDET = false;
            foreach(Layer layer in dwgDoc.StylesManager.Layers)
            {
                if (layer.Name == "-DET")
                {
                    haveDET = true;
                    break;
                }
            }
                if(haveDET)
                {
                    var layerDET = dwgDoc.StylesManager.Layers["-DET"];
                    foreach (DrawingDimension dim in sheets.DrawingDimensions)
                    {
                        if (dim.Layer.Name == "-DET")
                        {
                            sts = sts + 1;
                            break;
                        }
                    }

                    if (sts == 0)
                    {
                        foreach (DrawingNote sy in sheets.DrawingNotes)
                        {
                            if (sy.Layer.Name == "-DET")
                            {
                                sts = sts + 1;
                                break;
                            }
                        }
                    }

                    if (sts == 0)//None DET
                    {

                        printer.Printer = "Microsoft Print to PDF";
                        printer.AllColorsAsBlack = true;
                        printer.PrintRange = PrintRangeEnum.kPrintAllSheets;
                        printer.Orientation = sheets.Orientation == PageOrientationTypeEnum.kLandscapePageOrientation ? PrintOrientationEnum.kLandscapeOrientation : PrintOrientationEnum.kPortraitOrientation;
                        if (btn_nation.Text.Contains("NA"))
                        printer.PaperSize = PaperSizeEnum.kPaperSizeLetter;
                        else
                        printer.PaperSize = PaperSizeEnum.kPaperSizeA4;

                        printer.ScaleMode = PrintScaleModeEnum.kPrintFullScale;
                        var pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                        if (Insame == true) //Save in the same folder with files
                        {
                            pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                        }
                        else //Save in the inputed folder
                        {
                            pdfFileOutput = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".pdf"));
                        }

                        printer.PrintToFile(pdfFileOutput);
                    }
                    else//Det Layer
                    {
                        printer.Printer = "Microsoft Print to PDF";
                        printer.AllColorsAsBlack = true;
                        printer.PrintRange = PrintRangeEnum.kPrintAllSheets;
                        printer.Orientation = sheets.Orientation == PageOrientationTypeEnum.kLandscapePageOrientation ? PrintOrientationEnum.kLandscapeOrientation : PrintOrientationEnum.kPortraitOrientation;
                        if (btn_nation.Text.Contains("NA"))
                            printer.PaperSize = PaperSizeEnum.kPaperSizeLetter;
                        else
                            printer.PaperSize = PaperSizeEnum.kPaperSizeA4;

                    printer.ScaleMode = PrintScaleModeEnum.kPrintFullScale;

                        var pdfFileOutput1 = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dwgDoc.FullFileName), System.IO.Path.GetFileNameWithoutExtension(dwgDoc.FullFileName) + "-DET.pdf");
                        var pdfFileOutput2 = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");

                        if (Insame == false) //Save in the inputed folder
                        {
                            pdfFileOutput1 = System.IO.Path.Combine(txt_save.Text, System.IO.Path.GetFileNameWithoutExtension(dwgDoc.FullFileName) + "-DET.pdf");
                            pdfFileOutput2 = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".pdf"));
                        }

                        layerDET.Plot = true; // print with layer -DET
                        if (layerDET.Visible == false)
                        {
                            layerDET.Visible = true;
                            printer.PrintToFile(pdfFileOutput1);
                            layerDET.Visible = false;
                        }
                        else printer.PrintToFile(pdfFileOutput1);

                        layerDET.Plot = false; // print without layer -DET
                        printer.PrintToFile(pdfFileOutput2);
                    }
                }
                else
                {
                    printer.Printer = "Microsoft Print to PDF";
                    printer.AllColorsAsBlack = true;
                    printer.PrintRange = PrintRangeEnum.kPrintAllSheets;
                    printer.Orientation = sheets.Orientation == PageOrientationTypeEnum.kLandscapePageOrientation ? PrintOrientationEnum.kLandscapeOrientation : PrintOrientationEnum.kPortraitOrientation;
                    if (btn_nation.Text.Contains("NA"))
                        printer.PaperSize = PaperSizeEnum.kPaperSizeLetter;
                    else
                        printer.PaperSize = PaperSizeEnum.kPaperSizeA4;

                printer.ScaleMode = PrintScaleModeEnum.kPrintFullScale;

                var pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                if (Insame == true) //Save in the same folder with files
                {
                    pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                }
                else //Save in the inputed folder
                {
                    pdfFileOutput = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".pdf"));
                }
                printer.PrintToFile(pdfFileOutput);
                }
        }

        public void ExportFullColor(bool Insame, DrawingDocument dwgDoc)
        {
                var sheet = dwgDoc.Sheets;
                var printer = dwgDoc.PrintManager as DrawingPrintManager;
                printer.AllColorsAsBlack = false;
                printer.PrintRange = PrintRangeEnum.kPrintAllSheets;
                printer.Orientation = sheet[1].Orientation == PageOrientationTypeEnum.kLandscapePageOrientation ? PrintOrientationEnum.kLandscapeOrientation : PrintOrientationEnum.kPortraitOrientation;
                if (btn_nation.Text.Contains("NA"))
                    printer.PaperSize = PaperSizeEnum.kPaperSizeLetter;
                else
                    printer.PaperSize = PaperSizeEnum.kPaperSizeA4;
            printer.ScaleMode = PrintScaleModeEnum.kPrintFullScale;
                string pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                if (Insame == true) //Save in the same folder with files
                {
                    pdfFileOutput = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".pdf");
                }
                else //Save in the inputed folder
                {
                    pdfFileOutput = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".pdf"));
                }

                printer.PrintToFile(pdfFileOutput);
        }

        public void TakeActiveFiles()
        {
            FilesToExport.Clear();
            listView1.Items.Clear();
            Inventor.Application _InvApplication = null;
            try
            {
                _InvApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application") as Inventor.Application;
            }
            catch
            {
                Type inventorAppType = System.Type.GetTypeFromProgID("Inventor.Application");
                _InvApplication = System.Activator.CreateInstance(inventorAppType) as Inventor.Application;
            }
            _InvApplication.SilentOperation = true;
            var doc = _InvApplication.Documents;
            lb_sum.Text = string.Format("Total: {0} Files", doc.VisibleDocuments.Count);
            for (int i = 1; i <= doc.VisibleDocuments.Count; i++)
            {
                var pathdwg = doc.VisibleDocuments[i].FullFileName.ToString();
                if (System.IO.Path.GetExtension(pathdwg).ToLower() == ".idw")
                {
                    FilesToExport.Add(pathdwg);
                    txt_announce.Text = "Ready! ";
                    listView1.Items.Add(System.IO.Path.GetFileName(pathdwg));
                    listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;
                }
            }
            _InvApplication.SilentOperation = false;

        }

        public void AnnounceProgress(int sum, int count)
        {
            txt_announce.Text = string.Format("In Progress ...     {0}/{1} ",count,sum);
        }

        public void ExportDXF(Inventor.Application InApp ,DrawingDocument dwg,string filename)
        {
            TranslatorAddIn DXFAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{C24E3AC4-122E-11D5-8E91-0010B541CD80}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if(DXFAddIn.HasSaveCopyAsOptions[dwg, translationContext, Options])
            {
                //Options.Value["Export_Acad_IniFile"] = @"\\105file\shardata$\@Technology\1. Inventor\1d. Tools\Microsoft Print to PDF\Template\DXFOut.ini";
                Options.Value["Export_Acad_IniFile"] = @"\\105file\shardata$\@Technology\1. Inventor\1d. Tools\Microsoft Print to PDF\Template\DXFOut-Title.ini";
            }
            _DataMedium.FileName = filename;
            DXFAddIn.SaveCopyAs(dwg, translationContext, Options, _DataMedium);
        }

        public void ExportDWG(Inventor.Application InApp, DrawingDocument dwg, string filename)
        {
            TranslatorAddIn DXFAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{C24E3AC2-122E-11D5-8E91-0010B541CD80}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if (DXFAddIn.HasSaveCopyAsOptions[dwg, translationContext, Options])
            {
                Options.Value["Export_Acad_IniFile"] = @"\\105file\shardata$\@Technology\1. Inventor\1d. Tools\Microsoft Print to PDF\Template\DWGOut.ini";
                //Options.Value["File_Version"] = "AutoCAD_2018_Drawing";
                //Options.Value["Data_Scaling"] = "Full_Scale_(1:1)-Model_Space";
                _DataMedium.FileName = filename;
            }
            DXFAddIn.SaveCopyAs(dwg, translationContext, Options, _DataMedium);
        }

        private void btn_dialogSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenSource = new OpenFileDialog();
            OpenSource.Multiselect = true;
            OpenSource.Title = "Select File";
            OpenSource.Filter = "(*.DWG;*.IDW)|*.DWG;*.IDW|All files (*.*)|*.*";
            if (OpenSource.ShowDialog() == DialogResult.OK)
            {
                lb_sum.Text = string.Format("Total: {0} Files", OpenSource.FileNames.Count());
                txt_announce.Text = "Ready! ";
                FilesToExport.Clear();
                listView1.Clear();
                int i = 0;
                foreach (var file in OpenSource.FileNames)
                {
                    FilesToExport.Add(file);
                    listView1.Items.Add(System.IO.Path.GetFileName(file));
                    listView1.Items[i].ImageIndex = 0;
                    i = i + 1;
                }
            }
        }

        private void btn_dialogSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog OpenSaveFolder = new CommonOpenFileDialog();
            OpenSaveFolder.IsFolderPicker = true;
            if (OpenSaveFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_save.Text = OpenSaveFolder.FileName;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if(!chk_PDF.Checked && !chk_DXF.Checked && !chk_DWG.Checked)
            {
                chk_PDF.CheckState = CheckState.Checked;
            }
            int sum = 0;
            int count = 0;
            if(chk_PDF.Checked)
            {
                sum = FilesToExport.Count();
            }
            if(chk_DXF.Checked)
            {
                sum = sum + FilesToExport.Count();
            }
            if(chk_DWG.Checked)
            {
                sum = sum + FilesToExport.Count();
            }

            int state = 0;
            if (FilesToExport.Count==0 && sum>0)
            {
                txt_announce.Text = "Please Open Your Files! ";
            }
            if (chk_save.CheckState == CheckState.Checked) //Save in the inputed folder
            {
                if (string.IsNullOrWhiteSpace(txt_save.Text))
                {
                    MessageBox.Show("Please input the location to save files! ");
                }
                else
                {
                    if (chk_status.CheckState == CheckState.Checked)//Black & White
                    {
                        
                        state = 1; //ExportBlackAndWihite(false);
                    }
                    else
                    {
                        state = 2; //ExportFullColor(false);//Full Color
                    }
                }
            }
            else //Save in the same folder with the file 
            {
                if (chk_status.CheckState == CheckState.Checked)//Black & White
                {
                    state = 3;//ExportBlackAndWihite(true);
                }
                else
                {
                    state = 4; //ExportFullColor(true);//Full Color
                }
            }

            Inventor.Application _InvApplication = null;
            try
            {
                _InvApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application") as Inventor.Application;
            }
            catch
            {
                Type inventorAppType = System.Type.GetTypeFromProgID("Inventor.Application");
                _InvApplication = System.Activator.CreateInstance(inventorAppType) as Inventor.Application;
            }
            _InvApplication.SilentOperation = true;
            foreach (var item in FilesToExport)
            {
                var dwgDoc = _InvApplication.Documents.Open(item) as DrawingDocument;
                string PathToExportDXF = "";
                string PathToExportDWG = "";
                switch (state)
                {
                    case 1:
                        {
                            PathToExportDXF = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".dxf"));
                            PathToExportDWG = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".dwg"));
                            if(chk_PDF.Checked)
                            {
                                count = count + 1;
                                AnnounceProgress(sum, count);
                                ExportBlackAndWihite(false, dwgDoc);
                            }
                            
                        }
                        break;
                    case 2:
                        {
                            PathToExportDXF = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".dxf"));
                            PathToExportDWG = System.IO.Path.Combine(txt_save.Text, System.IO.Path.ChangeExtension(dwgDoc.DisplayName, ".dwg"));
                            if (chk_PDF.Checked)
                            {
                                count = count + 1;
                                AnnounceProgress(sum, count);
                                ExportFullColor(false, dwgDoc);
                            }
                        }
                        break;
                    case 3:
                        {
                            PathToExportDXF = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".dxf");
                            PathToExportDWG = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".dwg");
                            if (chk_PDF.Checked)
                            {
                                count = count + 1;
                                AnnounceProgress(sum, count);
                                ExportBlackAndWihite(true, dwgDoc);
                            }
                        }
                        break;
                    case 4:
                        {
                            PathToExportDXF = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".dxf");
                            PathToExportDWG = System.IO.Path.ChangeExtension(dwgDoc.FullFileName, ".dwg");
                            if (chk_PDF.Checked)
                            {
                                count = count + 1;
                                AnnounceProgress(sum, count);
                                ExportFullColor(true, dwgDoc);
                            }
                        }
                        break;
                }
                if(chk_DXF.Checked)
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    ExportDXF(_InvApplication, dwgDoc, PathToExportDXF);
                }
                if (chk_DWG.Checked)
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    ExportDWG(_InvApplication, dwgDoc, PathToExportDWG);
                }
                dwgDoc.Close(true);
            }
            txt_announce.Text = "Complete!!! ";
            _InvApplication.SilentOperation = false;
        }

        private void chk_save_Click(object sender, EventArgs e)
        {
            if (chk_save.CheckState == CheckState.Checked)
            {
                chk_insame.CheckState = CheckState.Unchecked;
            }
            else chk_insame.CheckState = CheckState.Checked;
        }

        private void chk_insame_Click(object sender, EventArgs e)
        {
            if (chk_insame.CheckState == CheckState.Checked)
            {
                chk_save.CheckState = CheckState.Unchecked;
            }
            else chk_save.CheckState = CheckState.Checked;
        }

        private void ExportToPDF_Load(object sender, EventArgs e)
        {
            ButtonNationMode("NA");
            if (chk_save.CheckState==CheckState.Unchecked)
            {
                txt_save.Enabled = false;
                btn_dialogSave.Enabled = false;
            }
            TakeActiveFiles();
        }

        private void chk_save_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_save.CheckState == CheckState.Checked)
            {
                txt_save.Enabled = true;
                btn_dialogSave.Enabled = true;
            }
            else
            {
                txt_save.Enabled = false;
                btn_dialogSave.Enabled = false;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(listView1.FocusedItem != null && listView1.FocusedItem.Bounds.Contains(e.Location))
            {
                if(e.Button == MouseButtons.Right)
                {
                    ctm_remove.Show(Cursor.Position);
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems != null)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string filenametoremove = item.ToString().Substring(15, item.ToString().Length - 16);
                    foreach (var it in FilesToExport)
                    {
                        if (filenametoremove == System.IO.Path.GetFileName(it))
                        {
                            FilesToExport.Remove(it);
                            break;
                        }
                            
                    }
                    listView1.Items.Remove(item);
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            TakeActiveFiles();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int sum = FilesToExport.Count;
            int count = 0;
            Inventor.Application _InvApplication = null;
            try
            {
                _InvApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application") as Inventor.Application;
            }
            catch
            {
                Type inventorAppType = System.Type.GetTypeFromProgID("Inventor.Application");
                _InvApplication = System.Activator.CreateInstance(inventorAppType) as Inventor.Application;
            }
            _InvApplication.SilentOperation = true;
            foreach (var item in FilesToExport)
            {
                count = count + 1;
                AnnounceProgress(sum, count);
                _DrawingDocument dwgDoc = _InvApplication.Documents.Open(item) as _DrawingDocument;
                Sheet sheet = dwgDoc.Sheets[1];
                Layer layerTitle = dwgDoc.StylesManager.Layers["Title (ANSI)"];
                DrawingSketch sketch;
                bool a = false;
                if(sheet.TitleBlock!=null)
                {
                    a = true;
                }
               
                try
                {
                    sheet.TitleBlock.Definition.Edit(out sketch);
                    foreach (Inventor.TextBox textbox in sketch.TextBoxes)
                    {
                        textbox.Layer = layerTitle;
                        textbox.Color = layerTitle.Color;
                    }
                    sheet.TitleBlock.Definition.ExitEdit(true);
                    foreach (DrawingNote note in sheet.DrawingNotes)
                    {
                        if (note.Text.Contains("©"))
                        {
                            note.Layer = layerTitle;
                            note.Color = layerTitle.Color;
                        }
                    }
                }
                catch
                {

                }
                dwgDoc.Close();
            }
            _InvApplication.SilentOperation = false;
            txt_announce.Text = "Complete!!! ";
        }

        private void bt_nation_Click(object sender, EventArgs e)
        {
            if (btn_nation.Text.Contains("NA"))
            {
                ButtonNationMode("EU");
            }
            else ButtonNationMode("NA");
        }
    }
}
