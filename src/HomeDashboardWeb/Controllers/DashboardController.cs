using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDashboardWeb.ViewModel;
using HomeDashboardService.Interface;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDashboardWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IDashboardService _dashboardService { get; set; }

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new DashboardViewModel();
            var data = _dashboardService.GetLatestData("https://jay-t1d.azurewebsites.net");
            model.JeremyGC = data[0].sgv;
            return View(model);
        }
    }
}
