using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Identity
{
    public class UserConfiguration
    {
        [BsonElement("username")]
        public string Username { get; set; }

        [DisplayName("API Key")]
        [BsonElement("api_key")]
        public string ApiKey { get; set; }

        [DisplayName("Tenant ID")]
        [BsonElement("tenant_id")]
        public string TenantId { get; set; }

        [DisplayName("User ID")]
        [BsonElement("user_id")]
        public string UserId { get; set; }
    }
}