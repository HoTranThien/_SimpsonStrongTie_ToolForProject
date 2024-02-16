
namespace Microsoft_Print_to_PDF
{
    partial class Form_ATFDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ATFDA));
            this.btn_source = new System.Windows.Forms.Button();
            this.lv_source = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Excel = new System.Windows.Forms.TextBox();
            this.btn_dialogExcel = new System.Windows.Forms.Button();
            this.txt_Announcement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_source
            // 
            this.btn_source.BackColor = System.Drawing.Color.Maroon;
            this.btn_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_source.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_source.Location = new System.Drawing.Point(754, 75);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(34, 21);
            this.btn_source.TabIndex = 0;
            this.btn_source.Text = "•••";
            this.btn_source.UseVisualStyleBackColor = false;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // lv_source
            // 
            this.lv_source.HideSelection = false;
            this.lv_source.Location = new System.Drawing.Point(12, 75);
            this.lv_source.Name = "lv_source";
            this.lv_source.Size = new System.Drawing.Size(736, 363);
            this.lv_source.SmallImageList = this.imageList1;
            this.lv_source.TabIndex = 1;
            this.lv_source.UseCompatibleStateImageBehavior = false;
            this.lv_source.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dwg.png");
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Maroon;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Start.Location = new System.Drawing.Point(664, 444);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 31);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Excel
            // 
            this.txt_Excel.Location = new System.Drawing.Point(12, 22);
            this.txt_Excel.Name = "txt_Excel";
            this.txt_Excel.Size = new System.Drawing.Size(736, 20);
            this.txt_Excel.TabIndex = 3;
            // 
            // btn_dialogExcel
            // 
            this.btn_dialogExcel.BackColor = System.Drawing.Color.Maroon;
            this.btn_dialogExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dialogExcel.Location = new System.Drawing.Point(754, 22);
            this.btn_dialogExcel.Name = "btn_dialogExcel";
            this.btn_dialogExcel.Size = new System.Drawing.Size(34, 20);
            this.btn_dialogExcel.TabIndex = 4;
            this.btn_dialogExcel.Text = "•••";
            this.btn_dialogExcel.UseVisualStyleBackColor = false;
            this.btn_dialogExcel.Click += new System.EventHandler(this.btn_dialogExcel_Click);
            // 
            // txt_Announcement
            // 
            this.txt_Announcement.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Announcement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Announcement.Location = new System.Drawing.Point(458, 47);
            this.txt_Announcement.Name = "txt_Announcement";
            this.txt_Announcement.ReadOnly = true;
            this.txt_Announcement.Size = new System.Drawing.Size(290, 22);
            this.txt_Announcement.TabIndex = 6;
            this.txt_Announcement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_ATFDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(796, 479);
            this.Controls.Add(this.txt_Announcement);
            this.Controls.Add(this.btn_dialogExcel);
            this.Controls.Add(this.txt_Excel);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lv_source);
            this.Controls.Add(this.btn_source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ATFDA";
            this.Text = "Add Title For Detail AutoCAD";
            this.Load += new System.EventHandler(this.Form_ATFDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.ListView lv_source;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_Excel;
        private System.Windows.Forms.Button btn_dialogExcel;
        private System.Windows.Forms.TextBox txt_Announcement;
        private System.Windows.Forms.ImageList imageList1;
    }
}