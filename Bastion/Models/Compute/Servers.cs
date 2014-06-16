using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Compute
{
    public class Servers
    {
        [DisplayName("Instance Auth Strategy")]
        [BsonElement("instance_auth_strategy")]
        public string InstanceAuthStrategy { get; set; }

        [DisplayName("Server Status Interval")]
        [BsonElement("server_status_interval")]
        public int ServerStatusInterval { get; set; }

        [DisplayName("Server Build Timeout")]
        [BsonElement("server_build_timeout")]
        public int ServerBuildTimeout { get; set; }

        [DisplayName("Server Resize Timeout")]
        [BsonElement("server_resize_timeout")]
        public int ServerResizeTimeout { get; set; }

        [DisplayName("Network for SSH")]
        [BsonElement("network_for_ssh")]
        public string NetworkForSSH { get; set; }

        [DisplayName("IP Address Version for SSH")]
        [BsonElement("ip_address_version_for_ssh")]
        public string IPAddressVersionForSSH { get; set; }

        [DisplayName("Instance Disk Path")]
        [BsonElement("instance_disk_path")]
        public string InstanceDiskPath { get; set; }

        [DisplayName("Connection Retry Interval")]
        [BsonElement("connection_retry_interval")]
        public int ConnectionRetryInterval { get; set; }

        [DisplayName("Connection Timeout")]
        [BsonElement("connection_timeout")]
        public int ConnectionTimeout { get; set; }

        [DisplayName("Expected Networks")]
        [BsonElement("expected_networks")]
        public string ExpectedNetworks { get; set; }

        [DisplayName("Split Ephemeral Disk Enabled")]
        [BsonElement("split_ephemeral_disk_enabled")]
        public bool SplitEphemeralDiskEnabled { get; set; }

        [DisplayName("Disk Format Type")]
        [BsonElement("disk_format_type")]
        public string DiskFormatType { get; set; }

        [DisplayName("Personality File Injection Enabled")]
        [BsonElement("personality_file_injection_enabled")]
        public bool PersonalityFileInjectionEnabled { get; set; }

        [DisplayName("Ephemeral Disk Max Size")]
        [BsonElement("ephemeral_disk_max_size")]
        public int EphemeralDiskMaxSize { get; set; }

        [DisplayName("Default Injected Files")]
        [BsonElement("default_injected_files")]
        public string DefaultInjectedFiles { get; set; }

        [DisplayName("Default File Path")]
        [BsonElement("default_file_path")]
        public string DefaultFilePath { get; set; }
    }
}