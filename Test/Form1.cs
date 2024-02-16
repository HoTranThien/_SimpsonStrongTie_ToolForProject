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

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class SortFiles
        {
            public string link { get; set; }
            public int num { get; set; }
            public SortFiles(string li, int nu)
            {
                link = li;
                num = nu;
            }
        }
        public string[] GetFiles(string path)
        {
            if (Directory.GetFiles(path).Length >0)
            {
                return Directory.GetFiles(path);
            }
            else if(Directory.GetDirectories(path) != null)
            {
                path = Directory.GetDirectories(path)[0];
                return GetFiles(path);
            }
            else
            {
                return null;
            }
        }
        private void btn_run_Click(object sender, EventArgs e)
        {
            string result = string.Format(txt_Source.Text + @"\" + "_RESULT");
            if(!Directory.Exists(result)) Directory.CreateDirectory(result);

            foreach (var folder in Directory.GetDirectories(txt_Source.Text))
            {
                if (folder == result) continue;
                string filename = new DirectoryInfo(folder).Name;
                string fullFileName = string.Format(result + @"\" + filename + ".dwg");
                List<SortFiles> ListFile = new List<SortFiles>();
                List<int> SortNum = new List<int>();
                List<string> Files = new List<string>();
                foreach (var fi in GetFiles(folder))
                {
                    string fina = Path.GetFileNameWithoutExtension(fi);
                    string num = fina.Substring(fina.IndexOf("_")+1, fina.LastIndexOf("_")- (fina.IndexOf("_")+1));
                    ListFile.Add(new SortFiles(fi, int.Parse(num)));
                    SortNum.Add(int.Parse(num));
                }
                //Sort the list filename
                SortNum.Sort();
                for(int i = 0;i<SortNum.Count;i++)
                {
                    foreach (var item in ListFile)
                    {
                        if (item.num == SortNum[i]) Files.Add(item.link);
                    }
                }


                
            }
        }
    }
}
