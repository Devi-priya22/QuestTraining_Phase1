using System;
using System.Runtime.Remoting.Lifetime;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientDoctorManagement management = new PatientDoctorManagement();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Display Patients");
                Console.WriteLine("4. Display Doctors");
                Console.WriteLine("5. Update Patient");
                Console.WriteLine("6. Update Doctor");
                Console.WriteLine("7. Delete Patient");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var patient = GetPatientData();
                        management.AddPatient(patient);
                        break;

                    case "2":
                        var doctor = GetDoctorData();
                        management.AddDoctor(doctor);
                        break;

                    case "3":
                        management.DisplayPatients();
                        break;

                    case "4":
                        management.DisplayDoctors();
                        break;

                    case "5":
                        try
                        {
                            Console.Write("Enter Patient ID to update: ");
                            int patientIdUpdate = int.Parse(Console.ReadLine());

                            Console.Write("Enter new medical condition: ");
                            string medicalCondition = Console.ReadLine();

                            management.UpdatePatient(patientIdUpdate, medicalCondition);
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Please enter a valid number as Id.");
                        }
                        break;


                    case "6":
                        try
                        {
                            Console.Write("Enter Doctor ID to update: ");
                            int doctorIdToUpdate = int.Parse(Console.ReadLine());
                            Console.Write("Enter new specialization: ");
                            string specialization = Console.ReadLine();
                            management.UpdateDoctor(doctorIdToUpdate, specialization);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number as Id.");
                        }
                        break;
                    case "7":
                        try
                        {
                            Console.Write("Enter Patient ID to delete: ");
                            int patientIdDelete = int.Parse(Console.ReadLine());
                            management.DeletePatient(patientIdDelete);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number as Id.");
                        }
                        break;
                    case "8":
                        try
                        {
                            Console.Write("Enter Doctor ID to delete: ");
                            int doctorIdDelete = int.Parse(Console.ReadLine());
                            management.DeleteDoctor(doctorIdDelete);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number as Id. ");
                        }
                        break;
                    case "9":
                        return;
                }
            }
        }
        private static Patient GetPatientData()
        {
            Patient patient = new Patient();

            Console.Write("Enter Patient Name: ");
            patient.Name = Console.ReadLine();

            Console.Write("Enter Patient Age: ");
            patient.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient Gender: ");
            patient.Gender = Console.ReadLine();

            Console.Write("Enter Medical Condition: ");
            patient.MedicalCondition = Console.ReadLine();

            return patient;
        }

        private static Doctor GetDoctorData()
        {
            Doctor doctor = new Doctor();

            Console.Write("Enter Doctor Name: ");
            doctor.Name = Console.ReadLine();

            Console.Write("Enter Doctor Specialization: ");
            doctor.Specialization = Console.ReadLine();

            return doctor;
        }
    }
}
