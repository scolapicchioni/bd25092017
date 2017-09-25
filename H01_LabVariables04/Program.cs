using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a C# Sharp program that takes the radius of a circle as input 
                and calculates the perimeter and area of the circle. 
                One hint: C# contains a constant for PI: Math.PI that you can use for that value.

                Perimeter = twice the radius multiplied by PI
                Area = radius squared multiplied by PI
             */

            Console.Write("Radius: ");
            string userRadius = Console.ReadLine();
            double radius = double.Parse(userRadius);

            double area = radius * radius * Math.PI;
            double perimeter =  radius * 2 * Math.PI;
            
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");

            Console.ReadLine();
        }
    }
}
