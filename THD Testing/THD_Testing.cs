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
using ClosedXML.Excel;
using Inventor;

namespace THD_Testing
{
    public partial class THD_Testing : Form
    {
        public THD_Testing()
        {
            InitializeComponent();
            txt_Annoucement.Text = Announcement(0);
        }
        public List<THD_Member> THD_List = new List<THD_Member>();
        public string[] Source_File;
        public string st_error = "ERROR";
        public string st_done = "DONE";

        
        THD_01 THD25 = new THD_01(0.2410, 0.04, 0.545, 0.4210, 0.03, 0.29, 0.03905, 0.0175, 0.270, "THD25");
        THD_01 THD37 = new THD_01(0.3730, 0.06, 0.785, 0.6290, 0.05, 0.48, 0.04685, 0.0250, 0.380, "THD37");
        THD_01 THD50 = new THD_01(0.4995, 0.09, 1.045, 0.8400, 0.05, 0.64, 0.07805, 0.0250, 0.505, "THD50");
        THD_01 THD62 = new THD_01(0.6265, 0.11, 1.280, 1.0585, 0.06, 0.81, 0.09375, 0.0320, 0.615, "THD62");
        THD_01 THD75 = new THD_01(0.7460, 0.13, 1.570, 1.2645, 0.06, 0.95, 0.09375, 0.0400, 0.725, "THD75");

