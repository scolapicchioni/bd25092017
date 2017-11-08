using System;
using H07_OO02.Logic;

namespace H07_OO02.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            userInteraction(calculator.Add);
            userInteraction(calculator.Subtract);

            Do("aaa", 222);
            Do(4);
            Do("hi");
            Console.ReadLine();
        }
        delegate double CalculatorMethod(params double[] parameters);
        delegate string CalculatorMethodWithString(params string[] parameters);

        static void Do(string name) { }
        static void Do(int number) { }
        //static void Do(string name, int number) { }
        //static void Do(string city) { }
        static void Do(string city, int postcode) { }


        static void userInteraction(CalculatorMethod calculate) {
            Console.Write("Please enter the first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double n2 = double.Parse(Console.ReadLine());
            double result = calculate(n1, n2);
            Console.WriteLine($"The result is: {result}");
        }

        static void userInteraction(CalculatorMethodWithString calculate) {
            Console.Write("Please enter the first number: ");
            string n1 = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            string n2 = Console.ReadLine();
            string result = calculate(n1, n2);
            Console.WriteLine($"The result is: {result}");
        }
    }
}
