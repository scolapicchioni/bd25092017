using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabSwitch01 {
    class Program {
        static void Main(string[] args) {
            /*
             * An Auto Insurance Program
                •	Example - Write a program to determine the cost 
                of an automobile insurance premium, 
                based on driver's age 
                and the number of accidents that the driver has had.
                •	The basic insurance charge is $500.  
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
            if (age < 18) {
                Console.WriteLine("You're too young to drive!");
            } else {
                Console.WriteLine("How many accidents have you had?");
                int accidents = int.Parse(Console.ReadLine());
                if (accidents >= 6 || accidents < 0) {
                    Console.WriteLine("No insurance for you, mister!");
                } else {
                    int basicCharge = 500;
                    int surcharge = 0;
                    if (age < 25) {
                        surcharge = 100;
                    }
                    switch (accidents) {
                        case 1:
                            surcharge += 50;
                            break;
                        case 2:
                            surcharge += 125;
                            break;
                        case 3:
                            surcharge += 225;
                            break;
                        case 4:
                            surcharge += 375;
                            break;
                        case 5:
                            surcharge += 575;
                            break;
                    }
                    Console.WriteLine($"Your insurance premium is {basicCharge + surcharge}");
                }
            }
            
            
            Console.ReadLine();
        }
    }
}
