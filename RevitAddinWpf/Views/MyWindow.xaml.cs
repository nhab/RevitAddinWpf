
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

using RevitAddinWPF.ExternalEvents;

namespace ClassLibrary1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        Document Doc;

        ExternalEventHandlerSelect _externalEventHaandlerSelect;
        ExternalEvent _SelectExternalevent;
    
        public ObservableCollection<ElementsInDataGrid> data { get; set; }

        public MyWindow()
        { 
        }

        public MyWindow(Document doc
             , ExternalEventHandlerSelect seeh
            , ExternalEvent selectEvent)
        {
            InitializeComponent();

            Doc = doc;
            
            _externalEventHaandlerSelect = seeh;
            _SelectExternalevent = selectEvent;
         
        }

   

    

  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
