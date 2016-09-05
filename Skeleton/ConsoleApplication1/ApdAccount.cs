using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleApplication1
{
    public class ApdAccount
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid AccountId { get; set; }

        public int Version { get; set; }

        public ApdPerson Person { get; set; }
    }
}