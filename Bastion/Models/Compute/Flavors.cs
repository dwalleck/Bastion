using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Compute
{
    public class Flavors
    {
        [DisplayName("Primary Flavor")]
        [BsonElement("primary_flavor")]
        public string PrimaryFlavor { get; set; }

        [DisplayName("Secondary Flavor")]
        [BsonElement("secondary_flavor")]
        public string SecondaryFlavor { get; set; }

        [DisplayName("Resize Enabled")]
        [BsonElement("resize_enabled")]
        public bool ResizeEnabled { get; set; }
    }
}