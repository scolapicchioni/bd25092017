using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops05 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program that calculates the number of years 
             * it takes to double a certain amount, given a certain interest rate.
             * For instance if the amount is 1000 
             * and the interest rate is 8 percent 
             * the amount will double in 10 years.
             * Assume that compound interest is applied. 
             * So each subsequent year the interest rate 
             * is applied on the sum of the amount 
             * and the interest of the previous year.
             */

            /*
             * amount 0
             * interest 8
             * 
             *  year | total
             *  0    | 1000
             *  1    | prev + 8% of prev
             *  2    | prev + 8% of prev
             */
            Console.WriteLine("Initial amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Interest rate (%): " );
            double interest = double.Parse(Console.ReadLine()) / 100;

            double goal = amount * 2;
            int years = 0;
            double subTotal = amount;
            while (subTotal < goal) {
                subTotal = subTotal + (subTotal * interest);
                years++;
            }
            Console.WriteLine($"The amount of year necessary to bring {amount} to {goal} with an interest of {interest} is {years}");
            Console.ReadLine();
        }
    }
}
