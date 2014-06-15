using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bastion.Models.Common;
using Bastion.Models.Identity;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bastion.Models.Compute
{
    public class ComputeConfiguration
    {
        public ComputeConfiguration()
        {
            /*Marshalling = new Marshalling();
            UserAuthConfig = new IdentityEndpointConfiguration();
            ComputeAdminAuthConfig = new IdentityEndpointConfiguration();
            ComputeEndpoint = new ComputeEndpoint();
            ComputeAdminEndpoint = new ComputeEndpoint();
            Compute = new ComputeService();
            User = new UserConfiguration();
            ComputeAdminUser = new UserConfiguration();
            ComputeSecondaryUser = new UserConfiguration();
            Flavors = new Flavors();
            Images = new Images();
            Servers = new Servers();
            ConfigDrive = new ConfigDrive();*/
        }

        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("marshalling")]
        public Marshalling Marshalling { get; set; }

        [BsonElement("user_auth_config")]
        public IdentityEndpointConfiguration UserAuthConfig { get; set; }

        [BsonElement("compute_admin_auth_config")]
        public IdentityEndpointConfiguration ComputeAdminAuthConfig { get; set; }

        [BsonElement("compute_endpoint")]
        public ComputeEndpoint ComputeEndpoint { get; set; }

        [BsonElement("compute_admin_endpoint")]
        public ComputeEndpoint ComputeAdminEndpoint { get; set; }

        [BsonElement("compute")]
        public ComputeService Compute { get; set; }

        [BsonElement("user")]
        public UserConfiguration User { get; set; }

        [BsonElement("compute_admin_user")]
        public UserConfiguration ComputeAdminUser { get; set; }

        [BsonElement("compute_secondary_user")]
        public UserConfiguration ComputeSecondaryUser { get; set; }

        [BsonElement("flavors")]
        public Flavors Flavors { get; set; }

        [BsonElement("images")]
        public Images Images { get; set; }

        [BsonElement("servers")]
        public Servers Servers { get; set; }

        [BsonElement("config_drive")]
        public ConfigDrive ConfigDrive { get; set; }
    }
}