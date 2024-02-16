
namespace Add_Views_Inline
{
    partial class AddViewsInline_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddViewsInline_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dialog = new System.Windows.Forms.Button();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source File";
            // 
            // btn_dialog
            // 
            this.btn_dialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dialog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dialog.Location = new System.Drawing.Point(751, 12);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(34, 20);
            this.btn_dialog.TabIndex = 9;
            this.btn_dialog.Text = "•••";
            this.btn_dialog.UseVisualStyleBackColor = false;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // txt_Source
            // 
            this.txt_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Source.Location = new System.Drawing.Point(91, 12);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(654, 20);
            this.txt_Source.TabIndex = 8;
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.Maroon;
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_run.Location = new System.Drawing.Point(644, 38);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(101, 30);
            this.btn_run.TabIndex = 11;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Simpson Strong-Tie | ESCAD ";
            // 
            // AddViewsInline_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 78);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dialog);
            this.Controls.Add(this.txt_Source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddViewsInline_Form";
            this.Text = "AddViewsInline_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dialog;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label2;
    }
}