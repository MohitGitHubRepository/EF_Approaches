using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassDataEntities context = new ClassDataEntities();
            ICollection<Students> students = new List<Students>()
            {
                new Students(){StudentName="Champ1",RollNumber="6" },
                 new Students(){StudentName="Champ2",RollNumber="7" },
                  new Students(){StudentName="Champ3",RollNumber="8" },
                   new Students(){StudentName="Champ4",RollNumber="9" }


            };

            context.Classes.Add(new Classes() { ClassName = "Champion", Students = students });
           // context.Classes.Add(new Classes() { ClassName = "Sports" });
            context.Students.Add(new Students() { StudentName = "SportsStudent", RollNumber = "10", Classes = context.Classes.First(a => a.Id == 2) });
            context.SaveChanges();
            Console.ReadKey();
        }
    }
}
