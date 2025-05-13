namespace ShoppingNightMongo.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        // DTO ile sadece ihtiyacımız olan alanları alıyoruz. Tüm işlemlerde kendi kategorisindeki alanları alıyoruz.
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
    }
}
