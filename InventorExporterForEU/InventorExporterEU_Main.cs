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
    public partial class InventorExporter : Form
    {
        public InventorExporter()
        {
            InitializeComponent();
        }
        List<string> FilesToExport = new List<string>();
        List<string> ListError = new List<string>();
        int error = 0;
        bool[] SeparatedViewOp;  

        string Template2DDWG = @"\\105file\shardata$\@Technology\1. Inventor\1d. Tools\InventorExporterForEU\Template\Standard.idw";
        public void SwitchStateButton (Button button)
        {
            if (button.BackColor == SystemColors.ScrollBar)
            {
                button.BackColor = SystemColors.Window;
            }
            else if (button.BackColor == SystemColors.Window)
            {
                button.BackColor = SystemColors.ScrollBar;
            }
        }
        public bool CheckStateButton (Button button)
        {
            if (button.BackColor == SystemColors.Window)
                return true;
            else return false;
        }

        public void AnnounceProgress(int sum, int count)
        {
            txt_announce.Text = string.Format("In Progress ...     {0}/{1} ",count,sum);
        }
        public void AnnounceProgress(int state)
        {
            switch (state)
                {
                case 0:
                    txt_announce.Text = "Please Choose Your Files! ";
                    break;
                case 1:
                    txt_announce.Text = "Please Choose Format! ";
                    break;
                case 2:
                    txt_announce.Text = "Ready! ";
                    break;
                case 3:
                    txt_announce.Text = "Commplete! ";
                    break;
                case 4:
                    txt_announce.Text = "In Progress ... ";
                    break;
                case 5:
                    txt_announce.Text = "Please input the link to save! ";
                    break;
                case 6:
                    txt_announce.Text = "The saving link is not exist! ";
                    break;
            }
        }
        public string GetFullFileName(string CurrentFileName, string FolderName)
        {
            string newpath = System.IO.Path.GetFileName(CurrentFileName);
            string Extension="";
            switch (FolderName)
            {
                case "3D PDF":
                    Extension = ".pdf";
                    break;
                case "STL":
                    Extension = ".stl";
                    break;
                case "STP":
                    Extension = ".stp";
                    break;
                case "SAT":
                    Extension = ".sat";
                    break;
                case "3D DWG":
                    Extension = ".dwg";
                    break;
                case "2D DWG":
                    Extension = ".dwg";
                    break;
                case "SEPARATED VIEW":
                    Extension = ".dwg";
                    break;
                case "X_T":
                    Extension = ".x_t";
                    break;
            }
            newpath = System.IO.Path.Combine(txt_save.Text,FolderName, newpath);
            newpath = System.IO.Path.ChangeExtension(newpath, Extension);
            return newpath;
        }
        public void Errors(string filename)
        {
            error = error + 1;
            ListError.Add(System.IO.Path.GetFileName(filename));
        }

        public void ExportToSTL(Inventor.Application InApp, Document doc, string filename)
        {
            TranslatorAddIn STLAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{81CA7D27-2DBE-4058-8188-9136F85FC859}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if (STLAddIn.HasSaveCopyAsOptions[doc, translationContext, Options])
            {
                Options.Value["OutputFileType"] = 0;
                Options.Value["Resolution"] = 1;
                Options.Value["ExportUnits"] = 5;
                _DataMedium.FileName = filename;
            }
            try
            {
                STLAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
            }
            catch
            {
                error = error + 1;
                ListError.Add(System.IO.Path.GetFileName(filename));
            }
        }
        public void ExportToSTP(Inventor.Application InApp, Document doc, string filename)
        {
            TranslatorAddIn STPAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{90AF7F40-0C01-11D5-8E83-0010B541CD80}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();
            _DataMedium.MediumType = MediumTypeEnum.kFileNameMedium;

            if (STPAddIn.HasSaveCopyAsOptions[doc, translationContext, Options])
            {
                Options.Value["ApplicationProtocolType"] = 3;
                
                _DataMedium.FileName = filename;
                try
                {
                    STPAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
                }
                catch
                {
                    error = error + 1;
                    ListError.Add(System.IO.Path.GetFileName(filename));
                }
            }
        }
        public void ExportToSAT(Inventor.Application InApp, Document doc, string filename)
        {
            TranslatorAddIn SATAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{89162634-02B6-11D5-8E80-0010B541CD80}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if (SATAddIn.HasSaveCopyAsOptions[doc, translationContext, Options])
            {
                _DataMedium.FileName = filename;
            }
            try
            {
                SATAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
            }
            catch
            {
                error = error + 1;
                ListError.Add(System.IO.Path.GetFileName(filename));
            }
        }
        public void ExportTo3DPDF(Inventor.Application InApp, Document doc, string filename)
        {
            ApplicationAddIn PDFAddIn = null;
            foreach (ApplicationAddIn AddIn in InApp.ApplicationAddIns)
            {
                if (AddIn.ClassIdString == "{3EE52B28-D6E0-4EA4-8AA6-C2A266DEBB88}")
                {
                    PDFAddIn = AddIn;
                    break;
                }
            }
            dynamic PDFConvertor3D = PDFAddIn.Automation;
            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            Options.Value["FileOutputLocation"] = filename;
            Options.Value["ExportAnnotations"] = 1;
            Options.Value["ExportWokFeatures"] = 1;
            Options.Value["GenerateAndAttachSTEPFile"] = false;

            Options.Value["VisualizationQuality"] = AccuracyEnum.kHigh;

            // Limit export to entities in selected view representation(s)
            Options.Value["LimitToEntitiesInDVRs"] = true;

            string[] sProps = new string[1];
            sProps[0] = "{F29F85E0-4FF9-1068-AB91-08002B27B3D9}:Title";
            Options.Value["ExportAllProperties"] = true;
            Options.Value["ExportProperties"] = sProps;

            Options.Value["ExportTemplate"] = @"C:\Users\Public\Documents\Autodesk\Inventor 2019\Templates\Blank.pdf";

            var sDesignViews = new string[] { "Master" };
            Options.Value["ExportDesignViewRepresentations"] = sDesignViews;
            try
            {
                PDFConvertor3D.Publish(doc, Options);
            }
            catch
            {
                error = error + 1;
                ListError.Add(System.IO.Path.GetFileName(filename));
            }
        }
        public void ExportTo3DDWG(Inventor.Application InApp, _Document doc, string filename)
        {
            TranslatorAddIn DWGAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{C24E3AC2-122E-11D5-8E91-0010B541CD80}"];
            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if (DWGAddIn.HasSaveCopyAsOptions[doc, translationContext, Options])
            {
                //Options.Value["Export_Acad_IniFile"] = @"C:\tempDXFOut.ini";
                Options.Value["Version"] = DWGFileVersionEnum.kAutoCAD2010;
                _DataMedium.FileName = filename;
            }
            DWGAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
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
                Options.Value["Export_Acad_IniFile"] = @"\\105file\shardata$\@Technology\1. Inventor\1d. Tools\InventorExporterForEU\Template\DWGOut.ini";
                _DataMedium.FileName = filename;
            }
            DXFAddIn.SaveCopyAs(dwg, translationContext, Options, _DataMedium);
        }
        public void ExportTo2DDWG(Inventor.Application InApp, _Document doc, string filename)
        {
            
            string temp = System.IO.Path.ChangeExtension(filename, ".idw");
            System.IO.File.Copy(Template2DDWG, temp);
            InApp.SilentOperation = true;
            var idw = InApp.Documents.Open(temp,false) as DrawingDocument;
            var sheet = idw.ActiveSheet;
            if(sheet.TitleBlock !=null)
            sheet.TitleBlock.Delete();
            if(sheet.Border!=null)
            sheet.Border.Delete();
            double centerX = sheet.Width / 2;
            double centerY = sheet.Height / 2;
            double scale = 1;

            Point2d pointViewPos1 = InApp.TransientGeometry.CreatePoint2d(0, 0);
            var front = sheet.DrawingViews.AddBaseView(doc, pointViewPos1, scale,
            ViewOrientationTypeEnum.kFrontViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);
            double gap = front.Height > front.Width ? front.Height : front.Width;

            Point2d pointViewPos2 = InApp.TransientGeometry.CreatePoint2d(front.Position.X-gap, front.Position.Y);
            var left = sheet.DrawingViews.AddProjectedView(front, pointViewPos2, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);


            Point2d pointViewPos3 = InApp.TransientGeometry.CreatePoint2d(front.Position.X + gap, front.Position.Y);
            var right = sheet.DrawingViews.AddProjectedView(front, pointViewPos3, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);


            Point2d pointViewPos4 = InApp.TransientGeometry.CreatePoint2d(front.Position.X, front.Position.Y+gap);
            var top = sheet.DrawingViews.AddProjectedView(front, pointViewPos4, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);
 

            Point2d pointViewPos5 = InApp.TransientGeometry.CreatePoint2d(front.Position.X, front.Position.Y - gap);
            var bottom = sheet.DrawingViews.AddProjectedView(front, pointViewPos5, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);


            Point2d pointViewPos6 = InApp.TransientGeometry.CreatePoint2d(right.Position.X, bottom.Position.Y);
            var iso = sheet.DrawingViews.AddBaseView(doc, pointViewPos6, scale,
            ViewOrientationTypeEnum.kIsoTopRightViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);

            
            double MaxX = (front.Width + left.Width + right.Width)*(1+2/3);
            double MaxY = (front.Height + top.Height + bottom.Height)*(1+2/3);
            double para = 0.5;
            MessageBox.Show(string.Format("SheetH: {0}; SheetW: {1}", sheet.Height, sheet.Width));

            if(MaxY > MaxX)
            {
                double div = MaxY < sheet.Height * 0.8? MaxY / (sheet.Height*0.8) : sheet.Height * 0.8/MaxY;
                scale = div* para;
            }
            else
            {
                double divX = (MaxX / (sheet.Width * 0.8)) < 1 ? MaxX / (sheet.Width * 0.8) : (sheet.Width * 0.8)/MaxX;
                double divY = (MaxY / (sheet.Height * 0.8)) < 1 ? MaxY / (sheet.Height * 0.8) : (sheet.Height * 0.8) / MaxX;
                scale = divX > divY ? divX* para : divY* para;
            }
            double space = MaxX > MaxY ? MaxX*scale*0.2 : MaxY*scale*0.2;

            front.Scale = scale;
            left.Position = InApp.TransientGeometry.CreatePoint2d(front.Position.X - (front.Width + left.Width) / 2 - space, front.Position.Y);
            right.Position = InApp.TransientGeometry.CreatePoint2d(front.Position.X + (front.Width + left.Width) / 2 + space, front.Position.Y);
            top.Position = InApp.TransientGeometry.CreatePoint2d(front.Position.X, front.Position.Y + (front.Height + top.Height) / 2 + space);
            bottom.Position = InApp.TransientGeometry.CreatePoint2d(front.Position.X, front.Position.Y - (front.Height + bottom.Height) / 2 - space);
            iso.Scale = scale;
            iso.Position = InApp.TransientGeometry.CreatePoint2d(right.Position.X-right.Width/2+iso.Width/2,bottom.Position.Y+bottom.Height/2-iso.Height/2);

            DrawingSketch sketch = sheet.Sketches.Add();

            Point2d pointbox = InApp.TransientGeometry.CreatePoint2d(top.Position.X, bottom.Position.Y - bottom.Height - space);
            GeneralNotes notes = sheet.DrawingNotes.GeneralNotes;
            TextStyle style = (TextStyle)idw.StylesManager.TextStyles[1].Copy("TextExporter");

            string Note = System.IO.Path.GetFileNameWithoutExtension(temp);
            
            double fontsize = (front.Width + 2 * space) / (Note.Length * 3 / 2);
            double maxsize = (bottom.Position.Y - pointbox.Y - bottom.Height / 2) / 3;
            if (fontsize >= maxsize) style.FontSize = maxsize;
            else style.FontSize = fontsize;
            style.Font = "Arial";
            style.Italic = false;
            style.HorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter;
            style.VerticalJustification = VerticalTextAlignmentEnum.kAlignTextMiddle;
            GeneralNote note = notes.AddFitted(pointbox, Note ,style);
            
            ExportDWG(InApp, idw, filename);
            idw.Close(true);
            InApp.SilentOperation = false;
            System.IO.File.Delete(temp);
        }
        public void ExportToSEPARATEDVIEW(Inventor.Application InApp, _Document doc, string filename)
        {
            string temp = System.IO.Path.ChangeExtension(filename, ".idw");
            System.IO.File.Copy(Template2DDWG, temp);
            InApp.SilentOperation = true;
            var idw = InApp.Documents.Open(temp,false) as DrawingDocument;
            var sheet = idw.ActiveSheet;
            if (sheet.TitleBlock != null)
                sheet.TitleBlock.Delete();
            if (sheet.Border != null)
                sheet.Border.Delete();
            double centerX = sheet.Width / 2;
            double centerY = sheet.Height / 2;
            double scale = 1;
            ViewOrientationTypeEnum ViewOrientation;
            string view = "";
            Point2d pointViewPos;

            //Find the Insert Point
            PartDocument docP;
            AssemblyDocument docA;
            double Xmax = 0, Xmin = 0, Ymax = 0, Ymin = 0, Zmax = 0, Zmin = 0;
            if (doc.DocumentType == DocumentTypeEnum.kPartDocumentObject)
            {
                docP = doc as PartDocument;
                Xmax = docP.ComponentDefinition.RangeBox.MaxPoint.X;
                Xmin = docP.ComponentDefinition.RangeBox.MinPoint.X;
                Ymax = docP.ComponentDefinition.RangeBox.MaxPoint.Y;
                Ymin = docP.ComponentDefinition.RangeBox.MinPoint.Y;
                Zmax = docP.ComponentDefinition.RangeBox.MaxPoint.Z;
                Zmin = docP.ComponentDefinition.RangeBox.MinPoint.Z;
            }
            else if (doc.DocumentType == DocumentTypeEnum.kAssemblyDocumentObject)
            {
                docA = doc as AssemblyDocument;
                Xmax = docA.ComponentDefinition.RangeBox.MaxPoint.X;
                Xmin = docA.ComponentDefinition.RangeBox.MinPoint.X;
                Ymax = docA.ComponentDefinition.RangeBox.MaxPoint.Y;
                Ymin = docA.ComponentDefinition.RangeBox.MinPoint.Y;
                Zmax = docA.ComponentDefinition.RangeBox.MaxPoint.Z;
                Zmin = docA.ComponentDefinition.RangeBox.MinPoint.Z;
            }
            double X = Xmax - (Math.Abs(Xmax) + Math.Abs(Xmin)) / 2;
            double Y = Ymax - (Math.Abs(Ymax) + Math.Abs(Ymin)) / 2;
            double Z = Zmax - (Math.Abs(Zmax) + Math.Abs(Zmin)) / 2;
            Inventor.Point InsertPoint = InApp.TransientGeometry.CreatePoint(X, Y, Z);

            for (int i = 1; i <= 6;i++)
            {
                switch (i)
                {
                    case 1:
                        
                        ViewOrientation = ViewOrientationTypeEnum.kFrontViewOrientation;
                        view = "-Front";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(InsertPoint.X,InsertPoint.Z);
                        break;
                    case 2:
                        ViewOrientation = ViewOrientationTypeEnum.kLeftViewOrientation;
                        view = "-Left";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(-InsertPoint.Y, InsertPoint.Z);
                        break;
                    case 3:
                        ViewOrientation = ViewOrientationTypeEnum.kRightViewOrientation;
                        view = "-Right";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(InsertPoint.Y, InsertPoint.Z);
                        break;
                    case 4:
                        ViewOrientation = ViewOrientationTypeEnum.kTopViewOrientation;
                        view = "-Top";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(InsertPoint.X, InsertPoint.Y);
                        break;
                    case 5:
                        ViewOrientation = ViewOrientationTypeEnum.kBottomViewOrientation;
                        view = "-Bottom";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(InsertPoint.X, -InsertPoint.Y);
                        break;
                    default:
                        ViewOrientation = ViewOrientationTypeEnum.kIsoTopRightViewOrientation;
                        view = "-ISO";
                        pointViewPos = InApp.TransientGeometry.CreatePoint2d(0, 0);
                        break;
                }

                var front = sheet.DrawingViews.AddBaseView(doc, pointViewPos, scale,
                ViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle);

                string viewfilename = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filename),string.Format(System.IO.Path.GetFileNameWithoutExtension(filename)+view+".dwg"));
                if (SeparatedViewOp[i-1] == true)
                {
                    ExportDWG(InApp, idw, viewfilename);
                }
             
                front.Delete();
            }
            idw.Close(true);
            InApp.SilentOperation = false;
            System.IO.File.Delete(temp);
        }

        public void ExportToX_T(Inventor.Application InApp, _Document doc, string filename)
        {
            TranslatorAddIn X_TAddIn = (Inventor.TranslatorAddIn)InApp.ApplicationAddIns.ItemById["{8F9D3571-3CB8-42F7-8AFF-2DB2779C8465}"];

            Inventor.TranslationContext translationContext = InApp.TransientObjects.CreateTranslationContext();
            translationContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism;

            Inventor.NameValueMap Options = InApp.TransientObjects.CreateNameValueMap();

            DataMedium _DataMedium = InApp.TransientObjects.CreateDataMedium();

            if (X_TAddIn.HasSaveCopyAsOptions[doc, translationContext, Options])
            {
                Options.Value["Version"] = "10";

                _DataMedium.FileName = filename;
            }
            X_TAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
            try
            {
                X_TAddIn.SaveCopyAs(doc, translationContext, Options, _DataMedium);
            }
            catch
            {
                error = error + 1;
                ListError.Add(System.IO.Path.GetFileName(filename));
            }
        }
        private void btn_dialogSource_Click(object sender, EventArgs e)
        {
            error = 0;
            ListError.Clear();
            OpenFileDialog OpenSource = new OpenFileDialog();
            OpenSource.Multiselect = true;
            OpenSource.Title = "Select File";
            OpenSource.Filter = "(*.IPT;*.IAM)|*.IPT;*.IAM|All files (*.*)|*.*";
            if (OpenSource.ShowDialog() == DialogResult.OK)
            {
                lb_sum.Text = string.Format("Total: {0} Files", OpenSource.FileNames.Count());
                AnnounceProgress(2);
                FilesToExport.Clear();
                listView1.Clear();
                int i = 0;
                foreach (var file in OpenSource.FileNames)
                {
                    FilesToExport.Add(file);
                    listView1.Items.Add(System.IO.Path.GetFileName(file));
                    switch (System.IO.Path.GetExtension(file).ToLower())
                    {
                        case ".ipt":
                        listView1.Items[i].ImageIndex = 0;
                        break;
                        case ".iam":
                            listView1.Items[i].ImageIndex = 1;
                            break;
                    }
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            error = 0;
            ListError.Clear();
            AnnounceProgress(4);
            if (FilesToExport.Count <= 0)
            {
                AnnounceProgress(0);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_save.Text))
            {
                AnnounceProgress(5);
                return;
            }
            if (!Directory.Exists(txt_save.Text))
            {
                AnnounceProgress(6);
                return;
            }

            //Check Separated View
            SeparatedViewOp = new bool[6] { false, false, false, false, false, false };
            if (gb_SV.Enabled == true)
            {
                if (chk_Front.Checked) SeparatedViewOp[0] = true;
                if (chk_Left.Checked) SeparatedViewOp[1] = true;
                if (chk_Right.Checked) SeparatedViewOp[2] = true;
                if (chk_Top.Checked) SeparatedViewOp[3] = true;
                if (chk_Bottom.Checked) SeparatedViewOp[4] = true;
                if (chk_ISO.Checked) SeparatedViewOp[5] = true;
                if (!chk_Front.Checked && !chk_Left.Checked && !chk_Right.Checked && !chk_Top.Checked && !chk_Bottom.Checked && !chk_ISO.Checked)
                {
                    chk_Front.Checked = true;
                    SeparatedViewOp[0] = true;
                }
            }

            int sum = 0;
            int count = 0;
            bool CheckFormat = false;
            if (CheckStateButton(btn_3DPDF))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_STL))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_STP))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_SAT))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_3DDWG))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_2DDWG))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_VIEW))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }
            if (CheckStateButton(btn_xt))
            {
                CheckFormat = true;
                sum = sum + FilesToExport.Count;
            }

            if (CheckFormat == false)
            {
                AnnounceProgress(1);
                return;
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
                _Document iptDoc = _InvApplication.Documents.Open(item);
               
                if (CheckStateButton(btn_3DPDF))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "3D PDF");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    try
                    {
                        ExportTo3DPDF(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_STL))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "STL");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    try
                    {
                        ExportToSTL(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_STP))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "STP");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    try
                    {
                        ExportToSTP(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_SAT))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "SAT");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    try
                    {
                        ExportToSAT(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_3DDWG))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "3D DWG");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    try
                    {
                        ExportTo3DDWG(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_2DDWG))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "2D DWG");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    
                    try
                    {
                        ExportTo2DDWG(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_VIEW))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "SEPARATED VIEW");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }
                    
                    try
                    {
                        ExportToSEPARATEDVIEW(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                if (CheckStateButton(btn_xt))
                {
                    count = count + 1;
                    AnnounceProgress(sum, count);
                    string path = GetFullFileName(item, "X_T");
                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
                    }

                    try
                    {
                        ExportToX_T(_InvApplication, iptDoc, path);
                    }
                    catch
                    {
                        Errors(item);
                    }
                }
                iptDoc.Close(true);
            }
            _InvApplication.SilentOperation = false;
            AnnounceProgress(3);
            btn_error.Text = error.ToString();
        }

        private void btn_3DPDF_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_3DPDF);
        }

        private void btn_STL_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_STL);
        }

        private void btn_STP_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_STP);
        }

        private void btn_SAT_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_SAT);
        }

        private void btn_3DDWG_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_3DDWG);
        }

        private void btn_2DDWG_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_2DDWG);
        }

        private void btn_VIEW_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_VIEW);
            if (btn_VIEW.BackColor == SystemColors.Window)
            {
                gb_SV.Enabled = true;
            }
            else
            {
                gb_SV.Enabled = false;
            }
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            string message;
            if (error == 0)
            {
                message = string.Format("{0} Error", error);
            }
            else
            {
                message = string.Format("{0} Errors:", error);
                foreach(var item in ListError)
                {
                    message = string.Format(message + "\n" + item);
                }
            }
            MessageBox.Show(message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btn_xt_Click(object sender, EventArgs e)
        {
            SwitchStateButton(btn_xt);
        }
        }
    }


