using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace CaptureScreenWindow
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        string folder_name;
        string folder_path;
        string time_now;
        int speed = 1000 * 60;

        private void StartForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.Location))
            {
                CreateFolderContainFiles();
                timer1.Interval = Properties.Settings.Default.Time * speed;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please set a new Location!");
                OpenFormSetting();
            }
        }

        public void CreateFolderContainFiles()
        {
            //Create folder contain files
            folder_name = DateTime.Now.ToString("yyyy-MM-dd");
            folder_path = Path.Combine(Properties.Settings.Default.Location, folder_name);
            if (!Directory.Exists(folder_path))
            {
                Directory.CreateDirectory(folder_path);
            }
        }
        public void OpenFormSetting()
        {
            var frmSetting1 = new FormSetting();
            if (frmSetting1.ShowDialog() == DialogResult.OK)
            {
                //Properties.Settings.Default.Time = frmSettings1.UserInputTime;
                //Properties.Settings.Default.Location = frmSettings1.UserInputLocation;

                if (!string.IsNullOrWhiteSpace(frmSetting1.UserInputLocation))
                {
                    if (!string.IsNullOrWhiteSpace(frmSetting1.UserInputTime))
                    {
                        if (int.TryParse(frmSetting1.UserInputTime, out int num))
                        {
                            timer1.Stop();
                            //Save setting
                            Properties.Settings.Default.Location = frmSetting1.UserInputLocation;
                            Properties.Settings.Default.Time = num;
                            Properties.Settings.Default.Save();
                            timer1.Interval = Properties.Settings.Default.Time * speed;

                            CreateFolderContainFiles();

                            timer1.Start();
                            frmSetting1.Hide();
                        }
                        else MessageBox.Show("Please input an interger value!");

                    }
                    else MessageBox.Show("Please input Time!");

                }
                else MessageBox.Show("Please input Location!");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_now = string.Format(DateTime.Now.ToString("HH") + "h " + DateTime.Now.ToString("mm") + "m");
            int count = 0;
            int qtyCreen = Screen.AllScreens.Count();
            Bitmap[] bm = new Bitmap[qtyCreen];
            for (var i = 0; i < qtyCreen; i++)
            {
                Screen screen = Screen.AllScreens[i];
                try
                {
                    count = count + 1;
                    bm[i] = new Bitmap(screen.Bounds.Width, screen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Graphics g = Graphics.FromImage(bm[i]);
                    g.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size);
                }
                catch
                {

                }
            }
            string fullfile_name;
            Bitmap bms;
            Graphics gg;
            switch (qtyCreen)
            {
                case 1:
                    folder_name = DateTime.Now.ToString("yyyy-MM-dd");
                    folder_path = Path.Combine(Properties.Settings.Default.Location, folder_name);
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + "_" + ".jpg"));
                    bm[0].Save(fullfile_name);
                    break;
                case 2:
                    bms = new Bitmap(bm[0].Width, bm[0].Height + bm[1].Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    gg = Graphics.FromImage(bms);
                    gg.DrawImage(bm[0], 0, 0);
                    gg.DrawImage(bm[1], 0, bm[0].Height);
                    folder_name = DateTime.Now.ToString("yyyy-MM-dd");
                    folder_path = Path.Combine(Properties.Settings.Default.Location, folder_name);
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + "_" + ".jpg"));
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + ".jpg"));
                    bms.Save(fullfile_name);
                    break;
                case 3:
                    bms = new Bitmap(bm[0].Width+bm[1].Width, bm[0].Height + bm[2].Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    gg = Graphics.FromImage(bms);
                    gg.DrawImage(bm[0], 0, 0);
                    gg.DrawImage(bm[1], bm[0].Width,0);
                    gg.DrawImage(bm[2], 0, bm[1].Height);
                    folder_name = DateTime.Now.ToString("yyyy-MM-dd");
                    folder_path = Path.Combine(Properties.Settings.Default.Location, folder_name);
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + "_" + ".jpg"));
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + ".jpg"));
                    break;
                case 4:
                    bms = new Bitmap(bm[0].Width + bm[1].Width, bm[0].Height + bm[2].Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    gg = Graphics.FromImage(bms);
                    gg.DrawImage(bm[0], 0, 0);
                    gg.DrawImage(bm[1], bm[0].Width, 0);
                    gg.DrawImage(bm[2], 0, bm[1].Height);
                    gg.DrawImage(bm[3], bm[0].Width, bm[1].Height);
                    folder_name = DateTime.Now.ToString("yyyy-MM-dd");
                    folder_path = Path.Combine(Properties.Settings.Default.Location, folder_name);
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + "_" + ".jpg"));
                    fullfile_name = Path.Combine(folder_path, string.Format(time_now + ".jpg"));
                    break;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormSetting();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
