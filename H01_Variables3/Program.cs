using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"short.MinValue == {short.MinValue}; short.MaxValue == {short.MaxValue} ");
            Console.WriteLine($"ushort.MinValue == {ushort.MinValue}; ushort.MaxValue == {ushort.MaxValue} ");

            Console.WriteLine();

            Console.WriteLine($"int.MinValue == {int.MinValue}; int.MaxValue == {int.MaxValue} ");
            Console.WriteLine($"uint.MinValue == {uint.MinValue}; uint.MaxValue == {uint.MaxValue} ");

            Console.WriteLine();

            Console.WriteLine($"long.MinValue == {long.MinValue}; long.MaxValue == {long.MaxValue} ");
            Console.WriteLine($"ulong.MinValue == {ulong.MinValue}; ulong.MaxValue == {ulong.MaxValue} ");

            //double x = 5 / 3.0;
            //Console.WriteLine(x);

            ////int i = 5;

            ////long l = i;

            //long l = long.MaxValue;

            ////cast operator
            //int i = (int)l;

            //Console.WriteLine($"i == {i}; l == {l}");

            //string s = l.ToString();

            //int i3 = int.Parse("5");

            ////int favorite = Console.ReadLine();

            //int i4 = ((i3 + i) * 5);

            //bool b1 = true; //false
            //b1 = i4 >= i;
            //b1 = i4 == i;

            //bool b2 = true;
            //bool b3 = false;

            ////b1 = b2 = b3; //!!!!!



            int a = 5;

            //same
            a = a + 10;
            a += 10;

            //same
            a = a + 1;
            a += 1;
            a++;
            ++a;

            a = 5;
            int b;

            b = a++;
            // b == 5; a == 6

            a = 5;
            b = ++a;
            //a == 6; b == 6

            a = 5;
            Console.WriteLine(a++); //5
            Console.WriteLine(a); //6

            a = 5;
            Console.WriteLine(++a); //6
            Console.WriteLine(a); //6








            Console.ReadLine();
        }
    }
}
