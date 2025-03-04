using System;
using System.Runtime.InteropServices;

class program
{
    static void Main()
    {
        Console.WriteLine("***************** Original NVK Bank *******************");
        string userName = null, password = null;
        while (true)
        {
            Console.Write("Enter the user name: ");
            userName = Console.ReadLine();
            if (userName != "") break;
        }
        while (true)
        {
            Console.Write("Enter the password: ");
            password = Console.ReadLine();
            if (password != "") break;
        }
        int mainMenuChoice = 0;
        if (userName != "" && password != "")
        {
            do
            {
                Console.WriteLine("*********** Main Menu **************");
                Console.WriteLine("* 1. Customer Service              *");
                Console.WriteLine("* 2. Account Service               *");
                Console.WriteLine("* 3. Banking to another account    *");
                Console.WriteLine("* 4. View account balance          *");
                Console.WriteLine("* 0. Exit                          *");
                Console.WriteLine("************************************");
                Console.Write("Enter your choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (mainMenuChoice)
                {
                    case 1: customerService(); Console.Clear(); break;
                    case 2: accountService(); Console.Clear(); break;
                    case 3: Console.WriteLine("The feature is innovation"); 
                            Console.ReadKey();
                            Console.Clear(); 
                            break;
                    default: Console.WriteLine("The feature is innovation"); 
                             Console.ReadKey();
                             Console.Clear(); 
                             break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid account");
        }
        Console.WriteLine("Thank you!. See you again");
    }
    static void customerService()
    {
        int customerMenuChoice = 0;
        do
        {
            Console.WriteLine("*********** Customer Menu **************");
            Console.WriteLine("* 1. Add customer to database          *");
            Console.WriteLine("* 2. Delete customer in database       *");
            Console.WriteLine("* 3. Update customer in database       *");
            Console.WriteLine("* 0. Back to Main Menu                 *");
            Console.WriteLine("****************************************");
            Console.Write("Enter your choice: ");
            customerMenuChoice = System.Convert.ToInt32(Console.ReadLine());
        } while (customerMenuChoice != 0);
    }
    static void accountService()
    {
        int accountMenuChoice = 0;
        do
        {
            Console.WriteLine("*********** Account Menu **************");
            Console.WriteLine("* 1. Add account to database          *");
            Console.WriteLine("* 2. Delete account in database       *");
            Console.WriteLine("* 3. Update account in database       *");
            Console.WriteLine("* 0. Back to Main Menu                *");
            Console.WriteLine("***************************************");
            Console.Write("Enter your choice: ");
            accountMenuChoice = System.Convert.ToInt32(Console.ReadLine());
        } while (accountMenuChoice != 0);
    }
}