namespace PIM.Api.Models
{
    public class ProductCategoryMapping
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
