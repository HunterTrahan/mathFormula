using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions Maths = new Functions();

            int x = 14;

            int a = 2;
            int b = 4;
            int c = 6;

            int s = 3;
            int e = 6;
            int t = 12;

            Maths.BasicQuad(x);

            Maths.Quad(a, b, c);

            Maths.BasicBlend(s, e, t);

            Console.ReadLine();
        }
    }
}
