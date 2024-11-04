using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Components
    {
        public int id { get; set; }
        public string name { get; set; }
        public int class1 { get; set; }
        public int subclass { get; set; }
        public int group { get; set; }
        public int subgroup { get; set; }
        public int vid { get; set; }


        public Components(int i, string n, int c, int p, int g, int sg, int v)
        {
            id = i;
            name = n;
            class1 = c;
            subclass = p;
            group = g;
            subgroup = sg;
            vid = v;
        }

    }
}
