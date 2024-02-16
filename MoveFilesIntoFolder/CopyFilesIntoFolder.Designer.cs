
namespace MoveFilesIntoFolder
{
    partial class CopyFilesIntoFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyFilesIntoFolder));
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_dialog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_zip = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_error = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(96, 15);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(488, 20);
            this.txt_link.TabIndex = 0;
            this.txt_link.TextChanged += new System.EventHandler(this.txt_link_TextChanged);
            // 
            // btn_dialog
            // 
            this.btn_dialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dialog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_dialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dialog.Location = new System.Drawing.Point(590, 15);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(34, 20);
            this.btn_dialog.TabIndex = 7;
            this.btn_dialog.Text = "•••";
            this.btn_dialog.UseVisualStyleBackColor = false;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Link Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Simpson Strong-Tie | ESCAD ";
            // 
            // btn_rename
            // 
            this.btn_rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rename.BackColor = System.Drawing.Color.Indigo;
            this.btn_rename.Enabled = false;
            this.btn_rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rename.Location = new System.Drawing.Point(452, 60);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(99, 30);
            this.btn_rename.TabIndex = 14;
            this.btn_rename.Text = "RENAME";
            this.btn_rename.UseVisualStyleBackColor = false;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_copy.Enabled = false;
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_copy.Location = new System.Drawing.Point(372, 60);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(74, 30);
            this.btn_copy.TabIndex = 13;
            this.btn_copy.Text = "COPY";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_zip
            // 
            this.btn_zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zip.BackColor = System.Drawing.Color.Maroon;
            this.btn_zip.Enabled = false;
            this.btn_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_zip.Location = new System.Drawing.Point(557, 60);
            this.btn_zip.Name = "btn_zip";
            this.btn_zip.Size = new System.Drawing.Size(67, 30);
            this.btn_zip.TabIndex = 16;
            this.btn_zip.Text = "ZIP";
            this.btn_zip.UseVisualStyleBackColor = false;
            this.btn_zip.Click += new System.EventHandler(this.btn_zip_Click);
            // 
            // btn_read
            // 
            this.btn_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_read.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_read.Location = new System.Drawing.Point(230, 60);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(136, 30);
            this.btn_read.TabIndex = 17;
            this.btn_read.Text = "READ EXCEL";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_error
            // 
            this.btn_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_error.BackColor = System.Drawing.Color.Red;
            this.btn_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_error.ForeColor = System.Drawing.Color.Transparent;
            this.btn_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_error.Location = new System.Drawing.Point(194, 60);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(30, 30);
            this.btn_error.TabIndex = 37;
            this.btn_error.Text = "X";
            this.btn_error.UseVisualStyleBackColor = false;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // CopyFilesIntoFolder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 115);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_zip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dialog);
            this.Controls.Add(this.txt_link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CopyFilesIntoFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Files Into Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_dialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_zip;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_error;
    }
}

