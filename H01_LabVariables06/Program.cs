using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01_LabVariables06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Vraag op een nummer en print "True" 
            als het nummer een meervoud van 3 is
            */
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} is a multiple of 3: {number % 3 == 0}");
            Console.ReadLine();
        }
    }
}
