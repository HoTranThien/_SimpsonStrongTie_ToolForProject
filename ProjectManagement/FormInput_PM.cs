using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class FormInput_PM : Form
    {
        public FormInput_PM()
        {
            InitializeComponent();
        }

        public string ProjectName;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ProjectName = txt_ES.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
