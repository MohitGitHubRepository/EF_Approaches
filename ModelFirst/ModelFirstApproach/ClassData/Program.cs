using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassData
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1Container context = new Model1Container();
            //ICollection<Student> students = new List<Student>()
            //{
            //    new Student(){StudentName="Mohit",RollNumber="1" },
            //     new Student(){StudentName="Kretee",RollNumber="2" },
            //      new Student(){StudentName="Pawan",RollNumber="3" },
            //       new Student(){StudentName="Shivam",RollNumber="4" }


            //};

            //context.Classes.Add(new Class() { ClassName = "Science", Students = students });
            // context.Classes.Add(new Class() { ClassName = "Sports" });
            context.Students.Add(new Student() { StudentName = "Sports", RollNumber = "5", Class = context.Classes.First(a => a.Id == 2) });
            context.SaveChanges();
            Console.ReadKey();
        }
    }
}
