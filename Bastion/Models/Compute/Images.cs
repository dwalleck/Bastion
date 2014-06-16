using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Bastion.Models.Compute
{
    public class Images
    {
        [DisplayName("Primary Image")]
        [BsonElement("primary_image")]
        public string PrimaryImage { get; set; }

        [DisplayName("Primary Image Default User")]
        [BsonElement("primary_image_default_user")]
        public string PrimaryImageDefaultUser { get; set; }

        [DisplayName("Primary Image has Protected Properties")]
        [BsonElement("primary_image_has_protected_properties")]
        public bool PrimaryImageHasProtectedProperties { get; set; }

        [DisplayName("Primary Image Path Separator")]
        [BsonElement("primary_image_path_separator")]
        public string PrimaryImagePathSeparator { get; set; }

        [DisplayName("Secondary Image")]
        [BsonElement("secondary_image")]
        public string SecondaryImage { get; set; }

        [DisplayName("Image Status Interval")]
        [BsonElement("image_status_interval")]
        public int ImageStatusInterval { get; set; }

        [DisplayName("Snapshot Timeout")]
        [BsonElement("snapshot_timeout")]
        public int SnapshotTimeout { get; set; }

        [DisplayName("Non-Inherited Metadata File Path")]
        [BsonElement("non_inherited_metadata_filepath")]
        public string NonInheritedMetadataFilePath { get; set; }
    }
}