using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Orders
    {
        public int ID { get; set; }
        public int component { get; set; }
        public int count { get; set; }  
        public int status { get; set; }  
        public decimal price { get; set; }
        public Orders(int i, int c, int co, int s, decimal p) { 
            ID = i;
            component = c;
            count = co;
            status = s;
            price = p;
        }
    }
}
