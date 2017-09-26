using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabIf09 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program that reads a date from the user in numeric form.  
             * For example, February 17, 2003 would be entered 
             * as the three integers 2, 17, and 2003.  
            Your program must then determine if the date is a “valid” date.  
            Use the following information to determine if the date is valid:  
            January, March, May, July, August, October, and December all have 31 days.  
            April, June, September, and November all have 30 days.  
            February has 28 days in a non-leap year and 29 days in a leap year.  
            Echo the input and print either “valid date” or “invalid date” as output.
            */

            Console.WriteLine("Year?");
            int year = int.Parse(Console.ReadLine());
            bool leap = false;
            if (year % 4 == 0) {
                leap = true;
                if (year % 100 == 0) {
                    leap = false;
                    if (year % 400 == 0) {
                        leap = true;
                    }
                }
            }

            Console.WriteLine("Month? (1/12)");
            int month = int.Parse(Console.ReadLine());

            if (month > 12 || month < 1) {
                Console.WriteLine("Not a valid date!");
            } else {
                int acceptedMaxDay = 31;
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8) {
                    acceptedMaxDay = 31;
                } else {
                    if (month == 2) {
                        if (leap) {
                            acceptedMaxDay = 29;
                        } else {
                            acceptedMaxDay = 28;
                        }
                    } else {
                        acceptedMaxDay = 30;
                    }
                }
                Console.WriteLine($"Day (1/{acceptedMaxDay})?");
                int day = int.Parse(Console.ReadLine());
                if (day >= 1 && day <= acceptedMaxDay) {
                    Console.WriteLine("valid");
                } else {
                    Console.WriteLine("Invalid date!");
                }
            }
            Console.ReadLine();
        }
    }
}
