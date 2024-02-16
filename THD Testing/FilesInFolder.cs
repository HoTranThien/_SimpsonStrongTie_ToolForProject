using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THD_Testing
{
    public class FilesInFolder
    {
        public string Excel { get; set; }
        public string THD_Temp { get; set; }
        public string Conc_Cl_Cr_01 { get; set; }
        public string Conc_Cl_Cr_02 { get; set; }
        public string Conc_Op_Cr_01 { get; set; }
        public string Conc_Op_Cr_02 { get; set; }
        public string Assem_Cl_Cr { get; set; }
        public string Assem_Op_Cr { get; set; }
        

        public FilesInFolder()
        {
            Excel = "";
            THD_Temp = "";
            Conc_Cl_Cr_01 = "";
            Conc_Cl_Cr_02 = "";
            Conc_Op_Cr_01 = "";
            Conc_Op_Cr_02 = "";
            Assem_Cl_Cr = "";
            Assem_Op_Cr = "";
        }
        public FilesInFolder(string thd, string clcr1, string clcr2, string opcr1, string opcr2,string ascl, string asop)
        {
            Excel = "";
            THD_Temp = thd;
            Conc_Cl_Cr_01 = clcr1;
            Conc_Cl_Cr_02 = clcr2;
            Conc_Op_Cr_01 = opcr1;
            Conc_Op_Cr_02 = opcr2;
            Assem_Cl_Cr = ascl;
            Assem_Op_Cr = asop;
        }
    }
}
