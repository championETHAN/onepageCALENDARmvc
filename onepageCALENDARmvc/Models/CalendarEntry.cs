namespace onepageCALENDARmvc.Models
{
    public class CalendarEntry
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public EventType TypeOfEvent { get; set; }
    }
}
