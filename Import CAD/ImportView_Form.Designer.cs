
namespace Import_CAD
{
    partial class ImportView_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportView_Form));
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Unit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Front = new System.Windows.Forms.Button();
            this.btn_Top = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_link
            // 
            this.txt_link.CausesValidation = false;
            this.txt_link.Location = new System.Drawing.Point(119, 6);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(480, 20);
            this.txt_link.TabIndex = 0;
            this.txt_link.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder Acad";
            // 
            // cb_Unit
            // 
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.Items.AddRange(new object[] {
            "millimeter",
            "inch"});
            this.cb_Unit.Location = new System.Drawing.Point(511, 134);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.Size = new System.Drawing.Size(88, 21);
            this.cb_Unit.TabIndex = 2;
            this.cb_Unit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Import Units";
            // 
            // btn_Front
            // 
            this.btn_Front.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Front.Location = new System.Drawing.Point(15, 51);
            this.btn_Front.Name = "btn_Front";
            this.btn_Front.Size = new System.Drawing.Size(88, 35);
            this.btn_Front.TabIndex = 4;
            this.btn_Front.TabStop = false;
            this.btn_Front.Text = "Front (1)";
            this.btn_Front.UseVisualStyleBackColor = true;
            this.btn_Front.Click += new System.EventHandler(this.btn_Front_Click);
            // 
            // btn_Top
            // 
            this.btn_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Top.Location = new System.Drawing.Point(182, 51);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(88, 35);
            this.btn_Top.TabIndex = 5;
            this.btn_Top.TabStop = false;
            this.btn_Top.Text = "Top (2)";
            this.btn_Top.UseVisualStyleBackColor = true;
            this.btn_Top.Click += new System.EventHandler(this.btn_Top_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Left.Location = new System.Drawing.Point(351, 51);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(88, 35);
            this.btn_Left.TabIndex = 6;
            this.btn_Left.TabStop = false;
            this.btn_Left.Text = "Left (3)";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Right.Location = new System.Drawing.Point(511, 51);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(88, 35);
            this.btn_Right.TabIndex = 7;
            this.btn_Right.TabStop = false;
            this.btn_Right.Text = "Right (4)";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Simpson Strongtie | ESCAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Import_CAD.Properties.Resources.Logo_SST_RGB_new;
            this.pictureBox1.Location = new System.Drawing.Point(15, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ImportView_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Top);
            this.Controls.Add(this.btn_Front);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Unit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportView_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import View";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportView_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Front;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}