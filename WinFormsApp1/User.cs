using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1
{
    abstract class User //базовый класс
    {
        public string name { get; set; }

        public abstract decimal Salary();
        public User(string n) {
            name = n;
                }
    }
}
