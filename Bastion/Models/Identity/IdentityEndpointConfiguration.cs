using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Identity
{
    public class IdentityEndpointConfiguration
    {
        [BsonElement("endpoint")]
        public string Endpoint { get; set; }

        [BsonElement("strategy")]
        public string Strategy { get; set; }
    }
}