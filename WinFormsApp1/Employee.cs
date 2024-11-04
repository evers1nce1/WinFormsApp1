using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Employee : User //наследование
    {
        public string pass { get; set; }
        public int occupation { get; set; }
        public decimal salary { get; set; } 
        public Employee(string n, string p, int occupation) : base(n)
        {
            pass = p;
            this.occupation = occupation;
        }

        public override decimal Salary()
        {
            return salary;
        }
    }
}
