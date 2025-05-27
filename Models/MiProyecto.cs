using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class MiProyecto {
    [BsonId, BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }

    public string? NombreIntegrante1 { get; set; }

    public string NombreIntegrante2 { get; set; }
}