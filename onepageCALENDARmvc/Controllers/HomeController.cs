using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onepageCALENDARmvc.Data;
using onepageCALENDARmvc.Models;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace onepageCALENDARmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly onepageCALENDARmvcDbContext dbContext;
        public HomeController(onepageCALENDARmvcDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var todaysDate = DateTime.Today;
            var _calendar = await dbContext.CalendarEntrys.Where(x => x.Date == todaysDate).ToListAsync();
            ViewBag.calendar = _calendar;
            //This is for crudLayer1 aka Todays Calendar Entrys
            var _Fullcalendar = await dbContext.CalendarEntrys.ToListAsync();
            ViewBag.Fullcalendar = _Fullcalendar;
            //This is for crudlayer3 aka full list of calendarEntrys

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AddCalendarEntryViewModel addCalendarEntryRequest)
        {
            var calendarEntry = new CalendarEntry()
            { 
                
                Id = Guid.NewGuid(),
                Title = addCalendarEntryRequest.Title,
                Date = addCalendarEntryRequest.Date,
                TypeOfEvent = addCalendarEntryRequest.TypeOfEvent
            };

            await dbContext.CalendarEntrys.AddAsync(calendarEntry);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
            //return View();
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
        
    }
}
