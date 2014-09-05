using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bastion.Models.Compute
{
    public class SecurityGroups
    {
        [DisplayName("Default Security Group")]
        [BsonElement("default_security_group")]
        public string DefaultSecurityGroup { get; set; }
    }
}