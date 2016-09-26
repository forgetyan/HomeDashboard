using HomeDashboardService.Entity;
using HomeDashboardService.Interface;
using HomeDashboardService.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDashboardService
{
    public class DashboardService : IDashboardService
    {
        public INightscoutRepository _nightscoutRepository { get; set; }

        public DashboardService(INightscoutRepository nightscoutRepository)
        {
            _nightscoutRepository = nightscoutRepository;
        }


        public IList<NightscoutData> GetLatestData(string nightscoutSiteUrl)
        {
            return _nightscoutRepository.GetLatestData(nightscoutSiteUrl);
        }
    }
}
