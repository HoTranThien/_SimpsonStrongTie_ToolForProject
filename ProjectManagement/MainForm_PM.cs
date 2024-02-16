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


namespace ProjectManagement
{
    public partial class MainForm_PM : Form
    {
        public MainForm_PM()
        {
            InitializeComponent();
        }

        public string source = Properties.Settings.Default.Link;
        public string data = Path.Combine(Properties.Settings.Default.Link, "ES Data");


        private void Form1_Load(object sender, EventArgs e)
        {
            txt_link.Text = source;
            lv_ESNumber.Items.Clear();
            if (!Directory.Exists(data))
            {
                Directory.CreateDirectory(data);
            }
            Home();
        }
        private void btn_NewProject_Click(object sender, EventArgs e)
        {
          
            var forminput = new FormInput_PM();
            if (forminput.ShowDialog() == DialogResult.OK)
            {
                string newES = GetESPath(data,forminput.ProjectName);
                if (File.Exists(newES)) MessageBox.Show("This Project is existent!");
                else
                {
                    var newProject = File.Create(newES);
                    lv_ESNumber.Items.Add(Path.GetFileNameWithoutExtension(newES));
                    lv_ESNumber.Items[lv_ESNumber.Items.Count - 1].ImageIndex = 4;
                    newProject.Close();
                }
            }
            Home();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            Home();
        }


        private void lv_ESNumber_MouseClick(object sender, MouseEventArgs e)
        {
            
            lv_source.Items.Clear();

            foreach (var li in File.ReadAllLines(GetESPath(data,lv_ESNumber.FocusedItem.Text)))
            {
                lv_source.Items.Add(Path.GetFileName(li));
                int co = lv_source.Items.Count-1;
                string ex = Path.GetExtension(li);
                switch (ex.ToLower())
                {
                    case ".dwg":
                        lv_source.Items[co].ImageIndex = 0;
                        break;
                    case ".ipt":
                        lv_source.Items[co].ImageIndex = 1;
                        break;
                    case ".idw":
                        lv_source.Items[co].ImageIndex = 2;
                        break;
                    case ".iam":
                        lv_source.Items[co].ImageIndex = 3;
                        break;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lv_ESNumber.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    ctm_ES.Show(Cursor.Position);
                }
            }
            SumItem();
        }
        public string GetESPath(string so, string na)
        {
            na = Path.Combine(so, string.Format(na + ".txt"));
            return na;
        }

