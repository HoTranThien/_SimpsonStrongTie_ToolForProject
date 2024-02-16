
namespace Microsoft_Print_to_PDF
{
    partial class Form_APFDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_APFDA));
            this.btn_source = new System.Windows.Forms.Button();
            this.lv_source = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.btn_SaveDWG = new System.Windows.Forms.Button();
            this.btn_unit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_source
            // 
            this.btn_source.BackColor = System.Drawing.Color.Maroon;
            this.btn_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_source.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_source.Location = new System.Drawing.Point(714, 12);
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
            this.lv_source.Location = new System.Drawing.Point(12, 39);
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
            this.btn_Start.Location = new System.Drawing.Point(664, 409);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 31);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Collect Your Files";
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_quantity.Location = new System.Drawing.Point(12, 405);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(142, 16);
            this.lb_quantity.TabIndex = 8;
            this.lb_quantity.Text = "0 Drawing Selected";
            // 
            // btn_SaveDWG
            // 
            this.btn_SaveDWG.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_SaveDWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveDWG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SaveDWG.Location = new System.Drawing.Point(452, 409);
            this.btn_SaveDWG.Name = "btn_SaveDWG";
            this.btn_SaveDWG.Size = new System.Drawing.Size(101, 31);
            this.btn_SaveDWG.TabIndex = 9;
            this.btn_SaveDWG.Text = "SAVE DWG";
            this.btn_SaveDWG.UseVisualStyleBackColor = false;
            this.btn_SaveDWG.Click += new System.EventHandler(this.btn_SaveDWG_Click);
            // 
            // btn_unit
            // 
            this.btn_unit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_unit.Location = new System.Drawing.Point(277, 413);
            this.btn_unit.Name = "btn_unit";
            this.btn_unit.Size = new System.Drawing.Size(70, 23);
            this.btn_unit.TabIndex = 10;
            this.btn_unit.Text = "MM";
            this.btn_unit.UseVisualStyleBackColor = false;
            this.btn_unit.Click += new System.EventHandler(this.btn_unit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(232, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unit:";
            // 
            // Form_APFDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_unit);
            this.Controls.Add(this.btn_SaveDWG);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lv_source);
            this.Controls.Add(this.btn_source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_APFDA";
            this.Text = "Add Point For AutoCAD Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.ListView lv_source;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.Button btn_SaveDWG;
        private System.Windows.Forms.Button btn_unit;
        private System.Windows.Forms.Label label2;
    }
}