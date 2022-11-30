using Calendar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Resources = new string[] { "Owners" };
            ViewBag.datasource = GetResourceData();
            ViewBag.Owners = Getowners();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<ResourceData> GetResourceData()
        {
            List<ResourceData> resourceData = new List<ResourceData>();
            resourceData.Add(new ResourceData
            {
                Id = 1,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(2018, 4, 3, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 3, 13, 0, 0),
                IsAllDay = false,
                OwnerId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 2,
                Subject = "Requirement planning",
                StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 13, 0, 0),
                IsAllDay = false,
                OwnerId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 3,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2018, 4, 5, 10, 0, 0),
                EndTime = new DateTime(2018, 4, 5, 13, 0, 0),
                IsAllDay = false,
                OwnerId = 3
            });
            return resourceData;
        }

        private List<OwnerRes> Getowners()
        {
            return new List<OwnerRes>()
                {
                    new OwnerRes { text = "Nancy", id = 1, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 2, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 3, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 11, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 21, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 31, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 12, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 22, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 32, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 13, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 23, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 33, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 14, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 24, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 34, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 15, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 25, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 35, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 16, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 26, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 36, color = "#7499e1" },
                    new OwnerRes { text = "Nancy", id = 17, color = "#ffaa00" },
                    new OwnerRes { text = "Steven", id = 27, color = "#f8a398" },
                    new OwnerRes { text = "Michael", id = 37, color = "#7499e1"}
                };
        }

    }
}