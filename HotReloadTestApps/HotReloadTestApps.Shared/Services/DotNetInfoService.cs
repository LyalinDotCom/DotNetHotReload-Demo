using HotReloadTestApps.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotReloadTestApps.Shared.Services
{
    public class DotNetInfoService
    {
        public async Task<Collection<DotNetRelease>> GetReleasesAsync()
        {
            //Source: https://en.wikipedia.org/wiki/.NET_Framework_version_history

            await Task.Delay(2000);

            Collection<DotNetRelease> results = new();

            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 1.0"
            });
            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 1.0 (Service Pack 1)"
            });
            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 1.0 (Service Pack 2)"
            });
            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 1.0 (Service Pack 3)"
            });
            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 1.1"
            });

            results.Add(new DotNetRelease
            {
                Description = ".NET Framework 2.0"
            });


            return results;
        }
    }
}
