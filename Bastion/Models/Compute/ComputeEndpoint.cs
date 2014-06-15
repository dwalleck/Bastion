using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Compute
{
    public class ComputeEndpoint
    {
        [BsonElement("region")]
        public string Region { get; set; }

        [DisplayName("Compute Endpoint Name")]
        [BsonElement("compute_endpoint_name")]
        public string ComputeEndpointName { get; set; }

        [DisplayName("Compute Endpoint Url")]
        [BsonElement("compute_endpoint_url")]
        public string ComputeEndpointUrl { get; set; }
    }
}