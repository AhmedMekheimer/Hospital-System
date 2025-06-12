using Hospital_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Specialization>().HasData(
                new Specialization { SpecializationId=1,Name= "Cardiology" },
                new Specialization { SpecializationId = 2, Name = "Pediatrics" },
                new Specialization { SpecializationId = 3, Name = "Dermatology" },
                new Specialization { SpecializationId = 4, Name = "Orthopedics" },
                new Specialization { SpecializationId = 5, Name = "Neurology" }
                );
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, Name = "Dr. John Smith", SpecializationId = 1, Img = "Images/doctor1.jpg", Price = 1000 },
                new Doctor { DoctorId = 2, Name = "Dr. Ahmed Johnson", SpecializationId = 2, Img = "Images/doctor2.jpg", Price = 2000 },
                new Doctor { DoctorId = 3, Name = "Dr. Ali Davis", SpecializationId = 3, Img = "Images/doctor4.jpg", Price = 5000 },
                new Doctor { DoctorId = 4, Name = "Dr. Michael Lee", SpecializationId = 4, Img = "Images/doctor3.jpg", Price = 5500 },
                new Doctor { DoctorId = 5, Name = "Dr. William Clark", SpecializationId = 5, Img = "Images/doctor5.jpg", Price = 6000 },

                new Doctor { DoctorId = 6, Name = "Dr. Salah Smith", SpecializationId = 1, Img = "Images/doctor1.jpg", Price = 3000 },
                new Doctor { DoctorId = 7, Name = "Dr. Ahmed Ali", SpecializationId = 2, Img = "Images/doctor2.jpg", Price = 5000 },
                new Doctor { DoctorId = 8, Name = "Dr. Ammar Mohammed", SpecializationId = 3, Img = "Images/doctor4.jpg", Price = 1000 },
                new Doctor { DoctorId = 9, Name = "Dr. Khaled Lee", SpecializationId = 4, Img = "Images/doctor3.jpg", Price = 2200 },
                new Doctor { DoctorId = 10, Name = "Dr. Lee Clark", SpecializationId = 5, Img = "Images/doctor5.jpg", Price = 3300 },

                new Doctor { DoctorId = 11, Name = "Dr. Eslam Lee", SpecializationId = 1, Img = "Images/doctor1.jpg", Price = 1000 },
                new Doctor { DoctorId = 12, Name = "Dr. Mofid Johnson", SpecializationId = 2, Img = "Images/doctor2.jpg", Price = 2000 },
                new Doctor { DoctorId = 13, Name = "Dr. Omar Ali", SpecializationId = 3, Img = "Images/doctor4.jpg", Price = 5000 },
                new Doctor { DoctorId = 14, Name = "Dr. Mahmoud Ismail", SpecializationId = 4, Img = "Images/doctor3.jpg", Price = 5500 },
                new Doctor { DoctorId = 15, Name = "Dr. Ismail mohammed", SpecializationId = 5, Img = "Images/doctor5.jpg", Price = 6000 },

                new Doctor { DoctorId = 16, Name = "Dr. Smith Simba", SpecializationId = 1, Img = "Images/doctor1.jpg", Price = 2000 },
                new Doctor { DoctorId = 17, Name = "Dr. Mosamba Johnson", SpecializationId = 2, Img = "Images/doctor2.jpg", Price = 7000 },
                new Doctor { DoctorId = 18, Name = "Dr. Mousa Davis", SpecializationId = 3, Img = "Images/doctor4.jpg", Price = 10000 },
                new Doctor { DoctorId = 19, Name = "Dr. Yaqoub Smith", SpecializationId = 4, Img = "Images/doctor3.jpg", Price = 6500 },
                new Doctor { DoctorId = 20, Name = "Dr. Lee Donald", SpecializationId = 5, Img = "Images/doctor5.jpg", Price = 6700 }
            );
        }

    }
}
