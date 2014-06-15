using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Identity
{
    public class UserConfiguration
    {
        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("api_key")]
        public string ApiKey { get; set; }

        [BsonElement("tenant_id")]
        public string TenantId { get; set; }

        [BsonElement("user_id")]
        public string UserId { get; set; }
    }
}