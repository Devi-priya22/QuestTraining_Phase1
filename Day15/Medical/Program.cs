using System;
using System.Collections.Generic;
using System.Linq;

namespace Medical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "John Doe", Age = 65, Gender = "Male", MedicalCondition = "Hypertension" },
                new Patient { Id = 2, Name = "Jane Smith", Age = 70, Gender = "Female", MedicalCondition = "Diabetes" },
                new Patient { Id = 3, Name = "Sam Brown", Age = 45, Gender = "Male", MedicalCondition = "Asthma" }
            };

            var appointments = new List<Appointment>
            {
                new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. A", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" },
                new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. B", AppointmentDate = DateTime.Now.AddDays(2), AppointmentType = "Follow-up" },
                new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. C", AppointmentDate = DateTime.Now.AddDays(10), AppointmentType = "Surgery" },
                new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. A", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Consultation" }
            };

            // Upcoming 7 days
            var upcoming = appointments
                .Join(
                    patients,
                    a => a.PatientId,
                    p => p.Id,
                    (a, p) => new { Appointment = a, Patient = p })
                .Where(ap => ap.Appointment.AppointmentDate >= DateTime.Now && ap.Appointment.AppointmentDate <= DateTime.Now.AddDays(7))
                .Select(ap => new
                {
                    ap.Patient.Name,
                    ap.Patient.Age,
                    ap.Patient.MedicalCondition
                }).ToList();

            Console.WriteLine("Upcoming in 7 days");
            foreach (var patient in upcoming)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}");
            }

            // Group by medical condition
            var groupByCondition = appointments
                .Join(
                    patients,
                    a => a.PatientId,
                    p => p.Id,
                    (a, p) => new { Appointment = a, Patient = p })
                .Where(ap => ap.Appointment.AppointmentDate >= DateTime.Now && ap.Appointment.AppointmentDate <= DateTime.Now.AddDays(7))
                .GroupBy(ap => ap.Patient.MedicalCondition)
                .Select(group => new
                {
                    MedicalCondition = group.Key,
                    Count = group.Count()
                }).ToList();

            Console.WriteLine("Group of patients in upcoming appointments");
            foreach (var group in groupByCondition)
            {
                Console.WriteLine($"Medical Condition: {group.MedicalCondition}, Count: {group.Count}");
            }

            // Most appointments in last 30 days
            var mostAppointments = appointments
                .Where(a => a.AppointmentDate >= DateTime.Now.AddDays(-30) && a.AppointmentDate <= DateTime.Now)
                .GroupBy(a => a.PatientId)
                .Select(group => new
                {
                    PatientId = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(g => g.Count).ToList();

            var maxCount = mostAppointments.First().Count;
            var patientsWithMostAppointments = mostAppointments
                .Where(ma => ma.Count == maxCount)
                .Join(
                    patients,
                    ma => ma.PatientId,
                    p => p.Id,
                    (ma, p) => p).ToList();

            Console.WriteLine("Patients with most appointments");
            foreach (var patient in patientsWithMostAppointments)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}");
            }

            // Above 60 and their appointments
            var recentAppointments = appointments
                .Join(
                    patients,
                    a => a.PatientId,
                    p => p.Id,
                    (appointment, patient) => new { Appointment = appointment, Patient = patient }
                )
                .Where(ap => ap.Patient.Age > 60)
                .GroupBy(ap => ap.Patient.Id)
                .Select(g => new
                {
                    Patient = g.First().Patient,
                    RecentAppointment = g.OrderByDescending(ap => ap.Appointment.AppointmentDate).First().Appointment
                })
                .Select(res => new
                {
                    PatientName = res.Patient.Name,
                    DoctorName = res.RecentAppointment.DoctorName,
                    AppointmentDate = res.RecentAppointment.AppointmentDate,
                    AppointmentType = res.RecentAppointment.AppointmentType
                })
                .ToList();

            Console.WriteLine("\nPatients over 60 with their most recent appointment:");
            foreach (var entry in recentAppointments)
            {
                Console.WriteLine($"Patient: {entry.PatientName}, Doctor: {entry.DoctorName}, Date: {entry.AppointmentDate}, Type: {entry.AppointmentType}");
            }

        }
    }
}