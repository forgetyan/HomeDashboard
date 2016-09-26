using HomeDashboardService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDashboardService.RepositoryInterface
{
    public interface INightscoutRepository
    {
        IList<NightscoutData> GetLatestData(string nightscoutSiteUrl);
    }
}
