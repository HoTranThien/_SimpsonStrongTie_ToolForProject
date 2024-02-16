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

namespace Edit_Title_Block_Inventor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateTitleBlock(Inventor.DrawingDocument dwg)
        {
            var Properties = dwg.PropertySets;
            for (int i = 1; i < dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes.Count + 1; i++)
            {
                if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<MODEL NO>")
                {
                    dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_modelNo.Text);
                }
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<PART NUMBER>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_dwgNo.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<REVISION NUMBER>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_rev.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<REV DATE>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_revDate.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<DESCRIPTION>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_description.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<BY>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_by.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<AUTHOR>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_DrawnBy.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<SCALE>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_scale.Text);
                //}
                //if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<DATE>")
                //{
                //    //dwg.ActiveSheet.TitleBlock.SetPromptResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i], txt_date.Text);
                //}
            }
            Properties["Inventor Summary Information"]["Author"].Value = txt_DrawnBy.Text;
            Properties["Inventor Summary Information"]["Revision Number"].Value = txt_rev.Text;

            Properties["Design Tracking Properties"]["Part Number"].Value = txt_dwgNo.Text;
            Properties["Design Tracking Properties"]["Description"].Value = txt_description.Text;

            Properties["Inventor User Defined Properties"]["Date"].Value = txt_date.Text;
            Properties["Inventor User Defined Properties"]["REV Date"].Value = txt_revDate.Text;
            Properties["Inventor User Defined Properties"]["By"].Value = txt_by.Text;

            for (int i = 1; i < Properties["Inventor User Defined Properties"].Count; i++ )
            {
                string name = Properties["Inventor User Defined Properties"][i].Name;

            }
            //Properties["Inventor User Defined Properties"]["Scale"].Value = txt_scale.Text;
            //Properties["Inventor User Defined Properties"]["SHEET"].Value = txt_sheet.Text;
            dwg.Update();
            MessageBox.Show("Complete!");
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
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

            var doc = _InvApplication.ActiveDocument;
            var dwg = doc as Inventor.DrawingDocument;
            if (doc == null)
            {
                MessageBox.Show("Please Open Your Drawing!");
            }
            else if (System.IO.Path.GetExtension(doc.FullFileName).ToLower() == ".dwg" || System.IO.Path.GetExtension(doc.FullFileName).ToLower() == ".idw")
            {
                var Properties = dwg.PropertySets;

                if (!string.IsNullOrEmpty(txt_ActiveDWG.Text))
                {
                    if(Properties["Design Tracking Properties"]["Part Number"].Value != txt_dwgNo.Text)
                    {
                        if(MessageBox.Show(string.Format("New Drawing No is different from its original.\nDo you want to continue?"), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            UpdateTitleBlock(dwg);
                        }
                    }
                    else
                    {
                        UpdateTitleBlock(dwg);
                    }
                }
                else MessageBox.Show("Please Load Your Drawing!");
            }
            else MessageBox.Show("Please Open Your Drawing!");

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
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
            
            var doc = _InvApplication.ActiveDocument;
            var dwg = doc as Inventor.DrawingDocument;
            
            if (doc==null)
            {
                MessageBox.Show("Please Open Your Drawing!");
            }
            else if (System.IO.Path.GetExtension(doc.FullFileName).ToLower() == ".dwg" || System.IO.Path.GetExtension(doc.FullFileName).ToLower() == ".idw")
            {
                var Properties = dwg.PropertySets;

                for (int i = 1; i < dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes.Count + 1; i++)
                {
                    if (dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i].Text == "<MODEL NO>")
                    {
                        txt_modelNo.Text = dwg.ActiveSheet.TitleBlock.GetResultText(dwg.ActiveSheet.TitleBlock.Definition.Sketch.TextBoxes[i]);
                        break;
                    }
                }

                txt_ActiveDWG.Text = dwg.DisplayName;

                txt_DrawnBy.Text = btn_Drlock.ImageIndex == 1 ? Properties["Inventor Summary Information"]["Author"].Value : txt_DrawnBy.Text;
                txt_rev.Text = btn_REVlock.ImageIndex == 1 ? Properties["Inventor Summary Information"]["Revision Number"].Value : txt_rev.Text;

                txt_dwgNo.Text = Properties["Design Tracking Properties"]["Part Number"].Value;
                txt_description.Text = btn_Prlock.ImageIndex == 1? Properties["Design Tracking Properties"]["Description"].Value : txt_description.Text;

                txt_date.Text = btn_Dalock.ImageIndex == 1 ? Properties["Inventor User Defined Properties"]["Date"].Value : txt_date.Text;
                txt_revDate.Text = btn_REVdatelock.ImageIndex == 1 ? Properties["Inventor User Defined Properties"]["REV Date"].Value : txt_revDate.Text;
                txt_by.Text = btn_Bylock.ImageIndex == 1 ? Properties["Inventor User Defined Properties"]["By"].Value : txt_by.Text;
                //txt_scale.Text = Properties["Inventor User Defined Properties"]["Scale"].Value;
                //txt_sheet.Text = Properties["Inventor User Defined Properties"]["Sheet"].Value;
            }
            else MessageBox.Show("Please Open Your Drawing!");
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_update.PerformClick();
            }
        }

        private void btn_REVlock_Click(object sender, EventArgs e)
        {
            btn_REVlock.ImageIndex = btn_REVlock.ImageIndex == 0 ? 1 : 0;
            if (btn_REVlock.ImageIndex == 0)
            {
                txt_rev.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_rev.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btn_REVdatelock_Click(object sender, EventArgs e)
        {
            btn_REVdatelock.ImageIndex = btn_REVdatelock.ImageIndex == 0 ? 1 : 0;
            if (btn_REVdatelock.ImageIndex == 0)
            {
                txt_revDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_revDate.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btn_Prlock_Click(object sender, EventArgs e)
        {
            btn_Prlock.ImageIndex = btn_Prlock.ImageIndex == 0 ? 1 : 0;
            if (btn_Prlock.ImageIndex == 0)
            {
                txt_description.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_description.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btn_Bylock_Click(object sender, EventArgs e)
        {
            btn_Bylock.ImageIndex = btn_Bylock.ImageIndex == 0 ? 1 : 0;
            if (btn_Bylock.ImageIndex == 0)
            {
                txt_by.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_by.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btn_Drlock_Click(object sender, EventArgs e)
        {
            btn_Drlock.ImageIndex = btn_Drlock.ImageIndex == 0 ? 1 : 0;
            if (btn_Drlock.ImageIndex == 0)
            {
                txt_DrawnBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_DrawnBy.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btn_Dalock_Click(object sender, EventArgs e)
        {
            btn_Dalock.ImageIndex = btn_Dalock.ImageIndex == 0 ? 1 : 0;
            if (btn_Dalock.ImageIndex == 0)
            {
                txt_date.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            else txt_date.BackColor = System.Drawing.SystemColors.Window;
        }
    }
}
