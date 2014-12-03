using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.BuildResults
{
    public class BuildActionResults
    {

        public BuildActionResults()
        {
            Results = new List<BuildActionResult>();
        }
        public ObjectId Id { get; set; }
        public List<BuildActionResult> Results { get; set; }
        public string ImageId { get; set; }
        public string ImageName { get; set; }
        public string Region { get; set; }
        public string Endpoint { get; set; }
        public int NumberOfServers { get; set; }
        public double MinTime { get; set; }
        public double MaxTime { get; set; }
        public double AverageTime { get; set; }
        public double TotalRunTime { get; set; }
        public double SuccessRate { get; set; }
        public int Timeouts { get; set; }
        public int ServerErrors { get; set; }
    }

    public class BuildActionResult
    {
        public string ResourceId { get; set; }
        public string CreationRequestId { get; set; }
        public bool WasSuccessful { get; set; }
        public double ActionTime { get; set; }
        public string FailureReason { get; set; }
    }
}