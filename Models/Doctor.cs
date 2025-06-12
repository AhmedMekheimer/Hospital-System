namespace Hospital_System.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Frequency { get; set; } = 0;
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
    }
}
