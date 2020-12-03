using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Worker(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} руб.";
        }

    }
}
