
namespace THD_Testing
{
    partial class THD_Testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THD_Testing));
            this.lb_link = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_link = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Annoucement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_link.Location = new System.Drawing.Point(3, 9);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(86, 13);
            this.lb_link.TabIndex = 0;
            this.lb_link.Text = "Source Folder";
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_link.Location = new System.Drawing.Point(95, 6);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(654, 20);
            this.txt_link.TabIndex = 1;
            this.txt_link.TextChanged += new System.EventHandler(this.txt_link_TextChanged);
            // 
            // btn_link
            // 
            this.btn_link.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_link.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_link.Location = new System.Drawing.Point(755, 6);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(33, 20);
            this.btn_link.TabIndex = 2;
            this.btn_link.Text = "•••";
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Maroon;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Start.Location = new System.Drawing.Point(704, 269);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 31);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simpson Strong-Tie | ESCAD ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::THD_Testing.Properties.Resources.Picture1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(170, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 241);
            this.panel1.TabIndex = 6;
            // 
            // txt_Annoucement
            // 
            this.txt_Annoucement.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Annoucement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Annoucement.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Annoucement.Location = new System.Drawing.Point(509, 32);
            this.txt_Annoucement.Name = "txt_Annoucement";
            this.txt_Annoucement.ReadOnly = true;
            this.txt_Annoucement.Size = new System.Drawing.Size(240, 22);
            this.txt_Annoucement.TabIndex = 7;
            this.txt_Annoucement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // THD_Testing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Annoucement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.lb_link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "THD_Testing";
            this.Text = "THD Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Annoucement;
    }
}

