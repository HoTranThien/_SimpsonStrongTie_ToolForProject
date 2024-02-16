
namespace Change_The_File_Name
{
    partial class ChangeName
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_source = new System.Windows.Forms.Button();
            this.lb_source = new System.Windows.Forms.Label();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.cl_current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_new = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(662, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(759, 4);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(40, 23);
            this.btn_source.TabIndex = 1;
            this.btn_source.Text = "•••";
            this.btn_source.UseVisualStyleBackColor = true;
            // 
            // lb_source
            // 
            this.lb_source.AutoSize = true;
            this.lb_source.Location = new System.Drawing.Point(12, 9);
            this.lb_source.Name = "lb_source";
            this.lb_source.Size = new System.Drawing.Size(73, 13);
            this.lb_source.TabIndex = 2;
            this.lb_source.Text = "Source Folder";
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_current,
            this.cl_new});
            this.dgv_table.Location = new System.Drawing.Point(15, 32);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(738, 406);
            this.dgv_table.TabIndex = 3;
            // 
            // cl_current
            // 
            this.cl_current.HeaderText = "Current File";
            this.cl_current.Name = "cl_current";
            // 
            // cl_new
            // 
            this.cl_new.HeaderText = "New Name";
            this.cl_new.Name = "cl_new";
            // 
            // ChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.lb_source);
            this.Controls.Add(this.btn_source);
            this.Controls.Add(this.textBox1);
            this.Name = "ChangeName";
            this.Text = "Change The File Name";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Label lb_source;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_current;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_new;
    }
}

