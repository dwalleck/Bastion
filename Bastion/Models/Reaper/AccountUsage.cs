using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bastion.Models.Reaper
{
    public class AccountUsage
    {
        public ComputeUsage Compute { get; set; }
        public BlockStorageUsage BlockStorage { get; set; }
        public NetworkUsage Networks { get; set; }
        public ImageUsage Images { get; set; }
    }
}