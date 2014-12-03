using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class NetworkUsage : IResourceUsage
    {
        public int Networks { get; set; }

        public UsageStatus CurrentUsageStatus()
        {
            if (Networks < 5)
            {
                return UsageStatus.Ok;
            }
            else if (Networks < 7)
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