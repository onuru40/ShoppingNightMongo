using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingNightMongo.Entities
{
    public class Customer
    {
        [BsonId] // Primary key
        [BsonRepresentation(BsonType.ObjectId)] // Veri türü. Benzersiz olması için.
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal CustomerSurname { get; set; }
    }
}
