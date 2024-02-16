using Teigha.Runtime;
using IntelliCAD;
using IntelliCAD.EditorInput;
using IntelliCAD.ApplicationServices;
using Teigha.Geometry;
using Teigha.DatabaseServices;

using System.Windows;
using System.Windows.Forms;

namespace Microsoft_Print_to_PDF
{
    public class AddPointClass
    {
        [CommandMethod("ADD_POINT_FOR_DRAWING",CommandFlags.Modal)]
        public static void AddPoint()
        {
            System.Windows.Forms.Application.Run(new Microsoft_Print_to_PDF.Form_APFDA());
        }
    }
}
