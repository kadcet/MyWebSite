namespace MyWebSite.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal OldPrice { get; set; }

        public decimal Price { get; set; }

        public string ProductImageFilePath { get; set; }

        public string ProductRateFilePath { get; set; }

        public Category Category { get; set; }
    }
}