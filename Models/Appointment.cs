namespace Hospital_System.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        //Creating Patient Class in the future
        public string Patient { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
    }
}
