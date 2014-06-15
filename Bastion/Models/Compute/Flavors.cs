using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Compute
{
    public class Flavors
    {
        [BsonElement("primary_flavor")]
        public string PrimaryFlavor { get; set; }

        [BsonElement("secondary_flavor")]
        public string SecondaryFlavor { get; set; }

        [BsonElement("resize_enabled")]
        public bool ResizeEnabled { get; set; }
    }
}