        private void btn_link_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog SourceDialog = new CommonOpenFileDialog();
            SourceDialog.Multiselect = false;
            SourceDialog.Title = "Select The Source Folder";
            SourceDialog.IsFolderPicker = true;
            if (SourceDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_link.Text = SourceDialog.FileName;
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            txt_Annoucement.Text = Announcement(2);
            THD_List.Clear();
            int count = 0;
            FilesInFolder ListFile = new FilesInFolder();

            Source_File = Directory.GetFiles(txt_link.Text);

            //Create THD models folder
            string THDmodels = System.IO.Path.Combine(txt_link.Text + @"\THD models");
            Directory.CreateDirectory(THDmodels);

            //Get link of all files in source folder
            foreach(var fi in Directory.GetFiles(txt_link.Text))
            {
                
                if (System.IO.Path.GetExtension(fi) == ".xlsx") ListFile.Excel = fi;
                else if (System.IO.Path.GetExtension(fi) == ".iam")
                {
                    if (fi.Contains("Close")) ListFile.Assem_Cl_Cr = fi;
                    else if (fi.Contains("Open")) ListFile.Assem_Op_Cr = fi;
                }
                else if (System.IO.Path.GetExtension(fi) == ".ipt")
                {
                    if (fi.Contains("Close") && fi.Contains("01")) ListFile.Conc_Cl_Cr_01 = fi;
                    else if (fi.Contains("Open")&& fi.Contains("01")) ListFile.Conc_Op_Cr_01 = fi;
                    else if (fi.Contains("Close") && fi.Contains("02")) ListFile.Conc_Cl_Cr_02 = fi;
                    else if (fi.Contains("Open") && fi.Contains("02")) ListFile.Conc_Op_Cr_02 = fi;
                    else if (fi.Contains("THD")) ListFile.THD_Temp = fi;
                }
            }

            //Read Excel file

            ReadExcelFile(ListFile.Excel);

            //Connecting with Inventor
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
            
            foreach (var item in THD_List)
            {
                txt_Annoucement.Text = AnnounceProgress(count);
                count++;
                if (item.Status == st_done) continue;
                item.Status = st_done;

                //Copy template
                string THDitem = System.IO.Path.Combine(THDmodels,item.Model_Name);
                if (Directory.Exists(THDitem)) Directory.Delete(THDitem, true);
                Directory.CreateDirectory(THDitem);
                FilesInFolder NewTHD = new FilesInFolder
                (
                    System.IO.Path.Combine(THDitem, string.Format(item.Model_Name + ".ipt")),
                    System.IO.Path.Combine(THDitem, string.Format(System.IO.Path.GetFileName(ListFile.Conc_Cl_Cr_01))),
                    System.IO.Path.Combine(THDitem, string.Format(System.IO.Path.GetFileName(ListFile.Conc_Cl_Cr_02))),
                    System.IO.Path.Combine(THDitem, string.Format(System.IO.Path.GetFileName(ListFile.Conc_Op_Cr_01))),
                    System.IO.Path.Combine(THDitem, string.Format(System.IO.Path.GetFileName(ListFile.Conc_Op_Cr_02))),
                    System.IO.Path.Combine(THDitem, string.Format(item.Model_Name + " with Crack Close" + ".iam")),
                    System.IO.Path.Combine(THDitem, string.Format(item.Model_Name + " with Crack Open" + ".iam"))
                );

                System.IO.File.Copy(ListFile.THD_Temp, NewTHD.THD_Temp);
                System.IO.File.Copy(ListFile.Assem_Cl_Cr, NewTHD.Assem_Cl_Cr);
                System.IO.File.Copy(ListFile.Assem_Op_Cr, NewTHD.Assem_Op_Cr);
                System.IO.File.Copy(ListFile.Conc_Cl_Cr_01, NewTHD.Conc_Cl_Cr_01);
                System.IO.File.Copy(ListFile.Conc_Cl_Cr_02, NewTHD.Conc_Cl_Cr_02);
                System.IO.File.Copy(ListFile.Conc_Op_Cr_01, NewTHD.Conc_Op_Cr_01);
                System.IO.File.Copy(ListFile.Conc_Op_Cr_02, NewTHD.Conc_Op_Cr_02);

                //Update THD crew
                void SetNewParameter(string ipt)
                {
                    if (item.Status == st_error) return;
                    var Doc = _InvApplication.Documents.Open(ipt) as PartDocument;
                    double G = 0;
                    bool NA = double.TryParse(item.Tip_Taper_G, out G);

                    UserParameters userparams = Doc.ComponentDefinition.Parameters.UserParameters;

                    foreach (UserParameter para in userparams)
                    {
                        if (para.Name == "L") para.Value = double.Parse(item.Length_B) * 2.54;
                        else if (para.Name == "TL") para.Value = double.Parse(item.Length_C) * 2.54;
                        else if (para.Name == "D1") para.Value = double.Parse(item.Minor_Dia_E) * 2.54;
                        else if (para.Name == "D2") para.Value = double.Parse(item.Major_Dia_D) * 2.54;
                        else if (para.Name == "A1") para.Value = double.Parse(item.Top_Angle)/(180/Math.PI);
                        else if (para.Name == "A2") para.Value = double.Parse(item.Bottom_Angle) / (180 / Math.PI);
                        else if (para.Name == "G") para.Value = G * 2.54;
                        else if (para.Name == "P") para.Value = double.Parse(item.Pitch_F) * 2.54;
                        else if (para.Name == "L1") para.Value = double.Parse(item.Embedment_Depth) * 2.54;
                        else if (para.Name == "D3") para.Value = double.Parse(item.Hole_Dia) * 2.54;
                        else if (para.Name == "H_A") para.Value = item.THD_01.A * 2.54;
                        else if (para.Name == "H_C") para.Value = item.THD_01.C * 2.54;
                        else if (para.Name == "H_E") para.Value = item.THD_01.E * 2.54;
                        else if (para.Name == "H_F") para.Value = item.THD_01.F * 2.54;
                        else if (para.Name == "H_H") para.Value = item.THD_01.H * 2.54;
                        else if (para.Name == "H_I") 
                        {
                            para.Value = item.THD_01.I * 2.54;

                            //Create a textbox and then extrude to create a stamp
                            PartComponentDefinition _Comp = Doc.ComponentDefinition;
                            PlanarSketches _sketches = _Comp.Sketches;
                            PlanarSketch _sketch = _sketches["Stamp"];
                            TextStyle _Stamp = Doc.TextStyles["Stamp"];
                            _Stamp.FontSize = para.Value / (3.2);

                            
                            _sketch.Edit();
                            TransientGeometry _TG = _InvApplication.TransientGeometry;
                            _sketch.TextBoxes.AddFitted(_TG.CreatePoint2d(0,0), item.Head_Stamp, _Stamp);
                            _sketch.TextBoxes[1].HorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter;
                            _sketch.TextBoxes[1].VerticalJustification = VerticalTextAlignmentEnum.kAlignTextMiddle;
                            _sketch.ExitEdit();

                            Profile _Pr = _sketch.Profiles.AddForSolid();
                            ExtrudeDefinition _ExDef = _Comp.Features.ExtrudeFeatures.CreateExtrudeDefinition(_Pr, PartFeatureOperationEnum.kCutOperation);
                            _ExDef.SetDistanceExtent(0.1/2.54, PartFeatureExtentDirectionEnum.kNegativeExtentDirection);
                            ExtrudeFeature _EX = _Comp.Features.ExtrudeFeatures.Add(_ExDef);
                        }
                        else if (para.Name == "H_J") para.Value = item.THD_01.J * 2.54;
                        else if (para.Name == "H_K") para.Value = item.THD_01.K * 2.54;
                        else if (para.Name == "H_L") para.Value = item.THD_01.L * 2.54;
                        else if (para.Name == "Head_Stamp") para.Value = item.Head_Stamp;
                    }
                    Doc.Update();
                    foreach (PartFeature partFe in Doc.ComponentDefinition.Features)
                    {
                        if (partFe.HealthStatus == HealthStatusEnum.kCannotComputeHealth || partFe.HealthStatus == HealthStatusEnum.kDriverLostHealth)
                        {
                            item.Status = st_error;
                            break;
                        }
                    }
                    
                    Doc.Close();
                }

                SetNewParameter(NewTHD.THD_Temp);
                SetNewParameter(NewTHD.Conc_Cl_Cr_01);
                SetNewParameter(NewTHD.Conc_Cl_Cr_02);
                SetNewParameter(NewTHD.Conc_Op_Cr_01);
                SetNewParameter(NewTHD.Conc_Op_Cr_02);

                //Update and check Interference Assembly model
                void UpdateAndCheckInterferenceAssembly (AssemblyDocument d)
                {
                    if (item.Status == st_error)
                    {
                        d.Close();
                        return;
                    }
                    //Update model
                    foreach (FileDescriptor RefFile in d.File.ReferencedFileDescriptors)
                    {
                        //MessageBox.Show(RefFile.FullFileName);
                        if (System.IO.Path.GetFileNameWithoutExtension(RefFile.FullFileName) == System.IO.Path.GetFileNameWithoutExtension(ListFile.THD_Temp)) RefFile.ReplaceReference(NewTHD.THD_Temp);
                        else if (System.IO.Path.GetFileNameWithoutExtension(RefFile.FullFileName) == System.IO.Path.GetFileNameWithoutExtension(ListFile.Conc_Cl_Cr_01)) RefFile.ReplaceReference(NewTHD.Conc_Cl_Cr_01);
                        else if (System.IO.Path.GetFileNameWithoutExtension(RefFile.FullFileName) == System.IO.Path.GetFileNameWithoutExtension(ListFile.Conc_Cl_Cr_02)) RefFile.ReplaceReference(NewTHD.Conc_Cl_Cr_02);
                        else if (System.IO.Path.GetFileNameWithoutExtension(RefFile.FullFileName) == System.IO.Path.GetFileNameWithoutExtension(ListFile.Conc_Op_Cr_01)) RefFile.ReplaceReference(NewTHD.Conc_Op_Cr_01);
                        else if (System.IO.Path.GetFileNameWithoutExtension(RefFile.FullFileName) == System.IO.Path.GetFileNameWithoutExtension(ListFile.Conc_Op_Cr_02)) RefFile.ReplaceReference(NewTHD.Conc_Op_Cr_02);
                    }

                    //Update Parameter
                    UserParameters userparams = d.ComponentDefinition.Parameters.UserParameters;
                    foreach (UserParameter para in userparams)
                    {
                        if (para.Name == "L1") para.Value = double.Parse(item.Embedment_Depth) * 2.54;
                    }
                        d.Update();

                    if(d.FullFileName == NewTHD.Assem_Op_Cr)
                    {
                        InterferenceResults Results;
                        ObjectCollection CheckSet = _InvApplication.TransientObjects.CreateObjectCollection();
                        foreach (ComponentOccurrence Occ in d.ComponentDefinition.Occurrences)
                        {
                            CheckSet.Add(Occ);
                        }

                        Results = d.ComponentDefinition.AnalyzeInterference(CheckSet);
                        double TotalVolume = 0;
                        foreach (InterferenceResult re in Results)
                        {
                            TotalVolume = TotalVolume + (re.Volume / (Math.Pow(2.54, 3)));
                        }
                        item.Interference = TotalVolume;
                    }
                    d.Close();
                }
                var Doc1 = _InvApplication.Documents.Open(NewTHD.Assem_Op_Cr) as AssemblyDocument;
                UpdateAndCheckInterferenceAssembly(Doc1);
                var Doc2 = _InvApplication.Documents.Open(NewTHD.Assem_Cl_Cr) as AssemblyDocument;
                UpdateAndCheckInterferenceAssembly(Doc2);
                

                //Delete Oldversions folder
                string oldversions = System.IO.Path.Combine(THDitem, "OldVersions");
                if (Directory.Exists(oldversions))
                {
                    Directory.Delete(oldversions, true);
                }
                    
            }
            UpdateExcelFile(ListFile.Excel);
            _InvApplication.SilentOperation = false;
            if (txt_Annoucement.Text != Announcement(3)) txt_Annoucement.Text = Announcement(10);
            
        }

