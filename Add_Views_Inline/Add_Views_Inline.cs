using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace Add_Views_Inline
{
    public class Add_Views_Inline
    {
        [CommandMethod("ADD_VIEWS_INLINE", CommandFlags.Modal)]
        public static void ADD_VIEWS_INLINE()
        {
            AddViewsInline_Form RunForm = new AddViewsInline_Form();
            System.Windows.Forms.Application.Run(RunForm);
        }

    }
}
