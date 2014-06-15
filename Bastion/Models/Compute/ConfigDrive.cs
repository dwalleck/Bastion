using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Compute
{
    public class ConfigDrive
    {
        [BsonElement("openstack_meta_path")]
        public string OpenStackMetaPath { get; set; }

        [BsonElement("ec_meta_path")]
        public string EcMetaPath { get; set; }

        [BsonElement("base_path_to_mount")]
        public string BasePathToMount { get; set; }

        [BsonElement("mount_source_path")]
        public string MountSourcePath { get; set; }

        [BsonElement("min_size")]
        public int MinSize { get; set; }

        [BsonElement("max_size")]
        public int MaxSize { get; set; }
    }
}