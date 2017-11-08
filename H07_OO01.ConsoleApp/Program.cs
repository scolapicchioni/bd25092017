using System;
using System.Collections.Generic;

namespace H07_OO01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;

            //DoStuff();   

            //Action method = DoStuff;

            //method();

            //Action method2 = AMethodThatReturnsAnInt;
            //Action method2 = AMethodThatAcceptsAnInt;
            //ActionWithAnInt method2 = AMethodThatAcceptsAnInt;
            //ActionThatReturnsAnInt method3 = AMethodThatReturnsAnInt;

            //method2(3);
            //int y = method3();
            //BankAccount b1 = new BankAccount();
            //Action method2 = b1.ExecuteThings;

            //Action method3 = BankAccount.StaticMethod;

            //PrintValue(method3);

            //PrintValue(AMethodThatReturnsAnInt);

            //PrintValue(AMethodThatReturnsARandomInt);

            //TalkToTheUser(Add);

            //TalkToTheUser(Multiply);

            //TalkToTheUser(power);

            //TalkToTheUser((bladi, yada) => (int)Math.Pow(bladi, yada));

            //string[] list = new string[] { "a", "b" };

            //BankAccount[] accs = new BankAccount[] {
            //    new BankAccount("a"),
            //    new BankAccount("b"),
            //    new BankAccount("c")
            //};

            //string a = "a";
            //string b = "a";

            List<BankAccount> accounts = new List<BankAccount>() {
                new BankAccount("a123"),
                new BankAccount("a345"),
                new BankAccount("a126"),
                new BankAccount("a124"),
                new BankAccount("a342"),
                new BankAccount("a128"),
                new BankAccount("a122"),
                new BankAccount("a349"),
                new BankAccount("a126"),
                new BankAccount("a444"),
                new BankAccount("a456"),
                new BankAccount("a188")
            };

            accounts[0].Deposit(100);
            accounts[3].Deposit(100);
            accounts[5].Deposit(100);
            accounts[7].Deposit(100);

            List<BankAccount> accountsStartingWithA1 = filter(accounts, checkIfStartsWithA1);
            List<BankAccount> accountsWithPositiveBalance = filter(accounts, account => account.Saldo > 0);

            Console.ReadLine();

        }

        static bool checkIfStartsWithA1(BankAccount account) {
            return account.AccountNumber.StartsWith("a1");
        }

        delegate bool Function(BankAccount bankAccount);

        static List<BankAccount> filter(List<BankAccount> list, Function method) {
            List<BankAccount> result = new List<BankAccount>();
            foreach (BankAccount item in list) {
                if (method(item)) {
                    result.Add(item);
                }
            }

            return result;
        }


        delegate int MethodToCalculate(int a, int b);

        static int power(int a, int b) {
            return (int)Math.Pow(a, b);
        }

        private static void TalkToTheUser(MethodToCalculate calculate) {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            int result = calculate(x, y);
            Console.WriteLine($"The result is {result}");
        }

        delegate void ActionWithAnInt(int theValue);
        delegate int ActionThatReturnsAnInt();

        private static void PrintValue(ActionThatReturnsAnInt method) {
            int a = method();
            Console.WriteLine(a);
        }


        private static int AMethodThatReturnsAnInt() {
            return 10;
        }

        private static int AMethodThatReturnsARandomInt() {
            return new Random().Next(1,11);
        }

        private static void AMethodThatAcceptsAnInt(int x) {

        }

        private static void DoStuff() {

        }

        private static int Add(int a, int b) {
            return a + b;
        }

        private static int Subtract(int a, int b) {
            return a - b;
        }

        private static int Multiply(int a, int b) {
            return a * b;
        }

        private static int Divide(int a, int b) {
            return a / b;
        }

        
    }
}
