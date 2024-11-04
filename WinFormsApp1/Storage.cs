using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Storage //класс склада
    {
        public int id { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public Storage(int i, int c, decimal p) { 
            id = i;
            count = c;
            price = p;
        }
    }
}
