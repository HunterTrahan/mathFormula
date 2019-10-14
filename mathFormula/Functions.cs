using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFormula
{
    class Functions
    {
        public float BasicQuad (float x)
        {
                float result = x * x + 2 * x - 7;
                Console.WriteLine(result);
                return result;
        }

        public double Quad (float a, float b, float c)
        {
            double result = -b + Math.Sqrt (b * 2 - 4 * a * c / 2 * a);
            Console.WriteLine(result);
            return result;
        }

        public double BasicBlend (float s, float e, float t)
        {
            double result = s + t * (e - s);
            Console.WriteLine(result);
            return result;
        }
    }
}
