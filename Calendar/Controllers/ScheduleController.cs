using Calendar.Models;
using Microsoft.AspNetCore.Mvc;


namespace Calendar.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult BlockEvents()
        {
            ViewBag.dataSource = new List<AppointmentData>
            {
                new AppointmentData
                { Id = 1, Subject = "Explosion of Betelgeuse Star", StartTime = new DateTime(2022, 2, 11, 9, 30, 0), EndTime = new DateTime(2022, 2, 11, 11, 0, 0) },
                new AppointmentData
                { Id = 2, Subject = "Thule Air Crash Report", StartTime = new DateTime(2022, 2, 12, 12, 0, 0), EndTime = new DateTime(2022, 2, 12, 14, 0, 0) },
                new AppointmentData
                { Id = 3, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2022, 2, 13, 9, 30, 0), EndTime = new DateTime(2022, 2, 13, 11, 0, 0) },
                new AppointmentData
                { Id = 4, Subject = "Meteor Showers in 2022", StartTime = new DateTime(2022, 2, 14, 13, 0, 0), EndTime = new DateTime(2022, 2, 14, 14, 30, 0) },
                new AppointmentData
                { Id = 5, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2022, 2, 15, 12, 0, 0), EndTime = new DateTime(2022, 2, 15, 14, 0, 0) }
            };

            List<EmployeeData> employees = new List<EmployeeData>();
            employees.Add(new EmployeeData { text = "Alice", id = 1, groupId = 1, color = "#bbdc00", designation = "Content writer" });
            employees.Add(new EmployeeData { text = "Nancy", id = 2, groupId = 2, color = "#9e5fff", designation = "Designer" });
            employees.Add(new EmployeeData { text = "Robert", id = 3, groupId = 1, color = "#bbdc00", designation = "Software Engineer" });
            employees.Add(new EmployeeData { text = "Robson", id = 4, groupId = 2, color = "#9e5fff", designation = "Support Engineer" });
            employees.Add(new EmployeeData { text = "Laura", id = 5, groupId = 1, color = "#bbdc00", designation = "Human Resource" });
            employees.Add(new EmployeeData { text = "Margaret", id = 6, groupId = 2, color = "#9e5fff", designation = "Content Analyst" });
            ViewBag.Employees = employees;

            ViewBag.Resources = new string[] { "Employee" };
            return View();
        }

        
    }
}
