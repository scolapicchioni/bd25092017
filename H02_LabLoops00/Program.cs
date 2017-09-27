using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02_LabLoops00 {
    class Program {
        static void Main(string[] args) {
            /*
             * 1) Print the numbers 1 to 10
             */
            Console.WriteLine("***************************");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

            /*
           2) Change # 1 to print the numbers and add them as you go, printing the running total.
           */
            Console.WriteLine("***************************");
            int total = 0;
            for (int i = 1; i <= 10; i++) {
                total += i;
                Console.WriteLine($"{i} - {total}");
            }

            /*
            3) Change #2 to print the sum of all at the end.
            */
            Console.WriteLine("***************************");
            int total2 = 0;
            for (int i = 1; i <= 10; i++) {
                total2 += i;
                Console.WriteLine($"{i} - {total2}");
            }
            Console.WriteLine(total2);

            /*
            4) Change #3 to not print the running total, just the list of numbers and the total
            */
            Console.WriteLine("***************************");
            int total3 = 0;
            for (int i = 1; i <= 10; i++) {
                total3 += i;
                Console.WriteLine($"{i}");
            }
            Console.WriteLine(total3);

            /*
            5) Change #4 to multiply every number by 5 before adding it to the total
            */
            Console.WriteLine("***************************");
            int total4 = 0;
            for (int i = 1; i <= 10; i++) {
                int fiveTimesI = i * 5;
                total4 += fiveTimesI;
                Console.WriteLine($"{i}, {fiveTimesI} - {total4}");
            }
            Console.WriteLine(total4);

            /*
            6) Print the numbers 10 to 1 and then print the total of all these numbers.
            */
            Console.WriteLine("***************************");
            int total5 = 0;
            for (int i = 10; i > 0; i--) {
                total5 += i;
                Console.WriteLine($"{i} - {total5}");
            }

            /*
            7) Print Hello World 5 times
            */
            Console.WriteLine("***************************");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Hello World");
            }

            /*
            8) Repeat 5 times:  123 Hello World
            * Use a loop to print the 1,2,3
            */
            Console.WriteLine("***************************");
            for (int i = 0; i < 5; i++) {
                for (int n = 1; n <= 3; n++) {
                    Console.Write(n);
                }
                Console.WriteLine(" Hello World");
            }

            /*
            9) Print: 
            123 Hello World
            123456 Hello World
            123456789 Hello World
            123456789101112 Hello World
            123456789101112131415 Hello World
            * Use one outer loop to print 5 lines and an inner loop to print the numbers
            */
            Console.WriteLine("***************************");
            for (int outer = 1; outer <= 5; outer++) {
                for (int inner = 1; inner <= outer*3; inner++) {
                    Console.Write(inner);
                }
                Console.WriteLine(" Hello World");
            }

            /*
            10) Reverse the loop above, to print: 
            123456789101112131415 Hello World
            123456789101112 Hello World
            123456789 Hello World
            123456 Hello World
            123 Hello World
            * Use one outer loop to print 5 lines and an inner loop to print the numbers
            */
            Console.WriteLine("***************************");
            for (int outer = 5; outer >= 1; outer--) {
                for (int inner = 1; inner <= outer * 3; inner++) {
                    Console.Write(inner);
                }
                Console.WriteLine(" Hello World");
            }

            /*
            11) Change the inner loop above to print spaces instead of numbers:
                                    Hello World
                               Hello World
                          Hello World
                    Hello World
               Hello World
            * Use one outer loop to print 5 lines and an inner loop to print the numbers
            */
            Console.WriteLine("***************************");
            for (int outer = 5; outer >= 1; outer--) {
                for (int inner = 1; inner <= outer * 3; inner++) {
                    Console.Write(" ");
                }
                Console.WriteLine(" Hello World");
            }

            /* 
            12) Interest Program 
            •	Write a program that calculates the interest that 
                the Canarsie Indians would have accumulated 
                if they had put the $24 that they had received in 1626
                for Manhattan Island in the bank at 5% interest. 
            •	Input - none; all the values are fixed 
            •	Output - Year and Principle 
            •	Other Information - 
            o	Principle is initially 24 
            o	Interest = Interest Rate * Principle 
            o	New Principle = Old Principle + Interest 
            */
            Console.WriteLine("***************************");
            int initialYear = 1626;
            int currentYear = DateTime.Now.Year;
            double total6 = 24;
            double percentInterest = 5/100d;
            for (int i = initialYear; i < currentYear; i++) {
                total6 += (percentInterest * total6);
            }
            Console.WriteLine(total6);

            /*
            13) Write a program that raises 2 to a power of 10 using a loop.
            */
            Console.WriteLine("***************************");
            int total7 = 2;
            for (int i = 1; i < 10; i++) {
                total7 += total7 * 2;
            }

            /*
             * Dice homework: throw 2 dices and check if the total is 9 
             */
            Console.WriteLine("***************************");
            Random gen = new Random();
            int d1 = gen.Next(1, 7);
            int d2 = gen.Next(1, 7);
            int result = d1 + d2;
            if(result == 9)
                Console.Write("YOU WON! ");
            else
                Console.WriteLine("YOU LOSE! ");
            Console.WriteLine($"You threw a {d1} and a {d2} and the total is {result}");

            /*
            14) Change the dice homework to throw the dice up to 20 throws or when the total is 9. Then, print the total number of throws at the end. 
            */
            Console.WriteLine("***************************");
            Random generator = new Random();
            int counter = 0;
            int total8 = 0;
            while (counter<20 && total8!=9) {
                int dice1 = generator.Next(1, 7);
                int dice2 = generator.Next(1, 7);
                counter++;
                total8 += dice1 + dice2;
            }
            Console.WriteLine($"You threw {counter} times");

            /*
            15) Change #14 to consider that a total of 9 before 20 throws is a win, 
            and not reaching a 9 in 20 throws is a loss. 
            Then, play that game 5 times and calculate the wins and losses. 
            Then, calculate the win percentage. 
            */
            Console.WriteLine("***************************");
            int wonGames = 0, lostGames = 0;
            for (int i = 0; i < 5; i++) {
                Random generator2 = new Random();
                int counter2 = 0;
                int total9 = 0;
                while (counter2 < 20 && total9 != 9) {
                    int dice1 = generator.Next(1, 7);
                    int dice2 = generator.Next(1, 7);
                    counter2++;
                    total9 += dice1 + dice2;
                }
                if (total9 == 9)
                    wonGames++;
                else
                    lostGames++;
                Console.WriteLine($"You threw {counter2} times");
            }
            Console.WriteLine($"won {wonGames} times, lost {lostGames} times");

            Console.ReadLine();
        }
    }
}
