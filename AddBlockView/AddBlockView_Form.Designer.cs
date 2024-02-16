
namespace Add_Block_View
{
    partial class AddBlockView_Form
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
            this.btn_dialog = new System.Windows.Forms.Button();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_3V = new System.Windows.Forms.Button();
            this.btn_6V = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dialogexcel = new System.Windows.Forms.Button();
            this.txt_excel = new System.Windows.Forms.TextBox();
            this.btn_error = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dialog
            // 
            this.btn_dialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dialog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dialog.Location = new System.Drawing.Point(754, 12);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(34, 20);
            this.btn_dialog.TabIndex = 6;
            this.btn_dialog.Text = "•••";
            this.btn_dialog.UseVisualStyleBackColor = false;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // txt_Source
            // 
            this.txt_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Source.Location = new System.Drawing.Point(94, 12);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(654, 20);
            this.txt_Source.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Source File";
            // 
            // btn_3V
            // 
            this.btn_3V.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_3V.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_3V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3V.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_3V.Location = new System.Drawing.Point(473, 89);
            this.btn_3V.Name = "btn_3V";
            this.btn_3V.Size = new System.Drawing.Size(101, 30);
            this.btn_3V.TabIndex = 8;
            this.btn_3V.Text = "3 VIEWS";
            this.btn_3V.UseVisualStyleBackColor = false;
            this.btn_3V.Click += new System.EventHandler(this.btn_3V_Click_1);
            // 
            // btn_6V
            // 
            this.btn_6V.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_6V.BackColor = System.Drawing.Color.Maroon;
            this.btn_6V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6V.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_6V.Location = new System.Drawing.Point(647, 89);
            this.btn_6V.Name = "btn_6V";
            this.btn_6V.Size = new System.Drawing.Size(101, 30);
            this.btn_6V.TabIndex = 9;
            this.btn_6V.Text = "6 VIEWS";
            this.btn_6V.UseVisualStyleBackColor = false;
            this.btn_6V.Click += new System.EventHandler(this.btn_6V_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Simpson Strong-Tie | ESCAD ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Link Excel";
            // 
            // btn_dialogexcel
            // 
            this.btn_dialogexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dialogexcel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialogexcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dialogexcel.Location = new System.Drawing.Point(754, 47);
            this.btn_dialogexcel.Name = "btn_dialogexcel";
            this.btn_dialogexcel.Size = new System.Drawing.Size(34, 20);
            this.btn_dialogexcel.TabIndex = 13;
            this.btn_dialogexcel.Text = "•••";
            this.btn_dialogexcel.UseVisualStyleBackColor = false;
            this.btn_dialogexcel.Click += new System.EventHandler(this.btn_dialogexcel_Click);
            // 
            // txt_excel
            // 
            this.txt_excel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_excel.Location = new System.Drawing.Point(94, 47);
            this.txt_excel.Name = "txt_excel";
            this.txt_excel.Size = new System.Drawing.Size(654, 20);
            this.txt_excel.TabIndex = 12;
            // 
            // btn_error
            // 
            this.btn_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_error.BackColor = System.Drawing.SystemColors.Window;
            this.btn_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_error.Image = global::Add_Block_View.Properties.Resources.error2;
            this.btn_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_error.Location = new System.Drawing.Point(337, 92);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(55, 26);
            this.btn_error.TabIndex = 36;
            this.btn_error.Text = "0";
            this.btn_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_error.UseVisualStyleBackColor = false;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // AddBlockView_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 126);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.btn_dialogexcel);
            this.Controls.Add(this.txt_excel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_6V);
            this.Controls.Add(this.btn_3V);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dialog);
            this.Controls.Add(this.txt_Source);
            this.MaximumSize = new System.Drawing.Size(1600, 165);
            this.MinimumSize = new System.Drawing.Size(816, 165);
            this.Name = "AddBlockView_Form";
            this.Text = "AddBlockView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dialog;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_3V;
        private System.Windows.Forms.Button btn_6V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dialogexcel;
        private System.Windows.Forms.TextBox txt_excel;
        private System.Windows.Forms.Button btn_error;
    }
}