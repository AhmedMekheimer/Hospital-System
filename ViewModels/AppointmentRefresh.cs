namespace Hospital_System.ViewModels
{
    public class AppointmentRefresh
    {
        public int Id { get; set; }
        public List<TimeOnly> ReservedAppointments { get; set; } = new();
        public string Patient { get; set; }
        public DateOnly AppointmentDate { get; set; }
    }
}
