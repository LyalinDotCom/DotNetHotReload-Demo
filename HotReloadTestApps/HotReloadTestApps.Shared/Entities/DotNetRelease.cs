using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotReloadTestApps.Shared.Entities
{
    public class DotNetRelease
    {
        public string Description { get; set; }
        public DateTime Released { get; set; }

        public bool IsLatestSupported { get; set; }
        public bool IsPreview { get; set; }
    }
}
