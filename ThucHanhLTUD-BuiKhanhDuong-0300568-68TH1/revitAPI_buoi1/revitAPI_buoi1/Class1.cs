using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Collections.Generic;
using System.Windows;

namespace revitAPI_buoi1
{
    [Autodesk.Revit.Attributes.Transaction(
        Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class revitAPI_buoi1 : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            UIDocument uiDocument = commandData.Application.ActiveUIDocument;

            ICollection<ElementId> selectElements = uiDocument.Selection.GetElementIds();

            int totalCount = selectElements.Count;

            MessageBox.Show("Ban da chon " + totalCount.ToString() + " elements");
            return Result.Succeeded;
        }
    }
}
