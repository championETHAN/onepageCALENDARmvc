namespace onepageCALENDARmvc.Models
{
    public class AddCalendarEntryViewModel
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }
        public EventType TypeOfEvent { get; set; }

    }
}
