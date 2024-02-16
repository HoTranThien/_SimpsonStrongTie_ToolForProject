using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THD_Testing
{
    public class THD_Member
    {
        public string Name_Note { get; set; }
        public string Head_Stamp { get; set; }
        public string Base_Model { get; set; }
        public string Length_B { get; set; }
        public string Length_C { get; set; }
        public string Embedment_Depth { get; set; }
        public string Major_Dia_D { get; set; }
        public string Minor_Dia_E { get; set; }
        public string Pitch_F { get; set; }
        public string Top_Angle { get; set; }
        public string Bottom_Angle { get; set; }
        public string Tip_Taper_G { get; set; }
        public string Hole_Dia { get; set; }
        public string Model_Exist { get; set; }
        public string Model_Name { get; set; }
        public double Interference { get; set; }
        public int RowIndex { get; set; }
        public string Status { get; set; }

        public THD_01 THD_01 { get; set; }

        public THD_Member()
        {
            Name_Note = "";
            Head_Stamp = "";
            Base_Model = "";
            Model_Name = "";
            Length_B = "";
            Length_C = "";
            Embedment_Depth = "";
            Major_Dia_D = "";
            Minor_Dia_E = "";
            Pitch_F = "";
            Top_Angle = "";
            Bottom_Angle = "";
            Tip_Taper_G = "";
            Hole_Dia = "";
            Interference = 0;
            RowIndex = 0;
            Status = "";
        }
        public THD_Member(string nn, string hs, string bm, string b, string c, string ed, string d, string e, string f, string ta, string ba, string g, string hd,string me, string mn,double inter, int i,string st, THD_01 thd01)
        {
            Name_Note = nn;
            Head_Stamp = hs;
            Base_Model = bm;
            Length_B = b;
            Length_C = c;
            Embedment_Depth = ed;
            Major_Dia_D = d;
            Minor_Dia_E = e;
            Pitch_F = f;
            Top_Angle = ta;
            Bottom_Angle = ba;
            Tip_Taper_G = g;
            Hole_Dia = hd;
            Model_Exist = me;
            Model_Name = mn;
            Interference = inter;
            RowIndex = i;
            Status = st;
            THD_01 = thd01;
        }
    }
}
