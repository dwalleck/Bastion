using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Common
{
    public class Marshalling
    {
        [BsonElement("serialize_format")]
        public string SerializeFormat { get; set; }

        [BsonElement("deserialize_format")]
        public string DeserializeFormat { get; set; }
    }
}