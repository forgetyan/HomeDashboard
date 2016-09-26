using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDashboardService.Entity
{
    public class NightscoutData
    {
        public string _id { get; set; }
        public string device { get; set; }
        public long date { get; set; }
        public string dateString { get; set; }
        public int sgv { get; set; }
        public string direction { get; set; }
        public string type { get; set; }
        public double filtered{ get; set; }
        public double unfiltered { get; set; }
        public int rssi { get; set; }
        public int noise { get; set; }
    }
}
