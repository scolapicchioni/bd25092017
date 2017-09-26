using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_IfAndLoops_02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What's your favorite day?");
            int day = int.Parse(Console.ReadLine());

            switch (day) 
            {
                case 1: //if (day == 1)
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Monday??? WHY?!?!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Tuesday??? ARE YOU SURE?!?!");
                    break;
                case 3:
                case 4:
                case 5: //if(day == 3 || day == 4 || day == 5)
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Same message here...");
                    break;
                default: //else
                    Console.WriteLine("ok...");
                    break;
            }
        }
    }
}
