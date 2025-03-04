    using System;

    class Program
    {
        static void Main()
        {
            Employee[] employee = new Employee[5];
            for (int i = 0; i < employee.Length; i++)
            {
                employee[i] = new Employee();
            }
            employee[1].EmpID = "1001";
            employee[1].EmpName = "Nguyen Van Khanh";
            employee[1].SalaryPerHour = 500d;
            employee[1].NoOfWorkingHours = 10;
            employee[1].NetSalary = 10000000d;

            employee[2].EmpID = "1002";
            employee[2].EmpName = "Nguyen Thai Duong";
            employee[2].SalaryPerHour = 400d;
            employee[2].NoOfWorkingHours = 8;
            employee[2].NetSalary = 1000000d;

            employee[3].EmpID = "1003";
            employee[3].EmpName = "Nguyen Phan Duc Khai";
            employee[3].SalaryPerHour = 500d;
            employee[3].NoOfWorkingHours = 14;
            employee[3].NetSalary = 10000000d;

            employee[4].EmpID = "1004";
            employee[4].EmpName = "Van Ho Phuong Ha";
            employee[4].SalaryPerHour = 1000d;
            employee[4].NoOfWorkingHours = 15;
            employee[4].NetSalary = 10000000d;

            employee[0].EmpID = "1005";
            employee[0].EmpName = "Nguyen Van Quoc";
            employee[0].SalaryPerHour = 500d;
            employee[0].NoOfWorkingHours = 19;
            employee[0].NetSalary = 10000000d;

            foreach(Employee x in employee)
            {
                Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                Console.WriteLine("Type of employee: " + Employee.TypeOfEmployee);
                Console.WriteLine("Department Name: " + x.DepartmentName);
                Console.WriteLine("Employee ID: " + x.EmpID);
                Console.WriteLine("Employee's Name: " + x.EmpName);
                Console.WriteLine("Employee' Salary Per Hour: " + x.SalaryPerHour);
                Console.WriteLine("Amout of Hour working of employee: " + x.NoOfWorkingHours);
                Console.WriteLine("Net salary of Employee: " + x.NetSalary);
                Console.WriteLine("Total Salary of Employee: " + (double)x.NoOfWorkingHours * x.SalaryPerHour 
                    + x.NetSalary);
                Console.WriteLine("Press 'no' if you don't want to show the info of next employee");
                string checkChoice = null;
                checkChoice = Console.ReadLine();
                if (checkChoice == "no")
                {
                    Console.WriteLine("The program stop!!!");
                    break;
                }
                Console.Clear();
            }
        }
    }