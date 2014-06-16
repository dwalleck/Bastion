using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Compute
{
    public class ConfigDrive
    {
        [DisplayName("OpenStack Metadata Path")]
        [BsonElement("openstack_meta_path")]
        public string OpenStackMetaPath { get; set; }

        [DisplayName("EC Metadata Path")]
        [BsonElement("ec_meta_path")]
        public string EcMetaPath { get; set; }

        [DisplayName("Base Path to Mount")]
        [BsonElement("base_path_to_mount")]
        public string BasePathToMount { get; set; }

        [DisplayName("Mount Source Path")]
        [BsonElement("mount_source_path")]
        public string MountSourcePath { get; set; }

        [DisplayName("Min Size")]
        [BsonElement("min_size")]
        public int MinSize { get; set; }

        [DisplayName("Max Size")]
        [BsonElement("max_size")]
        public int MaxSize { get; set; }
    }
}