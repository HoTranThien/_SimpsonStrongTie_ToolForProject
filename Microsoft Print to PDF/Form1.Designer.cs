
namespace Microsoft_Print_to_PDF
{
    partial class ExportToPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportToPDF));
            this.btn_dialogSource = new System.Windows.Forms.Button();
            this.source = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Label();
            this.btn_dialogSave = new System.Windows.Forms.Button();
            this.txt_save = new System.Windows.Forms.TextBox();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageDWG = new System.Windows.Forms.ImageList(this.components);
            this.chk_save = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_insame = new System.Windows.Forms.CheckBox();
            this.lb_sum = new System.Windows.Forms.Label();
            this.txt_announce = new System.Windows.Forms.TextBox();
            this.ctm_remove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.chk_PDF = new System.Windows.Forms.CheckBox();
            this.chk_DXF = new System.Windows.Forms.CheckBox();
            this.chk_DWG = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.img_Nation = new System.Windows.Forms.ImageList(this.components);
            this.btn_nation = new System.Windows.Forms.Button();
            this.ctm_remove.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dialogSource
            // 
            this.btn_dialogSource.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialogSource.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_dialogSource.Location = new System.Drawing.Point(739, 37);
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
            this.source.Location = new System.Drawing.Point(13, 40);
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
            this.btn_dialogSave.Location = new System.Drawing.Point(739, 437);
            this.btn_dialogSave.Name = "btn_dialogSave";
            this.btn_dialogSave.Size = new System.Drawing.Size(33, 20);
            this.btn_dialogSave.TabIndex = 4;
            this.btn_dialogSave.Text = "•••";
            this.btn_dialogSave.UseVisualStyleBackColor = false;
            this.btn_dialogSave.Click += new System.EventHandler(this.btn_dialogSave_Click);
            // 
            // txt_save
            // 
            this.txt_save.Location = new System.Drawing.Point(102, 436);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(631, 20);
            this.txt_save.TabIndex = 3;
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.Checked = true;
            this.chk_status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_status.Location = new System.Drawing.Point(76, 13);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(106, 17);
            this.chk_status.TabIndex = 6;
            this.chk_status.Text = "Black And White";
            this.chk_status.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DarkRed;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_export.Location = new System.Drawing.Point(532, 471);
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
            this.listView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(657, 372);
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
            this.imageDWG.Images.SetKeyName(0, "1497558522-21_84935.ico");
            // 
            // chk_save
            // 
            this.chk_save.AutoSize = true;
            this.chk_save.Location = new System.Drawing.Point(76, 440);
            this.chk_save.Name = "chk_save";
            this.chk_save.Size = new System.Drawing.Size(15, 14);
            this.chk_save.TabIndex = 9;
            this.chk_save.UseVisualStyleBackColor = true;
            this.chk_save.CheckedChanged += new System.EventHandler(this.chk_save_CheckedChanged);
            this.chk_save.Click += new System.EventHandler(this.chk_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save PDF file in the same folder of its drawing";
            // 
            // chk_insame
            // 
            this.chk_insame.AutoSize = true;
            this.chk_insame.Checked = true;
            this.chk_insame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_insame.Location = new System.Drawing.Point(76, 462);
            this.chk_insame.Name = "chk_insame";
            this.chk_insame.Size = new System.Drawing.Size(15, 14);
            this.chk_insame.TabIndex = 11;
            this.chk_insame.UseVisualStyleBackColor = true;
            this.chk_insame.Click += new System.EventHandler(this.chk_insame_Click);
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(73, 415);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(67, 13);
            this.lb_sum.TabIndex = 15;
            this.lb_sum.Text = "Total: 0 Files";
            // 
            // txt_announce
            // 
            this.txt_announce.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_announce.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_announce.Location = new System.Drawing.Point(534, 9);
            this.txt_announce.Name = "txt_announce";
            this.txt_announce.ReadOnly = true;
            this.txt_announce.Size = new System.Drawing.Size(199, 22);
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
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.Olive;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_reload.Location = new System.Drawing.Point(360, 471);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(80, 30);
            this.btn_reload.TabIndex = 17;
            this.btn_reload.Text = "RELOAD";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Microsoft_Print_to_PDF.Properties.Resources.gear;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(7, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 54);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Microsoft_Print_to_PDF.Properties.Resources.Logo_SST_RGB_new;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(7, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 41);
            this.panel1.TabIndex = 18;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_update.Location = new System.Drawing.Point(446, 471);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 30);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // chk_PDF
            // 
            this.chk_PDF.AutoSize = true;
            this.chk_PDF.Checked = true;
            this.chk_PDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_PDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_PDF.Location = new System.Drawing.Point(3, 5);
            this.chk_PDF.Name = "chk_PDF";
            this.chk_PDF.Size = new System.Drawing.Size(54, 20);
            this.chk_PDF.TabIndex = 21;
            this.chk_PDF.Text = "PDF";
            this.chk_PDF.UseVisualStyleBackColor = true;
            // 
            // chk_DXF
            // 
            this.chk_DXF.AutoSize = true;
            this.chk_DXF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DXF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_DXF.Location = new System.Drawing.Point(63, 5);
            this.chk_DXF.Name = "chk_DXF";
            this.chk_DXF.Size = new System.Drawing.Size(53, 20);
            this.chk_DXF.TabIndex = 22;
            this.chk_DXF.Text = "DXF";
            this.chk_DXF.UseVisualStyleBackColor = true;
            // 
            // chk_DWG
            // 
            this.chk_DWG.AutoSize = true;
            this.chk_DWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DWG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_DWG.Location = new System.Drawing.Point(3, 27);
            this.chk_DWG.Name = "chk_DWG";
            this.chk_DWG.Size = new System.Drawing.Size(60, 20);
            this.chk_DWG.TabIndex = 23;
            this.chk_DWG.Text = "DWG";
            this.chk_DWG.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.chk_PDF);
            this.panel3.Controls.Add(this.chk_DWG);
            this.panel3.Controls.Add(this.chk_DXF);
            this.panel3.Location = new System.Drawing.Point(618, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 47);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(76, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 10);
            this.panel4.TabIndex = 25;
            // 
            // img_Nation
            // 
            this.img_Nation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Nation.ImageStream")));
            this.img_Nation.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Nation.Images.SetKeyName(0, "usa.png");
            this.img_Nation.Images.SetKeyName(1, "eu.png");
            // 
            // btn_nation
            // 
            this.btn_nation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nation.ImageList = this.img_Nation;
            this.btn_nation.Location = new System.Drawing.Point(188, 8);
            this.btn_nation.Name = "btn_nation";
            this.btn_nation.Size = new System.Drawing.Size(96, 25);
            this.btn_nation.TabIndex = 26;
            this.btn_nation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nation.UseVisualStyleBackColor = false;
            this.btn_nation.Click += new System.EventHandler(this.bt_nation_Click);
            // 
            // ExportToPDF
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(777, 513);
            this.Controls.Add(this.btn_nation);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.txt_announce);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.chk_insame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chk_status);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btn_dialogSave);
            this.Controls.Add(this.txt_save);
            this.Controls.Add(this.source);
            this.Controls.Add(this.btn_dialogSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExportToPDF";
            this.Text = "Microsoft Print to PDF";
            this.Load += new System.EventHandler(this.ExportToPDF_Load);
            this.ctm_remove.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dialogSource;
        private System.Windows.Forms.Label source;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Button btn_dialogSave;
        private System.Windows.Forms.TextBox txt_save;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageDWG;
        private System.Windows.Forms.CheckBox chk_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_insame;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.TextBox txt_announce;
        private System.Windows.Forms.ContextMenuStrip ctm_remove;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.CheckBox chk_PDF;
        private System.Windows.Forms.CheckBox chk_DXF;
        private System.Windows.Forms.CheckBox chk_DWG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList img_Nation;
        private System.Windows.Forms.Button btn_nation;
    }
}

