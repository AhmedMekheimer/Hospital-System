using Hospital_System.Models;

namespace Hospital_System.ViewModels
{
    public class DoctorsWithFiltersVM
    {
        //Filter Properties
        public string  DoctorName { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public bool MostVisited { get; set; }
        public int SpecializationId { get; set; }
        //Properties Sent to be Viewed
        public List<Specialization> Specializations { get; set; } = new List<Specialization>();
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public int Page { get; set; }
        public int NoPages { get; set; }
    }
}
