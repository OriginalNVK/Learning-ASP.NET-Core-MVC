namespace Warehouse
{
    public partial class Product
    {
        //private field
        private int _productID;
        //public property
        public int ProductID
        {
            get; set;
        } = default;

        // Declaration the partial method
        partial void GetTax();
    }
}
