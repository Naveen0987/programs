using System;
using System.Collections.Generic;

public class Patient
{
    public string Name { get; set; }
    public int Urgency { get; set; }

    public Patient(string name, int urgency)
    {
        Name = name;
        Urgency = urgency;
    }
}

public class PriorityQueue
{
    private List<Patient> patients;

    public PriorityQueue()
    {
        patients = new List<Patient>();
    }

    public void Enqueue(Patient patient)
    {
        int index = 0;
        while (index < patients.Count && patients[index].Urgency >= patient.Urgency)
        {
            index++;
        }
        patients.Insert(index, patient);
    }

    public Patient Dequeue()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("No patients in the queue.");
            return null;
        }
        Patient patient = patients[0];
        patients.RemoveAt(0);
        return patient;
    }

    public void DisplayQueue()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("No patients in the queue.");
            return;
        }
        foreach (var patient in patients)
        {
            Console.WriteLine($"Patient: {patient.Name}, Urgency: {patient.Urgency}");
        }
    }

    public bool IsEmpty()
    {
        return patients.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue emergencyQueue = new PriorityQueue();

        emergencyQueue.Enqueue(new Patient("John", 3));
        emergencyQueue.Enqueue(new Patient("Alice", 1));
        emergencyQueue.Enqueue(new Patient("Bob", 2));

        Console.WriteLine("Patients in the emergency queue:");
        emergencyQueue.DisplayQueue();

        Console.WriteLine("\nServing patients:");
        while (!emergencyQueue.IsEmpty())
        {
            Patient nextPatient = emergencyQueue.Dequeue();
            Console.WriteLine($"Now serving: {nextPatient.Name}");
        }
    }
}
