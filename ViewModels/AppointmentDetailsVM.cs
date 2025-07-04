﻿using Hospital_System.Models;

namespace Hospital_System.ViewModels
{
    public class AppointmentDetailsVM
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public List<TimeOnly> ReservedAppointments { get; set; } = new();
        public string Patient { get; set; }
        public DateOnly AppointmentDate { get; set; }
    }
}
