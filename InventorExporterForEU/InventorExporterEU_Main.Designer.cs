
namespace Microsoft_Print_to_PDF
{
    partial class InventorExporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventorExporter));
            this.btn_dialogSource = new System.Windows.Forms.Button();
            this.source = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Label();
            this.btn_dialogSave = new System.Windows.Forms.Button();
            this.txt_save = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageDWG = new System.Windows.Forms.ImageList(this.components);
            this.lb_sum = new System.Windows.Forms.Label();
            this.txt_announce = new System.Windows.Forms.TextBox();
            this.ctm_remove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xt = new System.Windows.Forms.Button();
            this.btn_error = new System.Windows.Forms.Button();
            this.btn_2DDWG = new System.Windows.Forms.Button();
            this.btn_3DDWG = new System.Windows.Forms.Button();
            this.btn_SAT = new System.Windows.Forms.Button();
            this.btn_STP = new System.Windows.Forms.Button();
            this.btn_STL = new System.Windows.Forms.Button();
            this.btn_3DPDF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VIEW = new System.Windows.Forms.Button();
            this.gb_SV = new System.Windows.Forms.GroupBox();
            this.chk_Front = new System.Windows.Forms.CheckBox();
            this.chk_ISO = new System.Windows.Forms.CheckBox();
            this.chk_Top = new System.Windows.Forms.CheckBox();
            this.chk_Bottom = new System.Windows.Forms.CheckBox();
            this.chk_Left = new System.Windows.Forms.CheckBox();
            this.chk_Right = new System.Windows.Forms.CheckBox();
            this.ctm_remove.SuspendLayout();
            this.gb_SV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dialogSource
            // 
            this.btn_dialogSource.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialogSource.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_dialogSource.Location = new System.Drawing.Point(1099, 73);
            this.btn_dialogSource.Name = "btn_dialogSource";
            this.btn_dialogSource.Size = new System.Drawing.Size(33, 20);
            this.btn_dialogSource.TabIndex = 1;
            this.btn_dialogSource.Text = "•••";
            this.btn_dialogSource.UseVisualStyleBackColor = false;
            this.btn_dialogSource.Click += new System.EventHandler(this.btn_dialogSource_Click);
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source.Location = new System.Drawing.Point(13, 71);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(57, 16);
            this.source.TabIndex = 2;
            this.source.Text = "Source";
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(4, 437);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(66, 16);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save As";
            // 
            // btn_dialogSave
            // 
            this.btn_dialogSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialogSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_dialogSave.Location = new System.Drawing.Point(1098, 437);
            this.btn_dialogSave.Name = "btn_dialogSave";
            this.btn_dialogSave.Size = new System.Drawing.Size(33, 20);
            this.btn_dialogSave.TabIndex = 4;
            this.btn_dialogSave.Text = "•••";
            this.btn_dialogSave.UseVisualStyleBackColor = false;
            this.btn_dialogSave.Click += new System.EventHandler(this.btn_dialogSave_Click);
            // 
            // txt_save
            // 
            this.txt_save.Location = new System.Drawing.Point(76, 438);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(1016, 20);
            this.txt_save.TabIndex = 3;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DarkRed;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_export.Location = new System.Drawing.Point(1012, 463);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(80, 30);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "EXPORT";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1016, 327);
            this.listView1.SmallImageList = this.imageDWG;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // imageDWG
            // 
            this.imageDWG.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageDWG.ImageStream")));
            this.imageDWG.TransparentColor = System.Drawing.Color.Transparent;
            this.imageDWG.Images.SetKeyName(0, "box.png");
            this.imageDWG.Images.SetKeyName(1, "model.png");
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(73, 413);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(67, 13);
            this.lb_sum.TabIndex = 15;
            this.lb_sum.Text = "Total: 0 Files";
            // 
            // txt_announce
            // 
            this.txt_announce.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_announce.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_announce.Location = new System.Drawing.Point(851, 405);
            this.txt_announce.Name = "txt_announce";
            this.txt_announce.ReadOnly = true;
            this.txt_announce.Size = new System.Drawing.Size(241, 26);
            this.txt_announce.TabIndex = 16;
            this.txt_announce.Text = "Please Choose Your Files! ";
            this.txt_announce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctm_remove
            // 
            this.ctm_remove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctm_remove.Name = "ctm_remove";
            this.ctm_remove.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(76, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 10);
            this.panel4.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Format";
            // 
            // btn_xt
            // 
            this.btn_xt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_xt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xt.Image = global::InventorExporterForEU.Properties.Resources.X_T;
            this.btn_xt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xt.Location = new System.Drawing.Point(76, 12);
            this.btn_xt.Name = "btn_xt";
            this.btn_xt.Size = new System.Drawing.Size(80, 44);
            this.btn_xt.TabIndex = 36;
            this.btn_xt.Text = "X_T";
            this.btn_xt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xt.UseVisualStyleBackColor = false;
            this.btn_xt.Click += new System.EventHandler(this.btn_xt_Click);
            // 
            // btn_error
            // 
            this.btn_error.BackColor = System.Drawing.SystemColors.Window;
            this.btn_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_error.Image = global::InventorExporterForEU.Properties.Resources.error2;
            this.btn_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_error.Location = new System.Drawing.Point(790, 406);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(55, 26);
            this.btn_error.TabIndex = 35;
            this.btn_error.Text = "0";
            this.btn_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_error.UseVisualStyleBackColor = false;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // btn_2DDWG
            // 
            this.btn_2DDWG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_2DDWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2DDWG.Image = global::InventorExporterForEU.Properties.Resources.dwg__1_;
            this.btn_2DDWG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_2DDWG.Location = new System.Drawing.Point(659, 12);
            this.btn_2DDWG.Name = "btn_2DDWG";
            this.btn_2DDWG.Size = new System.Drawing.Size(108, 44);
            this.btn_2DDWG.TabIndex = 32;
            this.btn_2DDWG.Text = "2D DWG";
            this.btn_2DDWG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_2DDWG.UseVisualStyleBackColor = false;
            this.btn_2DDWG.Click += new System.EventHandler(this.btn_2DDWG_Click);
            // 
            // btn_3DDWG
            // 
            this.btn_3DDWG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_3DDWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3DDWG.Image = global::InventorExporterForEU.Properties.Resources.dwg__1_;
            this.btn_3DDWG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_3DDWG.Location = new System.Drawing.Point(545, 12);
            this.btn_3DDWG.Name = "btn_3DDWG";
            this.btn_3DDWG.Size = new System.Drawing.Size(108, 44);
            this.btn_3DDWG.TabIndex = 31;
            this.btn_3DDWG.Text = "3D DWG";
            this.btn_3DDWG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_3DDWG.UseVisualStyleBackColor = false;
            this.btn_3DDWG.Click += new System.EventHandler(this.btn_3DDWG_Click);
            // 
            // btn_SAT
            // 
            this.btn_SAT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_SAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAT.Image = global::InventorExporterForEU.Properties.Resources.model__1_;
            this.btn_SAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAT.Location = new System.Drawing.Point(456, 12);
            this.btn_SAT.Name = "btn_SAT";
            this.btn_SAT.Size = new System.Drawing.Size(83, 44);
            this.btn_SAT.TabIndex = 30;
            this.btn_SAT.Text = "SAT";
            this.btn_SAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SAT.UseVisualStyleBackColor = false;
            this.btn_SAT.Click += new System.EventHandler(this.btn_SAT_Click);
            // 
            // btn_STP
            // 
            this.btn_STP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_STP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_STP.Image = global::InventorExporterForEU.Properties.Resources._3d__1_;
            this.btn_STP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_STP.Location = new System.Drawing.Point(354, 12);
            this.btn_STP.Name = "btn_STP";
            this.btn_STP.Size = new System.Drawing.Size(96, 44);
            this.btn_STP.TabIndex = 28;
            this.btn_STP.Text = "STEP";
            this.btn_STP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_STP.UseVisualStyleBackColor = false;
            this.btn_STP.Click += new System.EventHandler(this.btn_STP_Click);
            // 
            // btn_STL
            // 
            this.btn_STL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_STL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_STL.Image = global::InventorExporterForEU.Properties.Resources.stl1;
            this.btn_STL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_STL.Location = new System.Drawing.Point(270, 12);
            this.btn_STL.Name = "btn_STL";
            this.btn_STL.Size = new System.Drawing.Size(78, 44);
            this.btn_STL.TabIndex = 27;
            this.btn_STL.Text = "STL";
            this.btn_STL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_STL.UseVisualStyleBackColor = false;
            this.btn_STL.Click += new System.EventHandler(this.btn_STL_Click);
            // 
            // btn_3DPDF
            // 
            this.btn_3DPDF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_3DPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3DPDF.Image = global::InventorExporterForEU.Properties.Resources.pdf;
            this.btn_3DPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_3DPDF.Location = new System.Drawing.Point(162, 12);
            this.btn_3DPDF.Name = "btn_3DPDF";
            this.btn_3DPDF.Size = new System.Drawing.Size(102, 44);
            this.btn_3DPDF.TabIndex = 26;
            this.btn_3DPDF.Text = "3D PDF";
            this.btn_3DPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_3DPDF.UseVisualStyleBackColor = false;
            this.btn_3DPDF.Click += new System.EventHandler(this.btn_3DPDF_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::InventorExporterForEU.Properties.Resources.gear;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(7, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 54);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InventorExporterForEU.Properties.Resources.Logo_SST_RGB_new;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(7, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 41);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Simpson Strongtie | ESCAD";
            // 
            // btn_VIEW
            // 
            this.btn_VIEW.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_VIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VIEW.Image = global::InventorExporterForEU.Properties.Resources.view__1_;
            this.btn_VIEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VIEW.Location = new System.Drawing.Point(773, 12);
            this.btn_VIEW.Name = "btn_VIEW";
            this.btn_VIEW.Size = new System.Drawing.Size(181, 44);
            this.btn_VIEW.TabIndex = 33;
            this.btn_VIEW.Text = "SEPARATED VIEW";
            this.btn_VIEW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VIEW.UseVisualStyleBackColor = false;
            this.btn_VIEW.Click += new System.EventHandler(this.btn_VIEW_Click);
            // 
            // gb_SV
            // 
            this.gb_SV.Controls.Add(this.chk_Right);
            this.gb_SV.Controls.Add(this.chk_Left);
            this.gb_SV.Controls.Add(this.chk_Bottom);
            this.gb_SV.Controls.Add(this.chk_Top);
            this.gb_SV.Controls.Add(this.chk_ISO);
            this.gb_SV.Controls.Add(this.chk_Front);
            this.gb_SV.Enabled = false;
            this.gb_SV.Location = new System.Drawing.Point(960, 3);
            this.gb_SV.Name = "gb_SV";
            this.gb_SV.Size = new System.Drawing.Size(178, 62);
            this.gb_SV.TabIndex = 38;
            this.gb_SV.TabStop = false;
            this.gb_SV.Text = "SEPARATED VIEW OPTION";
            // 
            // chk_Front
            // 
            this.chk_Front.AutoSize = true;
            this.chk_Front.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chk_Front.Checked = true;
            this.chk_Front.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Front.Location = new System.Drawing.Point(6, 19);
            this.chk_Front.Name = "chk_Front";
            this.chk_Front.Size = new System.Drawing.Size(50, 17);
            this.chk_Front.TabIndex = 39;
            this.chk_Front.Text = "Front";
            this.chk_Front.UseVisualStyleBackColor = false;
            // 
            // chk_ISO
            // 
            this.chk_ISO.AutoSize = true;
            this.chk_ISO.Checked = true;
            this.chk_ISO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ISO.Location = new System.Drawing.Point(6, 36);
            this.chk_ISO.Name = "chk_ISO";
            this.chk_ISO.Size = new System.Drawing.Size(44, 17);
            this.chk_ISO.TabIndex = 40;
            this.chk_ISO.Text = "ISO";
            this.chk_ISO.UseVisualStyleBackColor = true;
            // 
            // chk_Top
            // 
            this.chk_Top.AutoSize = true;
            this.chk_Top.Checked = true;
            this.chk_Top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Top.Location = new System.Drawing.Point(57, 19);
            this.chk_Top.Name = "chk_Top";
            this.chk_Top.Size = new System.Drawing.Size(45, 17);
            this.chk_Top.TabIndex = 41;
            this.chk_Top.Text = "Top";
            this.chk_Top.UseVisualStyleBackColor = true;
            // 
            // chk_Bottom
            // 
            this.chk_Bottom.AutoSize = true;
            this.chk_Bottom.Checked = true;
            this.chk_Bottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Bottom.Location = new System.Drawing.Point(57, 36);
            this.chk_Bottom.Name = "chk_Bottom";
            this.chk_Bottom.Size = new System.Drawing.Size(59, 17);
            this.chk_Bottom.TabIndex = 40;
            this.chk_Bottom.Text = "Bottom";
            this.chk_Bottom.UseVisualStyleBackColor = true;
            // 
            // chk_Left
            // 
            this.chk_Left.AutoSize = true;
            this.chk_Left.Checked = true;
            this.chk_Left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Left.Location = new System.Drawing.Point(121, 19);
            this.chk_Left.Name = "chk_Left";
            this.chk_Left.Size = new System.Drawing.Size(44, 17);
            this.chk_Left.TabIndex = 40;
            this.chk_Left.Text = "Left";
            this.chk_Left.UseVisualStyleBackColor = true;
            // 
            // chk_Right
            // 
            this.chk_Right.AutoSize = true;
            this.chk_Right.Checked = true;
            this.chk_Right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Right.Location = new System.Drawing.Point(121, 36);
            this.chk_Right.Name = "chk_Right";
            this.chk_Right.Size = new System.Drawing.Size(51, 17);
            this.chk_Right.TabIndex = 40;
            this.chk_Right.Text = "Right";
            this.chk_Right.UseVisualStyleBackColor = true;
            // 
            // InventorExporter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1144, 511);
            this.Controls.Add(this.btn_VIEW);
            this.Controls.Add(this.gb_SV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xt);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_2DDWG);
            this.Controls.Add(this.btn_3DDWG);
            this.Controls.Add(this.btn_SAT);
            this.Controls.Add(this.btn_STP);
            this.Controls.Add(this.btn_STL);
            this.Controls.Add(this.btn_3DPDF);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_announce);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btn_dialogSave);
            this.Controls.Add(this.txt_save);
            this.Controls.Add(this.source);
            this.Controls.Add(this.btn_dialogSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventorExporter";
            this.Text = "Inventor Exporter For EU";
            this.ctm_remove.ResumeLayout(false);
            this.gb_SV.ResumeLayout(false);
            this.gb_SV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dialogSource;
        private System.Windows.Forms.Label source;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Button btn_dialogSave;
        private System.Windows.Forms.TextBox txt_save;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageDWG;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.TextBox txt_announce;
        private System.Windows.Forms.ContextMenuStrip ctm_remove;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_3DPDF;
        private System.Windows.Forms.Button btn_STL;
        private System.Windows.Forms.Button btn_STP;
        private System.Windows.Forms.Button btn_SAT;
        private System.Windows.Forms.Button btn_3DDWG;
        private System.Windows.Forms.Button btn_2DDWG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_error;
        private System.Windows.Forms.Button btn_xt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VIEW;
        private System.Windows.Forms.GroupBox gb_SV;
        private System.Windows.Forms.CheckBox chk_Right;
        private System.Windows.Forms.CheckBox chk_Left;
        private System.Windows.Forms.CheckBox chk_Bottom;
        private System.Windows.Forms.CheckBox chk_Top;
        private System.Windows.Forms.CheckBox chk_ISO;
        private System.Windows.Forms.CheckBox chk_Front;
    }
}

