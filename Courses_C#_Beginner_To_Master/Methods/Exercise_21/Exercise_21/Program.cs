
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor
        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        Question question1 = new Question();
        Console.WriteLine(question1.questionText);
        Console.WriteLine(question1.optionA);
        Console.WriteLine(question1.optionB);
        Console.WriteLine(question1.optionC);
        Console.WriteLine(question1.optionD);
        Console.WriteLine(question1.correctAnswerLetter);
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
        Thread.Sleep(250);
        Console.Clear();

        Question question2 = new Question("What is your favorite color?");
        Console.WriteLine(question2.questionText);
        Console.WriteLine(question2.optionA);
        Console.WriteLine(question2.optionB);
        Console.WriteLine(question2.optionC);
        Console.WriteLine(question2.optionD);
        Console.WriteLine(question2.correctAnswerLetter);
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
        Thread.Sleep(250);
        Console.Clear();

        Question question3 = new Question("What is your favorite fruit?", "Banana", "Grape", "Mangosteen", "Pomegranate", 'C');
        Console.WriteLine(question3.questionText);
        Console.WriteLine(question3.optionA);
        Console.WriteLine(question3.optionB);
        Console.WriteLine(question3.optionC);
        Console.WriteLine(question3.optionD);
        Console.WriteLine(question3.correctAnswerLetter);
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
        Thread.Sleep(250);
        Console.Clear();

        Question question4 = new Question("What is your favorite fruit?", "Banana", "Grape", "Mangosteen", "Pomegranate");
        Console.WriteLine(question4.questionText);
        Console.WriteLine(question4.optionA);
        Console.WriteLine(question4.optionB);
        Console.WriteLine(question4.optionC);
        Console.WriteLine(question4.optionD);
        Console.WriteLine(question4.correctAnswerLetter);
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
        //Thread.Sleep(250);

    }
}