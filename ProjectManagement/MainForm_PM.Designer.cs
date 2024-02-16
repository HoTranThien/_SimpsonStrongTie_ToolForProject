
namespace ProjectManagement
{
    partial class MainForm_PM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_PM));
            this.lv_source = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lv_ESNumber = new System.Windows.Forms.ListView();
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_NewProject = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.ctm_ES = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PackAndGo = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteES = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_item = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveItemsTo = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.chk_lock = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.ctm_ES.SuspendLayout();
            this.ctm_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_source
            // 
            this.lv_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_source.HideSelection = false;
            this.lv_source.LargeImageList = this.imageList1;
            this.lv_source.Location = new System.Drawing.Point(317, 40);
            this.lv_source.Name = "lv_source";
            this.lv_source.Size = new System.Drawing.Size(1127, 619);
            this.lv_source.SmallImageList = this.imageList1;
            this.lv_source.TabIndex = 1;
            this.lv_source.UseCompatibleStateImageBehavior = false;
            this.lv_source.View = System.Windows.Forms.View.List;
            this.lv_source.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_source_KeyDown);
            this.lv_source.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_source_MouseClick);
            this.lv_source.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_source_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DWG.ico");
            this.imageList1.Images.SetKeyName(1, "ipt1.png");
            this.imageList1.Images.SetKeyName(2, "Inventor_23604.ico");
            this.imageList1.Images.SetKeyName(3, "iam1.png");
            this.imageList1.Images.SetKeyName(4, "p.png");
            // 
            // lv_ESNumber
            // 
            this.lv_ESNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lv_ESNumber.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectName});
            this.lv_ESNumber.HideSelection = false;
            this.lv_ESNumber.Location = new System.Drawing.Point(12, 78);
            this.lv_ESNumber.MultiSelect = false;
            this.lv_ESNumber.Name = "lv_ESNumber";
            this.lv_ESNumber.Size = new System.Drawing.Size(288, 581);
            this.lv_ESNumber.SmallImageList = this.imageList1;
            this.lv_ESNumber.TabIndex = 2;
            this.lv_ESNumber.UseCompatibleStateImageBehavior = false;
            this.lv_ESNumber.View = System.Windows.Forms.View.Details;
            this.lv_ESNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_ESNumber_MouseClick);
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "PROJECT NAME";
            this.ProjectName.Width = 399;
            // 
            // btn_NewProject
            // 
            this.btn_NewProject.BackColor = System.Drawing.Color.Maroon;
            this.btn_NewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NewProject.Location = new System.Drawing.Point(12, 9);
            this.btn_NewProject.Name = "btn_NewProject";
            this.btn_NewProject.Size = new System.Drawing.Size(121, 28);
            this.btn_NewProject.TabIndex = 3;
            this.btn_NewProject.Text = "New Project";
            this.btn_NewProject.UseVisualStyleBackColor = false;
            this.btn_NewProject.Click += new System.EventHandler(this.btn_NewProject_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Indigo;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(12, 44);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(121, 28);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // ctm_ES
            // 
            this.ctm_ES.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PackAndGo,
            this.DeleteES});
            this.ctm_ES.Name = "ctm_ES";
            this.ctm_ES.Size = new System.Drawing.Size(141, 48);
            // 
            // PackAndGo
            // 
            this.PackAndGo.Name = "PackAndGo";
            this.PackAndGo.Size = new System.Drawing.Size(140, 22);
            this.PackAndGo.Text = "Pack and Go";
            this.PackAndGo.Click += new System.EventHandler(this.PackAndGo_Click);
            // 
            // DeleteES
            // 
            this.DeleteES.Name = "DeleteES";
            this.DeleteES.Size = new System.Drawing.Size(140, 22);
            this.DeleteES.Text = "Delete";
            this.DeleteES.Click += new System.EventHandler(this.DeleteES_Click);
            // 
            // ctm_item
            // 
            this.ctm_item.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.RemoveItem,
            this.MoveItemsTo,
            this.DeleteItem,
            this.ReadOnly});
            this.ctm_item.Name = "ctm_item";
            this.ctm_item.Size = new System.Drawing.Size(129, 114);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(128, 22);
            this.OpenFile.Text = "Open";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(128, 22);
            this.RemoveItem.Text = "Remove";
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // MoveItemsTo
            // 
            this.MoveItemsTo.Name = "MoveItemsTo";
            this.MoveItemsTo.Size = new System.Drawing.Size(128, 22);
            this.MoveItemsTo.Text = "Move to";
            this.MoveItemsTo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MoveItemsTo_DropDownItemClicked);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_link.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_link.Location = new System.Drawing.Point(317, 12);
            this.txt_link.Name = "txt_link";
            this.txt_link.ReadOnly = true;
            this.txt_link.Size = new System.Drawing.Size(746, 22);
            this.txt_link.TabIndex = 5;
            // 
            // chk_lock
            // 
            this.chk_lock.AutoSize = true;
            this.chk_lock.Location = new System.Drawing.Point(1069, 15);
            this.chk_lock.Name = "chk_lock";
            this.chk_lock.Size = new System.Drawing.Size(60, 17);
            this.chk_lock.TabIndex = 8;
            this.chk_lock.Text = "Unlock";
            this.chk_lock.UseVisualStyleBackColor = true;
            this.chk_lock.CheckedChanged += new System.EventHandler(this.chk_lock_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjectManagement.Properties.Resources.gear;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(138, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 68);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectManagement.Properties.Resources.Logo_SST_RGB_new1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(206, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 63);
            this.panel1.TabIndex = 9;
            // 
            // ReadOnly
            // 
            this.ReadOnly.Checked = true;
            this.ReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.Size = new System.Drawing.Size(128, 22);
            this.ReadOnly.Text = "Read Only";
            this.ReadOnly.Click += new System.EventHandler(this.ReadOnly_Click);
            // 
            // txt_sum
            // 
            this.txt_sum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sum.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_sum.Location = new System.Drawing.Point(1161, 15);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.ReadOnly = true;
            this.txt_sum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sum.Size = new System.Drawing.Size(283, 15);
            this.txt_sum.TabIndex = 11;
            this.txt_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm_PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1456, 671);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chk_lock);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_NewProject);
            this.Controls.Add(this.lv_ESNumber);
            this.Controls.Add(this.lv_source);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm_PM";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctm_ES.ResumeLayout(false);
            this.ctm_item.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv_source;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lv_ESNumber;
        private System.Windows.Forms.Button btn_NewProject;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ContextMenuStrip ctm_ES;
        private System.Windows.Forms.ToolStripMenuItem DeleteES;
        private System.Windows.Forms.ContextMenuStrip ctm_item;
        private System.Windows.Forms.ToolStripMenuItem RemoveItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem MoveItemsTo;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem PackAndGo;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.CheckBox chk_lock;
        private System.Windows.Forms.ColumnHeader ProjectName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem ReadOnly;
        private System.Windows.Forms.TextBox txt_sum;
    }
}

