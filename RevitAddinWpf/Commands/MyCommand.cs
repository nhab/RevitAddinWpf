using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ClassLibrary1;
using System.Windows;
using System.Windows.Controls;
using RevitAddinWPF.ExternalEvents;

namespace WallsAndDoorsTester
{
    [Transaction(TransactionMode.Manual)]
    public class MyCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
         
            UIApplication uiApp = commandData.Application;
            Document doc = uiApp.ActiveUIDocument.Document;
            ExternalEventHandlerSelect selectExternalEventHandler = new ExternalEventHandlerSelect();

            ExternalEvent _mySelectExternalEvent = ExternalEvent.Create(selectExternalEventHandler);  
           
            MyWindow myWindow = new MyWindow(
                doc
                , selectExternalEventHandler
                ,_mySelectExternalEvent
                );
            myWindow.Show();
           
            return Result.Succeeded;
        }

    }
}
