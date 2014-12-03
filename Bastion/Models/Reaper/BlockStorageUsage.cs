using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class BlockStorageUsage : IResourceUsage
    {
        public int Volumes { get; set; }
        public int DiskUsed { get; set; }

        public UsageStatus CurrentUsageStatus()
        {
            if (Volumes < 10)
            {
                return UsageStatus.Ok;
            }
            else if (Volumes < 20)
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