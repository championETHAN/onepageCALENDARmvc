using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onepageCALENDARmvc.Data;
using onepageCALENDARmvc.Models;

namespace onepageCALENDARmvc.Controllers
{
    public class CalendarController : Controller
    {
        private readonly onepageCALENDARmvcDbContext dbContext;
        public CalendarController(onepageCALENDARmvcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddCalendarEntryViewModel addCalendarEntryRequest)
        {
            var calendarEntry = new CalendarEntry();
            {
                //Id = Guid.NewGuid(),
                //Title = addCalendarEntryRequest.Title,
                //Date = addCalendarEntryRequest.Date,
                //TypeOfEvent = addCalendarEntryRequest.TypeOfEvent
            };

            await dbContext.CalendarEntrys.AddAsync(calendarEntry);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }

    }
}
