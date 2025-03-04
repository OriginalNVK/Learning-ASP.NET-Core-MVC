using System;
using System.Linq.Expressions;
using College;

namespace OneToOne
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.RollNo = 123;
            student.StudentName = "Scott";
            student.Email = "Scott@gmail.com";

            // Branch Class's object
            Branch br = new Branch();
            br.BranchName = "Computer Science Engineering";
            br.NoOfSemesters = 8;

            student.Branch = br;
        }
    }
}
