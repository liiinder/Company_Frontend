using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Company_Frontend.Components.Models;

public class Order
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("_id")]
    public string? Id { get; set; }
    public string CustomerId { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new();
}

