namespace ClassLibrary1
{
    public class ElementsInDataGrid
    {
        public string ElementType { get; set; }
        public string ElementId { get; set; }
        public ElementsInDataGrid(string elementType, string elementID)
        {
            ElementId = elementID;
            ElementType = elementType;
        }

    }
}