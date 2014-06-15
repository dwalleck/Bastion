using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Compute
{
    public class Servers
    {
        [BsonElement("instance_auth_strategy")]
        public string InstanceAuthStrategy { get; set; }

        [BsonElement("server_status_interval")]
        public int ServerStatusInterval { get; set; }

        [BsonElement("server_build_timeout")]
        public int ServerBuildTimeout { get; set; }

        [BsonElement("server_resize_timeout")]
        public int ServerResizeTimeout { get; set; }

        [BsonElement("network_for_ssh")]
        public string NetworkForSSH { get; set; }

        [BsonElement("ip_address_version_for_ssh")]
        public string IPAddressVersionForSSH { get; set; }

        [BsonElement("instance_disk_path")]
        public string InstanceDiskPath { get; set; }

        [BsonElement("connection_retry_interval")]
        public int ConnectionRetryInterval { get; set; }

        [BsonElement("expected_networks")]
        public string ExpectedNetworks { get; set; }

        [BsonElement("split_ephemeral_disk_enabled")]
        public bool SplitEphemeralDiskEnabled { get; set; }

        [BsonElement("disk_format_type")]
        public string DiskFormatType { get; set; }

        [BsonElement("personality_file_injection_enabled")]
        public bool PersonalityFileInjectionEnabled { get; set; }

        [BsonElement("ephemeral_disk_max_size")]
        public int EphemeralDiskMaxSize { get; set; }

        [BsonElement("default_injected_files")]
        public string DefaultInjectedFiles { get; set; }

        [BsonElement("default_file_path")]
        public string DefaultFilePath { get; set; }
    }
}