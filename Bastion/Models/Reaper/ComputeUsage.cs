﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class ComputeUsage : IResourceUsage
    {
        public int Instances { get; set; }
        public int Ram { get; set; }
        public int Disk { get; set; }
        public int Images { get; set; }
        public long ImagesDisk { get; set; }
        public int VCPUs { get; set; }

        public UsageStatus CurrentUsageStatus()
        {
            if (Instances < 15)
            {
                return UsageStatus.Ok;
            }
            else if (Instances < 30){
                return UsageStatus.Warning;
            }
            else
            {
                return UsageStatus.OverLimit;
            }
        }
    }

}