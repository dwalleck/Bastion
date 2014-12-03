using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{

    public enum UsageStatus { Ok, Warning, OverLimit }

    public interface IResourceUsage
    {
        UsageStatus CurrentUsageStatus();
    }
}