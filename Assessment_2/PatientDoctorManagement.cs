using System;

namespace Assessment
{
    internal class PatientDoctorManagement : Management
    {
        public override void AddPatient(Patient patient)
        {
            patient.Id = nextPatientId++;
            Patients.Add(patient);
            Console.WriteLine("Patient added successfully.");
        }

        public override void AddDoctor(Doctor doctor)
        {
            doctor.Id = nextDoctorId++;
            Doctors.Add(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        public override void DisplayPatients()
        {
            Console.WriteLine("Patients List:");
            foreach (var patient in Patients)
            {
                Console.WriteLine($"ID: {patient.Id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Medical Condition: {patient.MedicalCondition}");
            }
        }

        public override void DisplayDoctors()
        {
            Console.WriteLine("Doctors List:");
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}, Patient ID: {doctor.PatientId}");
            }
        }

        public override void UpdatePatient(int patientId, string medicalCondition)
        {
            foreach (var patient in Patients)
            {
                if (patient.Id == patientId)
                {
                    patient.MedicalCondition = medicalCondition;
                    Console.WriteLine("Patient's medical condition updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Patient not found."); 
        }

        public override void UpdateDoctor(int doctorId, string specialization)
        {
            foreach (var doctor in Doctors)
            {
                if (doctor.Id == doctorId)
                {
                    doctor.Specialization = specialization;
                    Console.WriteLine("Doctor's specialization updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Doctor not found."); 
        }
        public override void DeletePatient(int patientId)
        {
            for (int i = 0; i < Patients.Count; i++)
            {
                if (Patients[i].Id == patientId)
                {
                    Patients.RemoveAt(i);
                    Console.WriteLine("Patient record deleted successfully.");
                    return; 
                }
            }
            Console.WriteLine("Patient not found."); 
        }

        public override void DeleteDoctor(int doctorId)
        {
            for (int i = 0; i < Doctors.Count; i++)
            {
                if (Doctors[i].Id == doctorId)
                {
                    Doctors.RemoveAt(i); 
                    Console.WriteLine("Doctor record deleted successfully.");
                    return; 
                }
            }
            Console.WriteLine("Doctor not found."); 
        }
    }
}
