using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using HomeDashboardService.Entity;
using HomeDashboardService.RepositoryInterface;

namespace HomeDashboardRepository
{
    public class NightscoutRepository : INightscoutRepository
    {
        public IList<NightscoutData> GetLatestData(string nightscoutSiteUrl)
        {
            IList<NightscoutData> response;
            var finalUrl = nightscoutSiteUrl + "/api/v1/entries/sgv.json";
            var hc = new HttpClient();
            using (HttpClient wc = new HttpClient())
            {
                var json = wc.GetStringAsync(finalUrl).Result;

                //var json = await wc.GetStringAsync(finalUrl);
                response = JsonConvert.DeserializeObject<IList<NightscoutData>>(json);
            }
            return response;
        }
    }
}
