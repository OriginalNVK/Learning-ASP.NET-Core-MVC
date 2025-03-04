using System;
using System.Security.Cryptography;

public class Patient
{
    private string name = "", genger = "", medicalHistory = "", symptomCode = "", prescription = "";
    private int age = 0;
    public string getName()
    {
        return this.name;
    }
    public void setName(string name, out string messageError)
    {
        messageError = "Invalid value of name";
        if(name != null)
        {
            this.name = name;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age, out string messageError)
    {
        messageError = "Invalid age";
        if(age > 0)
        {
            this.age =  age;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }

    public string getGenger()
    {
        return this.genger;
    }

    public void setGenger(string genger, out string messageError)
    {
        messageError = "Invalid genger";
        if(genger != null)
        {
            this.genger = genger;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }

    public string getMedicalHistory()
    {
        return this.medicalHistory;
    }

    public void setMedicalHistory(string medicalHistory, out string messageError)
    {
        messageError = "Invalid medical history";
        if (medicalHistory != null)
        {
            this.medicalHistory = medicalHistory;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }

    public string getSymptomCode()
    {
        if (symptomCode.ToLower() == "s1")
            return "Headache";
        else if(symptomCode.ToLower() == "s2")
        {
            return "Skin rashes";
        }
        else if(symptomCode.ToLower() == "s3")
        {
            return "Dizziness";
        }    
        else
        {
            return "Unknown";
        }
    }

    public void setSymptomCode(string symptomCode, out string messageError)
    {
        messageError = "Invalid symptom code";
        if (symptomCode != null)
        {
            this.symptomCode = symptomCode;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }

    public string getPrescription()
    {
        return this.prescription;
    }

    public void setPrescription(string prescription, out string messageError)
    {
        messageError = "Invalid prescription";
        if (medicalHistory != null)
        {
            this.prescription = prescription;
        }
        else
        {
            Console.WriteLine(messageError);
        }
    }
}
