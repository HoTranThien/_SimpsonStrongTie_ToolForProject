
namespace PdfRotationForSAP
{
    partial class PDFRotation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFRotation_Form));
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtFolderOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolderInput = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_landscape = new System.Windows.Forms.CheckBox();
            this.chk_Portrait = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Run.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Run.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Run.Location = new System.Drawing.Point(651, 397);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(83, 30);
            this.btn_Run.TabIndex = 2;
            this.btn_Run.Text = "RUN";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.Lavender;
            this.btn_Save.Location = new System.Drawing.Point(740, 369);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(25, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "∙∙∙";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txtFolderOutput
            // 
            this.txtFolderOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderOutput.Location = new System.Drawing.Point(83, 371);
            this.txtFolderOutput.Name = "txtFolderOutput";
            this.txtFolderOutput.ReadOnly = true;
            this.txtFolderOutput.Size = new System.Drawing.Size(651, 20);
            this.txtFolderOutput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = " Select Folder";
            // 
            // txtFolderInput
            // 
            this.txtFolderInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderInput.Location = new System.Drawing.Point(83, 12);
            this.txtFolderInput.Name = "txtFolderInput";
            this.txtFolderInput.ReadOnly = true;
            this.txtFolderInput.Size = new System.Drawing.Size(651, 20);
            this.txtFolderInput.TabIndex = 9;
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.BackColor = System.Drawing.Color.Lavender;
            this.btn_Select.Location = new System.Drawing.Point(740, 10);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(25, 23);
            this.btn_Select.TabIndex = 8;
            this.btn_Select.Text = "∙∙∙";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = " Save Folder";
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(83, 39);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(651, 316);
            this.lb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "PDF Files";
            // 
            // chk_landscape
            // 
            this.chk_landscape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_landscape.AutoSize = true;
            this.chk_landscape.Checked = true;
            this.chk_landscape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_landscape.Location = new System.Drawing.Point(83, 405);
            this.chk_landscape.Name = "chk_landscape";
            this.chk_landscape.Size = new System.Drawing.Size(79, 17);
            this.chk_landscape.TabIndex = 14;
            this.chk_landscape.Text = "Landscape";
            this.chk_landscape.UseVisualStyleBackColor = true;
            // 
            // chk_Portrait
            // 
            this.chk_Portrait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Portrait.AutoSize = true;
            this.chk_Portrait.Location = new System.Drawing.Point(181, 405);
            this.chk_Portrait.Name = "chk_Portrait";
            this.chk_Portrait.Size = new System.Drawing.Size(59, 17);
            this.chk_Portrait.TabIndex = 15;
            this.chk_Portrait.Text = "Portrait";
            this.chk_Portrait.UseVisualStyleBackColor = true;
            // 
            // PDFRotation_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(780, 433);
            this.Controls.Add(this.chk_Portrait);
            this.Controls.Add(this.chk_landscape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolderInput);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderOutput);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "PDFRotation_Form";
            this.Text = "Rotate PDF For SAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtFolderOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolderInput;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_landscape;
        private System.Windows.Forms.CheckBox chk_Portrait;
    }
}

