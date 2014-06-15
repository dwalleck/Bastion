using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace Bastion.Models.Compute
{
    public class Images
    {
        [BsonElement("primary_image")]
        public string PrimaryImage { get; set; }

        [BsonElement("primary_image_default_user")]
        public string PrimaryImageDefaultUser { get; set; }

        [BsonElement("primary_image_has_protected_properties")]
        public bool PrimaryImageHasProtectedProperties { get; set; }

        [BsonElement("primary_image_path_separator")]
        public string PrimaryImagePathSeparator { get; set; }

        [BsonElement("secondary_image")]
        public string SecondaryImage { get; set; }

        [BsonElement("image_status_interval")]
        public int ImageStatusInterval { get; set; }

        [BsonElement("snapshot_timeout")]
        public int SnapshotTimeout { get; set; }

        [BsonElement("non_inherited_metadata_filepath")]
        public string NonInheritedMetadataFilePath { get; set; }
    }
}