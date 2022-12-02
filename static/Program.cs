using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statics
{
    public class Program
    {
        static void Main(string[] args)
        {
        //    Emp e1 = new Emp("darshan", 10000);
        //    Emp e2 = new Emp("vishal", 20000);
        //    Emp e3 = new Emp("rahul", 100000);
        //    e1.Calculatesalary();
        //    e2.Calculatesalary();
        //    e3.Calculatesalary();
        //    Console.WriteLine(e1);
        //    Console.WriteLine(e2);
        //    Console.WriteLine(e3);
        //    Console.WriteLine(Emp.TotalCounts());



            Student s1 = new Student("darshan", 45, 56, 76);
            Student s2 = new Student("vishal", 55, 45, 78);
            Console.WriteLine("enter the name ");
            string name = Console.ReadLine();
            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());
            Student s3 = new Student(name, mark1, mark2, mark3);
            s1.CalculateMark();
            s2.CalculateMark();
            s3.CalculateMark();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);



        }
    }
}
