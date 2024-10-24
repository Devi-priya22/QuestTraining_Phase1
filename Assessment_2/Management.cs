using System.Collections.Generic;

namespace Assessment
{
    internal abstract class Management
    {
        public List<Patient> Patients = new List<Patient>();
        public List<Doctor> Doctors = new List<Doctor>();
        public int nextPatientId = 1;
        public int nextDoctorId = 1;

        public abstract void AddPatient(Patient patient);
        public abstract void AddDoctor(Doctor doctor);
        public abstract void DisplayPatients();
        public abstract void DisplayDoctors();
        public abstract void UpdatePatient(int patientId, string medicalCondition);
        public abstract void UpdateDoctor(int doctorId, string specialization);
        public abstract void DeletePatient(int patientId);
        public abstract void DeleteDoctor(int doctorId);
    }
}
