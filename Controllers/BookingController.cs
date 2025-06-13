using Hospital_System.Data;
using Hospital_System.Models;
using Hospital_System.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_System.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookingController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(DoctorsWithFiltersVM doctorsWithFiltersVM)
        {
            IQueryable<Doctor> doctors = _db.Doctors.Include(e => e.Specialization);
            var specializations = _db.Specializations.ToList();
            //Name Filter
            if (doctorsWithFiltersVM.DoctorName is not null)
            {
                doctors = doctors.Where(e => e.Name.Contains(doctorsWithFiltersVM.DoctorName));
            }

            //Min Price Filter
            if (doctorsWithFiltersVM.Min > 0)
            {
                doctors = doctors.Where(e => e.Price > doctorsWithFiltersVM.Min);
            }
            //Max Price Filter
            if (doctorsWithFiltersVM.Max > 0)
            {
                doctors = doctors.Where(e => e.Price > doctorsWithFiltersVM.Max);
            }

            //Sort by Most Visited Filter
            if (doctorsWithFiltersVM.MostVisited)
            {
                doctors = doctors.OrderByDescending(e => e.Frequency);
            }

            //Specialization Filter
            if (doctorsWithFiltersVM.SpecializationId > 0 && doctorsWithFiltersVM.SpecializationId <= specializations.Count)
            {
                doctors = doctors.Where(e => e.Specialization.SpecializationId == doctorsWithFiltersVM.SpecializationId);
            }

            //Pagination
            double NoDoctorsPerPage = 5.0;
            int NoPages = (int)Math.Ceiling(doctors.Count() / NoDoctorsPerPage);
            doctorsWithFiltersVM.NoPages = NoPages;
            if (doctorsWithFiltersVM.Page <= 0)
            {
                doctorsWithFiltersVM.Page = 1;
            }
            else if (doctorsWithFiltersVM.Page > NoPages)
            {
                doctorsWithFiltersVM.Page = NoPages;
            }
            doctors=doctors.Skip((int)((doctorsWithFiltersVM.Page - 1) * NoDoctorsPerPage)).Take((int)NoDoctorsPerPage);

            //Passing Specializations for Drop Menu & Doctors to View after Filters
            doctorsWithFiltersVM.Specializations = specializations;
            doctorsWithFiltersVM.Doctors = doctors.ToList();
            return View(doctorsWithFiltersVM);
        }
        public IActionResult Appointment(AppointmentDetailsVM appointmentDetailsVM)
        {
            if(appointmentDetailsVM.Id>0 && appointmentDetailsVM.Id<= _db.Doctors.Count())
            {
                var doctor = _db.Doctors.FirstOrDefault(e => e.DoctorId == appointmentDetailsVM.Id);
                doctor.Frequency++;
                _db.SaveChanges();
            }
            
            return View(appointmentDetailsVM);
        }
    }
}
