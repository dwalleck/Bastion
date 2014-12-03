using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Images
{
    public class Image
    {
        public Image()
        {
            Actions = new Actions();
        }

        public ObjectId Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public Actions Actions { get; set; }
    }

    public class Actions
    {
        public Actions()
        {
            Create = new ActionResults();
            CreateImage = new ActionResults();
            CreateBootableVolume = new ActionResults();
            CreateFromVolume = new ActionResults();
        }

        public ActionResults Create { get; set; }
        public ActionResults CreateImage { get; set; }
        public ActionResults CreateBootableVolume { get; set; }
        public ActionResults CreateFromVolume { get; set; }
    }

    public class ActionResults
    {

        public ActionResults()
        {
            Results = new List<ActionResult>();
        }

        public List<ActionResult> Results { get; set; }
        public double MinTime { get; set; }
        public double MaxTime { get; set; }
        public double AverageTime { get; set; }
    }

    public class ActionResult
    {
        public bool WasSuccessful { get; set; }
        public double ActionTime { get; set; }
    }

    public enum TestResult { Passed, Failed, Errored };
}