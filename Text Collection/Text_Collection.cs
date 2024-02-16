using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Teigha.Runtime;
//using IntelliCAD;
//using IntelliCAD.EditorInput;
//using IntelliCAD.ApplicationServices;
//using Teigha.Geometry;
//using Teigha.DatabaseServices;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace Text_Collection
{
    public class Text_Collection
    {
        [CommandMethod("TEXT_COLLECTION", CommandFlags.Modal)]
        public static void Collect_Text()
        {

            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            // Ask user to select any text object
            PromptEntityOptions peo = new PromptEntityOptions("\nSelect any text object: ");
            peo.SetRejectMessage("\nInvalid selection. Please select a text object!");
            peo.AddAllowedClass(typeof(DBText), false);
            //peo.AddAllowedClass(typeof(MText), false);
            PromptEntityResult per = ed.GetEntity(peo);

            if (per.Status != PromptStatus.OK)
                return;

            // Get the selected text object
            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                DBText selectedText = (DBText)tr.GetObject(per.ObjectId, OpenMode.ForRead);
                double selectedTextHeight = selectedText.Height;

                // Select all text objects with the same height
                TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.TxtSize, selectedTextHeight) };
                SelectionFilter sf = new SelectionFilter(tvs);
                PromptSelectionResult psr = ed.SelectAll(sf);

                if (psr.Status != PromptStatus.OK)
                    return;

                SelectionSet ss = psr.Value;
                ed.SetImpliedSelection(ss);

                tr.Commit();
            }
        }
    }
}
