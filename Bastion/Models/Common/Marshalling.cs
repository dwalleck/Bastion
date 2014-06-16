using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Common
{
    public class Marshalling
    {
        [DisplayName("Serialization Format")]
        [BsonElement("serialize_format")]
        public string SerializeFormat { get; set; }

        [DisplayName("Deserialization Format")]
        [BsonElement("deserialize_format")]
        public string DeserializeFormat { get; set; }
    }
}