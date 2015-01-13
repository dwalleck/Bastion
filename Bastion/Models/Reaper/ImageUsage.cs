using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class ImageUsage : IResourceUsage
    {
        public int Images { get; set; }
        public long DiskUsed { get; set; }

        public UsageStatus CurrentUsageStatus()
        {
            if (Images < 10)
            {
                return UsageStatus.Ok;
            }
            else if (Images < 25)
            {
                return UsageStatus.Warning;
            }
            else
            {
                return UsageStatus.OverLimit;
            }
        }
    }
}