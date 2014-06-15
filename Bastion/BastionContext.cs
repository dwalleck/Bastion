using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using Bastion.Properties;
using Bastion.Models.Compute;

namespace Bastion
{
    public class BastionContext
    {
        public MongoDatabase Database;

        public BastionContext()
        {
            var client = new MongoClient(Settings.Default.BastionConnectionString);
            MongoServer server = client.GetServer();
            Database = server.GetDatabase(Settings.Default.BastionDatabaseName);          
        }

        public MongoCollection<ComputeConfiguration> Configurations
        {
            get
            {
                return Database.GetCollection<ComputeConfiguration>("configs");
            }
        }
    }
}