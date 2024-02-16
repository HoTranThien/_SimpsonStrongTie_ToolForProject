using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace Import_CAD
{
    [TransactionAttribute(TransactionMode.Manual)]
    
    public class Import_CAD_Class : IExternalCommand
    {
        
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            
            UIDocument UIDoc = commandData.Application.ActiveUIDocument;
            Document Doc = UIDoc.Document;
            System.Windows.Forms.Application.Run(new ImportView_Form(Doc, UIDoc));
            return Result.Succeeded;
        }
    }
}
