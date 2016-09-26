using HomeDashboardService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDashboardService.Interface
{
    public interface IDashboardService
    {
        IList<NightscoutData> GetLatestData(string nightscoutSiteUrl);
    }
}
