using System.Reflection.PortableExecutable;

namespace Hospital_System.Models
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; } = new List<Doctor>();
    }
}
