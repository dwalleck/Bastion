using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Bastion.Models.CafeReporting
{

    public class ComputeContext
    {
        public ObjectId Id { get; set; }
        public string parent_uuid { get; set; }
        public object request_params { get; set; }
        public object response_content { get; set; }
        public string result { get; set; }
        public string context_name { get; set; }
        public string test_uuid { get; set; }
        public bool baseline { get; set; }
        public object request_body { get; set; }
        public int logfile_stop { get; set; }
        public int logfile_start { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public double _stop_time { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public double elapsed_time { get; set; }
        public object build { get; set; }
        public object method { get; set; }
        public object metadata { get; set; }
        public string product { get; set; }
        public object response_headers { get; set; }
        public object docstring { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public double _start_time { get; set; }
        public string sequence_id { get; set; }
        public string context_uuid { get; set; }
        public string logfile { get; set; }
        public string rollup_result { get; set; }
        public object url { get; set; }
        public int? response_code { get; set; }
        public string context_type { get; set; }
    }


}