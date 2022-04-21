using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyGroupPlugin
{
    [Transaction(TransactionMode.Manual)]
    public class CopyGroup : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            Reference reference = uiDoc.Selection.PickObject(ObjectType.Element, "Выберите группу элементов");
            Element element = doc.GetElement(reference);

            Group group = element as Group;
            XYZ point = uiDoc.Selection.PickPoint("Выберите точку");
            Transaction ts = new Transaction(doc);

            ts.Start("Копирование группы объектов");

            doc.Create.PlaceGroup(point, group.GroupType);
            ts.Commit();

            return Result.Succeeded;


        }
    }
}
