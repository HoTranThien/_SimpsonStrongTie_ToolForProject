using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace Add_Block_View
{
    public class ABV_Program
    {
        
        [CommandMethod("ADD_BLOCK_VIEW", CommandFlags.Modal)]
        public static void ADD_BLOCK_VIEW()
        {
            AddBlockView_Form RunForm = new Add_Block_View.AddBlockView_Form();
            System.Windows.Forms.Application.Run(RunForm);
        }
    }
}