        public void Home()
        {
            lv_source.Items.Clear();
            lv_ESNumber.Items.Clear();
            MoveItemsTo.DropDown.Items.Clear();
            int count = 0;
            string[] Ex = new string[] { "*.idw", "*.dwg", "*.ipt", "*.iam" };
            foreach (var i in Ex)
            {
                foreach (var file in Directory.GetFiles(source, i))
                {
                    lv_source.Items.Add(Path.GetFileName(file));
                    switch (i)
                    {
                        case "*.dwg":
                            lv_source.Items[count].ImageIndex = 0;
                            break;
                        case "*.ipt":
                            lv_source.Items[count].ImageIndex = 1;
                            break;
                        case "*.idw":
                            lv_source.Items[count].ImageIndex = 2;
                            break;
                        case "*.iam":
                            lv_source.Items[count].ImageIndex = 3;
                            break;
                    }
                    count = count + 1;
                }
            }
            
            foreach (var txtfile in Directory.GetFiles(data, "*.txt"))
            {
                lv_ESNumber.Items.Add(Path.GetFileNameWithoutExtension(txtfile));
                lv_ESNumber.Items[lv_ESNumber.Items.Count - 1].ImageIndex = 4;
                MoveItemsTo.DropDown.Items.Add(Path.GetFileNameWithoutExtension(txtfile));
                List<string>[] ListToSort = new List<string>[5];
                for (int j = 0; j<5;j++)
                {
                    List<string> itemList = new List<string>();
                    ListToSort[j] = itemList;
                }
                foreach (var li in File.ReadAllLines(Path.GetFullPath(txtfile)))
                {
                    var getnamedata = Path.GetFileNameWithoutExtension(li);
                    foreach (ListViewItem it in lv_source.Items)
                    {
                        if(Path.GetFileName(li)==it.Text)
                        {
                            lv_source.Items.Remove(it);

                        }
                        string getnamesource = Path.GetFileNameWithoutExtension(Path.Combine(source, it.Text));
                        if (getnamedata == getnamesource)
                        {
                            lv_source.Items.Remove(it);
                            string itemadded = Path.Combine(source, it.Text);
                            if (Path.GetExtension(itemadded).ToLower() == ".idw")
                                ListToSort[0].Add(itemadded);
                            else if (Path.GetExtension(itemadded).ToLower() == ".dwg")
                                ListToSort[1].Add(itemadded);
                            else if (Path.GetExtension(itemadded).ToLower() == ".ipt")
                                ListToSort[2].Add(itemadded);
                            else if (Path.GetExtension(itemadded).ToLower() == ".iam")
                                ListToSort[3].Add(itemadded);
                        }
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    ListToSort[i].Sort();
                    foreach (var item in ListToSort[i])
                    {
                        ListToSort[4].Add(item);
                    }
                }
                File.WriteAllLines(txtfile, ListToSort[4]);
            }
            SumItem();
        }

        private void lv_source_MouseClick(object sender, MouseEventArgs e)
        { 

            if (e.Button == MouseButtons.Right)
            {
                 var focusedItem = lv_source.FocusedItem;
                 if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                 {
                    
                    string pathfocuseditem = Path.Combine(source,focusedItem.Text);
                    FileInfo fInfo = new FileInfo(pathfocuseditem);
                    var a = fInfo.IsReadOnly;
                    if (fInfo.IsReadOnly)
                    {
                        ReadOnly.CheckState = CheckState.Checked;
                    }
                    else ReadOnly.CheckState = CheckState.Unchecked;

                        if (lv_ESNumber.FocusedItem != null && lv_ESNumber.FocusedItem.Focused)
                        {
                            ctm_item.Items[1].Visible = true;
                            ctm_item.Items[2].Visible = false;
                            ctm_item.Show(Cursor.Position);
                        }
                        else
                        {
                            ctm_item.Items[2].Visible = true;
                            ctm_item.Items[1].Visible = false;
                            ctm_item.Show(Cursor.Position);
                        }
                 }
            }
            txt_sum.Text = string.Format("{0} items", lv_source.Items.Count);
            if (lv_source.FocusedItem != null && lv_source.FocusedItem.Bounds.Contains(e.Location))
            {

                if (lv_source.SelectedItems.Count <= 1)
                {
                    txt_sum.Text = string.Format("1 item selected | {0} items", lv_source.Items.Count);
                }
                else if (lv_source.SelectedItems.Count > 1)
                {
                    txt_sum.Text = string.Format("{0} items selected | {1} items", lv_source.SelectedItems.Count, lv_source.Items.Count);
                }
            }
            else SumItem();
        }
        public void SumItem()
        {
            if (lv_source.Items.Count <= 1)
                txt_sum.Text = string.Format("{0} item", lv_source.Items.Count);
            else txt_sum.Text = string.Format("{0} items", lv_source.Items.Count);
        }
        private void lv_source_MouseDown(object sender, MouseEventArgs e)
        {
                txt_sum.Text = string.Format("{0} items", lv_source.Items.Count);
        }
        private void DeleteES_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Are you sure to delete all files in Project:\n" + lv_ESNumber.FocusedItem.Text+"?"), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (var line in File.ReadAllLines(GetESPath(data, lv_ESNumber.FocusedItem.Text)))
                {
                    File.SetAttributes(line, FileAttributes.Normal);
                    File.Delete(line);
                    string clb;
                    if (Path.GetExtension(line).ToLower() == ".idw")
                    {
                        clb = Path.ChangeExtension(line ,".DWG.CLB");
                    }
                    else clb = clb = string.Format(line + ".CLB");
                    if (File.Exists(clb))
                    {
                        File.SetAttributes(clb, FileAttributes.Normal);
                        File.Delete(clb);
                    }
                }
                File.Delete(GetESPath(data, lv_ESNumber.FocusedItem.Text));
                lv_ESNumber.Items.Remove(lv_ESNumber.FocusedItem);
            }
            Home();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_source.SelectedItems)
            {
                string itemname = item.ToString();
                itemname = itemname.Substring(15, itemname.Length - 16);
                foreach (var itsource in lv_source.Items)
                {
                    string itsouname = itsource.ToString().Substring(15, itsource.ToString().Length - 16);
                    if (Path.GetFileNameWithoutExtension(Path.Combine(source,itemname)) == Path.GetFileNameWithoutExtension(Path.Combine(source,itsouname)))
                    {
                        RemoveItemFromTxt(itsouname);
                        lv_source.Items.Remove(item);
                    }
                }

            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete these files?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (ListViewItem file in lv_source.SelectedItems)
                {
                    string itemnametodelete = file.ToString().Substring(15, file.ToString().Length - 16);
                    string pathfiletodelete = Path.Combine(source, itemnametodelete);
                    File.SetAttributes(pathfiletodelete, FileAttributes.Normal);
                    File.Delete(pathfiletodelete);
                    string clb;
                    if (Path.GetExtension(pathfiletodelete).ToLower() == ".idw")
                    {
                        clb = Path.ChangeExtension(pathfiletodelete, ".DWG.CLB");
                    }
                    else clb = clb = string.Format(pathfiletodelete + ".CLB");
                    if (File.Exists(clb))
                    {
                        File.SetAttributes(clb, FileAttributes.Normal);
                        File.Delete(clb);
                    }

                    lv_source.Items.Remove(file);
                    if (lv_ESNumber.FocusedItem != null)
                    {
                        RemoveItemFromTxt(itemnametodelete);
                    }
                    
                }
            }
        }

        public void RemoveItemFromTxt (string ItemName)
        {
            string ESname = lv_ESNumber.FocusedItem.Text;
            string PathES = GetESPath(data,ESname);
            string line = Path.Combine(source, ItemName);
            List<string> linetokeep =  File.ReadAllLines(PathES).Where(l => l != line).ToList();
            File.Delete(PathES);
            File.WriteAllLines(PathES, linetokeep);
        }

        private void MoveItemsTo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string ESchosen = e.ClickedItem.Text;
            foreach (var item in lv_source.SelectedItems)
            {
                string itemname = item.ToString().Substring(15, item.ToString().Length - 16);
                using (StreamWriter stream = File.AppendText(GetESPath(data, ESchosen)))
                {
                    stream.WriteLine(Path.Combine(source, itemname));
                }
            }
            Home();
        }

        private void OpenFile_Click(object sender, EventArgs e)
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
            _InvApplication.SilentOperation = true;
            foreach (var file in lv_source.SelectedItems)
            {
                string filename = file.ToString().Substring(15, file.ToString().Length - 16);
                var doc = _InvApplication.Documents.Open(Path.Combine(source,filename));
            }
            _InvApplication.SilentOperation = false;
        }

        private void PackAndGo_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string foldername = lv_ESNumber.FocusedItem.Text;
                string PathFolderToSaveIn = dialog.FileName;
                string PathFolderToCreate = Path.Combine(PathFolderToSaveIn, foldername);
                if (!Directory.Exists(PathFolderToCreate))
                {
                    Directory.CreateDirectory(Path.Combine(PathFolderToCreate));
                    foreach (var fi in File.ReadAllLines(GetESPath(data,foldername)))
                    {
                        File.Copy(fi,Path.Combine(PathFolderToCreate,Path.GetFileName(fi)));
                    }
                    MessageBox.Show("Complete!!!");
                }
                else MessageBox.Show("This folder is existent!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chk_lock_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lock.Checked)
            {
                txt_link.ReadOnly = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txt_link.Text))
                {
                    if (Directory.Exists(txt_link.Text))
                    {
                        Properties.Settings.Default.Link = txt_link.Text;
                        Properties.Settings.Default.Save();
                        txt_link.ReadOnly = true;
                        Application.Restart();
                    }
                    else
                    {
                        chk_lock.CheckState = CheckState.Checked;
                        MessageBox.Show("This link is not available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    chk_lock.CheckState = CheckState.Checked;
                    MessageBox.Show("The link is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void lv_source_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
                _InvApplication.SilentOperation = true;
                foreach (var file in lv_source.SelectedItems)
                {
                    string filename = file.ToString().Substring(15, file.ToString().Length - 16);
                    var doc = _InvApplication.Documents.Open(Path.Combine(source, filename));
                }
                _InvApplication.SilentOperation = false;
            }
        }

        private void ReadOnly_Click(object sender, EventArgs e)
        {
            foreach (var item in lv_source.SelectedItems)
            {
                string filename = item.ToString().Substring(15, item.ToString().Length - 16);
                string filepath = Path.Combine(source, filename);
                File.SetAttributes(filepath, FileAttributes.Normal);
            }
        }
    }
}
