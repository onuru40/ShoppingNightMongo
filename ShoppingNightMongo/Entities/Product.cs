using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingNightMongo.Entities
{
    public class Product
    {
        [BsonId] // Primary key
        [BsonRepresentation(BsonType.ObjectId)] // Veri türü. Benzersiz olması için.
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
        public string CategoryId { get; set; }
    }
}
