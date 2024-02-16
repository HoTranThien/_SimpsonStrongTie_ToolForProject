using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaptureScreenWindow
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        public string UserInputTime => txtTime.Text;

        public string UserInputLocation => txtLocation.Text;
        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            txtLocation.Text = Properties.Settings.Default.Location;
            txtTime.Text = Properties.Settings.Default.Time.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
