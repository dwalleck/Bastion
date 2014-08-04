using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class Account
    {

        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string ApiKey { get; set; }
        public string EmailAddress { get; set; }
        public string TenantId { get; set; }
        public AccountUsage Usage { get; set; }
    }
}