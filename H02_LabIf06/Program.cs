using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf06 {
    class Program {
        static void Main(string[] args) {
            /*
             * An Auto Insurance Program
            •	Example - Write a program to determine the cost of 
            an automobile insurance premium, 
            based on driver's age 
            and the number of accidents that the driver has had.
            •		The basic insurance charge is $500.  
            There is a surcharge of $100 if the driver is under 25 
            and an additional surcharge for accidents:
		# of accidents      Accident Surcharge
			1                           50
			2                          125
			3                          225
			4                          375
			5                          575
			6 or more         No insurance
            */

            Console.WriteLine("Age? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("How many accidents have you had?");
            int accidents = int.Parse(Console.ReadLine());

            int basicCharge = 500;
            int surcharge = 0;
            if (age < 25) {
                surcharge = 100;
            }
            if (accidents == 1)
                surcharge += 50;
            else if (accidents == 2)
                surcharge += 125;
            else if (accidents == 3)
                surcharge += 225;
            else if (accidents == 4)
                surcharge += 375;
            else if (accidents == 5)
                surcharge += 575;
            else if (accidents >= 6)
                surcharge += 9999;

            if(surcharge>=9999)
                Console.WriteLine("No insurance for you, mister!");
            else
                Console.WriteLine($"Your inscurance premium is {basicCharge + surcharge}");
            Console.ReadLine();
        }
    }
}
