using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    class Program {
        static void Main(string[] args) {
            Person toad = new Person(); //default
            Person waldo = new Person("Luigi");
            Person peach = new Person(44);
            Person wario = new Person("Wario", 45);
            toad.SayHi();
            
            BankAccount b1 = new BankAccount("RABO0174y5yu4jjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj");

            Console.WriteLine(b1.AccountNumber);

            ////b1.Saldo 
            Console.WriteLine(b1.Saldo); //0

            b1.Deposit(100);
            Console.WriteLine(b1.Saldo); //100

            decimal deposited = b1.Deposit(-100);
            Console.WriteLine(b1.Saldo); //STILL 100
            Console.WriteLine($"actually deposited after depositing -100: {deposited}");

            b1.Withdraw(50);
            Console.WriteLine(b1.Saldo); //50

            b1.Withdraw(-50);
            Console.WriteLine(b1.Saldo); //STILL 50

            decimal withdrawn = b1.Withdraw(2000);
            Console.WriteLine($"Saldo after trying to withdraw 2000: {b1.Saldo}"); //0
            Console.WriteLine($"actually withdrawn: {withdrawn}"); //50


            //create a customer
            Customer mario = new Customer();
            //assign a name longer than 50 letters
            mario.Name = "123456789012345678901234567890123456789012345678901234567890";
            //verify that the name is 50 letters
            bool ok = mario.Name.Length == 50;
            Console.WriteLine(ok);

            //create a customer
            Customer luigi = new Customer();
            //assign a name shorter than 50 letters
            luigi.Name = "Luigi";
            //verify that the name is equal to the assigned value
            ok = luigi.Name == "Luigi";
            Console.WriteLine(ok);

            Console.ReadLine();
        }
    }
}
