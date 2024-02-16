using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Add_Block_View
{
    public class DrawingViews
    {
        public string Front { get; set; }
        public string Top { get; set; }
        public string Bottom { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
        public string ISO { get; set; }
        public string Drawing { get; set; }
        public string Note { get; set; }
        public DrawingViews(string f, string t, string b, string l, string r, string i, string d)
        {
            Front = f;
            Top = t;
            Bottom = b;
            Left = l;
            Right = r;
            ISO = i;
            Drawing = d;
            Note = "";
        }
    }
}
