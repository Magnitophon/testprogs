using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Treugol
    {
        private
            double a, b, c;
        public Treugol()
        {
            a = 3; b = 4; c = 5;
        }
        public Treugol(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
        }

        public double get_A()
        {
            return a;
        }
        public double get_B()
        {
            return b;
        }
        public double get_C()
        {
            return c;
        }
        
    }
}
