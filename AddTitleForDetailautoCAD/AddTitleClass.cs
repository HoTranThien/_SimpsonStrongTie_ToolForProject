using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Teigha.Runtime;
using IntelliCAD;
using IntelliCAD.EditorInput;
using IntelliCAD.ApplicationServices;
using Teigha.Geometry;
using Teigha.DatabaseServices;
using System.Windows;

namespace Microsoft_Print_to_PDF
{
    public class AddTitleClass
    {
        [CommandMethod("ADD_TITLE_FOR_DETAIL", CommandFlags.Modal)]
        public static void AddTitle()
        {
            System.Windows.Forms.Application.Run(new Microsoft_Print_to_PDF.Form_ATFDA());
        }
    }
}
