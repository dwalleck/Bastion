using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Compute
{
    public class ComputeService
    {
        [BsonElement("hypervisor")]
        public string Hypervisor { get; set; }
    }
}