        public void ReadExcelFile(string ex)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook(ex);
                var ws = wb.Worksheet(1);
                for (int i = 1; i <= ws.LastRowUsed().RowNumber(); i++)
                {
                    string thd_name = ws.Row(i).Cell(16).Value.ToString();
                    THD_01 thd01 = THD25;
                    if (thd_name.Contains("THD"))
                    {
                        thd_name =  thd_name.Substring(0, 8);
                        double inter = 0;
                        double.TryParse(ws.Row(i).Cell(17).Value.ToString(), out inter);
                        if (thd_name.Contains("THD25"))
                        {
                            THD25.No = thd_name;
                            thd01 = THD25;
                        }
                        else if (thd_name.Contains("THD37"))
                        {
                            THD37.No = thd_name;
                            thd01 = THD37;
                        }
                        else if (thd_name.Contains("THD50"))
                        {
                            THD50.No = thd_name;
                            thd01 = THD50;
                        }
                        else if (thd_name.Contains("THD62"))
                        {
                            THD62.No = thd_name;
                            thd01 = THD62;
                        }
                        else
                        {
                            THD75.No = thd_name;
                            thd01 = THD75;
                        }

                        THD_Member thd = new THD_Member
                        (
                            ws.Row(i).Cell(2).Value.ToString(),
                            ws.Row(i).Cell(3).Value.ToString(),
                            ws.Row(i).Cell(4).Value.ToString(),
                            ws.Row(i).Cell(5).Value.ToString(),
                            ws.Row(i).Cell(6).Value.ToString(),
                            ws.Row(i).Cell(7).Value.ToString(),
                            ws.Row(i).Cell(8).Value.ToString(),
                            ws.Row(i).Cell(9).Value.ToString(),
                            ws.Row(i).Cell(10).Value.ToString(),
                            ws.Row(i).Cell(11).Value.ToString(),
                            ws.Row(i).Cell(12).Value.ToString(),
                            ws.Row(i).Cell(13).Value.ToString(),
                            ws.Row(i).Cell(14).Value.ToString(),
                            ws.Row(i).Cell(15).Value.ToString(),
                            ws.Row(i).Cell(16).Value.ToString(),
                            inter,
                            i,
                            ws.Row(i).Cell(18).Value.ToString(),
                            thd01
                        );
                        THD_List.Add(thd);
                    }
                }
            }
            catch
            {
                txt_Annoucement.Text =  Announcement(3);
                return;
            }
            
            
        }
        public void UpdateExcelFile(string ex)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook(ex);
                var ws = wb.Worksheet(1);
                foreach (var thd in THD_List)
                {
                    ws.Row(thd.RowIndex).Cell(17).Value = thd.Interference;
                    ws.Row(thd.RowIndex).Cell(18).Value = thd.Status;
                }
                wb.Save();
            }
            catch
            {
                txt_Annoucement.Text = Announcement(3);
            }
            
        }
        public string Announcement(int i)
        {
            switch (i)
            {
                case 0:
                    return "Please input the Template folder! ";
                case 1:
                    return "Ready! ";
                case 2:
                    return "In Progress... ";
                case 3:
                    return "Please close the Excel file! ";
                default:
                    return "Complete!!! ";
            }
        }
        public string AnnounceProgress(int i)
        {

            return string.Format("In Progress...{0}/{1} ", i, THD_List.Count());
        }

        private void txt_link_TextChanged(object sender, EventArgs e)
        {
            txt_Annoucement.Text= Announcement(1);
        }
    }
}
