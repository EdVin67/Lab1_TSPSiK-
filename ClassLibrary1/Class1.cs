using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gipotenyza { 

    public class Gipotez
    {
        public int Sum(int a, int b) 
        {
            return (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

    }

    public class Perimeter
    {
        public int c;
        public int Per(int a, int b) 
        {
           c = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return (a + b + c);
        }
    }
}