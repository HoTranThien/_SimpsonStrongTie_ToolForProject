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
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace Import_CAD
{
    public partial class ImportView_Form : System.Windows.Forms.Form
    {
        Document Doc;
        UIDocument UIDoc;
        public ImportView_Form(Document doc, UIDocument uidoc)
        {
            InitializeComponent();
            Doc = doc;
            UIDoc = uidoc;
            txt_link.Text = Properties.Settings.Default.Link;
            cb_Unit.Text = Properties.Settings.Default.Unit;
            label1.Focus();
        }

        public void InsertView(string view)
        {
            MessageBox.Show("sadas");
            //Save setting data
            Properties.Settings.Default.Link = txt_link.Text;
            Properties.Settings.Default.Unit = cb_Unit.Text;

            //Import View
            string DocName = Path.GetFileNameWithoutExtension(Doc.PathName);
            string DWGImported = "";
            
            if (Directory.Exists(txt_link.Text))
            {
                foreach (var file in Directory.GetFiles(txt_link.Text))
                {
                    if (Path.GetFileNameWithoutExtension(file).Contains(DocName) && (Path.GetExtension(file) == ".dwg") && Path.GetFileNameWithoutExtension(file).ToLower().Contains(view))
                    {
                        DWGImported = file;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("The link is not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DWGImportOptions dwgImportOption = new DWGImportOptions();
            dwgImportOption.ColorMode = ImportColorMode.Preserved;
            dwgImportOption.CustomScale = 0.0;
            if (cb_Unit.Text == "inch")
            {
                dwgImportOption.Unit = ImportUnit.Inch;
            }
            else dwgImportOption.Unit = ImportUnit.Millimeter;
            dwgImportOption.Placement = ImportPlacement.Origin;
            Autodesk.Revit.DB.View currentView = Doc.ActiveView;
            ElementId elementID = null;
            if (!string.IsNullOrWhiteSpace(DWGImported))
            {
                using (Transaction Tran = new Transaction(Doc, "ImportView"))
                {
                    Tran.Start();
                    Doc.Import(DWGImported, dwgImportOption, currentView, out elementID);
                    Tran.Commit();
                    
                }
            }
            else MessageBox.Show("Can't find an appropriate DWG drawing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void btn_Front_Click(object sender, EventArgs e)
        {
            InsertView("front");
            this.Close();
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            InsertView("top");
            this.Close();
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            InsertView("left");
            this.Close();
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            InsertView("right");
            this.Close();
        }

        private void ImportView_Form_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D1) btn_Front_Click(sender, e);
            else if (e.KeyCode == Keys.D2) btn_Top_Click(sender, e);
            else if (e.KeyCode == Keys.D3) btn_Left_Click(sender, e);
            else if (e.KeyCode == Keys.D4) btn_Right_Click(sender, e);
        }
    }
}
