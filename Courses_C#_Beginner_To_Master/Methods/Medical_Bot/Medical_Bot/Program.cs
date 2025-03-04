using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi, i'm Original NVK. I'm here to help you in your medication");
        Console.WriteLine("Enter your (patient) details");
        string readResult;
        Console.WriteLine("Enter your Name: ");
        readResult = Console.ReadLine();
        Patient patient = new Patient();
        string messageError = "";
        patient.setName(readResult, out messageError);
        Console.WriteLine("Enter your age: ");
        readResult = Console.ReadLine();
        patient.setAge(int.Parse(readResult), out messageError);
        Console.WriteLine("Enter your gender: ");
        readResult= Console.ReadLine();
        patient.setGenger(readResult, out messageError);
        Console.WriteLine("Enter Medical History. Eg: Diabetes. Press Enter for None:");
        readResult = Console.ReadLine();
        patient.setMedicalHistory(readResult, out messageError);
        Console.WriteLine($"Welcome, {patient.getName()}, {patient.getAge()}");
        Console.WriteLine("Which of the following symptoms do you have:\r\n\r\nS1. Headache\r\n\r\nS2. Skin rashes\r\n\r\nS3. Dizziness");
        Console.WriteLine("Enter the symptom code from above list (S1, S2 or S3):");
        readResult=Console.ReadLine();
        patient.setSymptomCode(readResult, out messageError);
        if(patient.getSymptomCode() == "Headache")
        {
            readResult = "Cecacool 50g/1 box";
        }    
        else if(patient.getSymptomCode() == "Skin rashes")
        {
            readResult = "diphenhydramine 50 mg";
        }    
        else
        {
            readResult = "metformin 500 mg";
        }
        patient.setPrescription(readResult, out messageError);
        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        Console.WriteLine(patient.getPrescription());
    }
}