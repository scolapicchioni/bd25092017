using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01Variables4
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOT => !
            //True => False
            //False => True

            int age = 23;

            bool greaterThan18 = age > 18;
            bool lessOrEqualTo18 = !greaterThan18;

            // AND => &&
            // False False => False
            // False True => False
            // True False => False
            // True True => True

            bool condition1 = true;
            bool condition2 = true;

            bool result = age > 18 && condition2;

            // OR => ||
            // False False => False
            // False True => True
            // True False => True
            // True True => True

            result = age > 18 || condition2;

        }
    }
}
