using System;
using System.Collections.Generic;
using System.Linq;

namespace H07_LabDelegates01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //a car has a brand, a model and a price

            //fill a list with 10 cars,
            //with different models,
            //brands and prices

            List<Car> list = new List<Car>() {
                new Car("Audi", "A1", 12345),
                new Car("Audi", "A2", 23456),
                new Car("Audi", "A3", 34567),
                new Car("FIAT", "500", 9876),
                new Car("FIAT", "Punto", 10987),
                new Car("FIAT", "Panda", 11109),
                new Car("Ferrari", "Testarossa", 111000),
                new Car("Ferrari", "Enzo", 112000),
                new Car("Citroen", "C1", 11000),
                new Car("Citroen", "C2", 21000)
            };
            
            //write a Filter method 
            //that returns a list of cars,
            //given an input list and a condition

            //invoke the Filter method to 
            //filter the expensive cars
            //(for example Price > 30000)
            List<Car> expensive = Filter(list, c=>c.Price>30000);

            printCars(expensive);

            //invoke the Filter method
            //to filter the cars with a specific brand 
            //(for example Brand == "Audi")
            List<Car> audis = Filter(list, brandFilter);

            printCars(audis);

            //invoke the Filter method
            //to filter the cars with a specific model 
            //(for example Model == "500")
            List<Car> fiveHundreds = Filter(list, c => c.Model == "500");

            printCars(fiveHundreds);

            //write a FindFirst method
            //that returns the first occurrence 
            //of an item in a list of cars,
            //given an input list of cars and a condition

            //invoke the FindFirst to get the
            //first car whose model starts with "A"
            Car firstA = FindFirst(list, c=>c.Model.StartsWith("A"));
            printCar(firstA);

            //invoke the FindFirst to get the
            //first car whose price is less than 15000
            Car first15000 = FindFirst(list, c=>c.Price<15000);
            printCar(first15000);

            IEnumerable<Car> audisLinq = 
                list
                .Where(brandFilter)
                .OrderBy(c=>c.Price);
            Console.WriteLine(".....................");
            foreach (Car car in audisLinq) {
                printCar(car);
            }

            IEnumerable<Car> audisLinq2 = 
                list
                .Where(car=>car.Brand=="Audi")
                .OrderByDescending(car=>car.Price);
            Console.WriteLine(".....................");
            foreach (Car car in audisLinq2) {
                printCar(car);
            }

            IEnumerable<Car> audisLinq3 =
                from car in list
                where car.Brand == "Audi"
                orderby car.Price descending
                select car;

            Console.WriteLine(".....................");
            foreach (Car car in audisLinq3) {
                printCar(car);
            }

            IEnumerable<string> models = list
                .Where(car => car.Brand == "Audi")
                .OrderBy(car => car.Price)
                .Select(car => car.Model);
            Console.WriteLine(".....................");
            foreach (string model in models) {
                Console.WriteLine(model);
            }

            Car firstCar = list.FirstOrDefault(car => car.Model == "Audi" && car.Price < 123);

            IEnumerable<string> models2 = from car in list
                                          where car.Brand == "Audi"
                                          orderby car.Price descending
                                          select car.Model;

            Console.WriteLine(".....................");
            foreach (string model in models2) {
                Console.WriteLine(model);
            }

            Console.ReadLine();
        }

        //bool Any(list of car, condition)
        //true if at least one car respects the condition  

        //bool All(list of car, condition)
        //true if all cars respect the condition

            //test the methods first :)

        static void printCars(List<Car> cars) {
            Console.WriteLine("***********");
            foreach (Car c in cars) {
                printCar(c);
            }
            Console.WriteLine("***********");
        }

        static void printCar(Car c) {
            Console.WriteLine($"{c.Brand}\t{c.Model}\t{c.Price}");
        }

        public delegate bool Function(Car car);

        public static List<Car> Filter(List<Car> list, Function function) {
            List<Car> result = new List<Car>();
            foreach (Car item in list) {
                if (function(item))
                    result.Add(item);
            }
            return result;
        }

        public static Car FindFirst(List<Car> list, Function function) {
            foreach (Car item in list) {
                if (function(item))
                    return item;
            }
            return null;
        }

        private static bool brandFilter(Car car) {
            return car.Brand == "Audi";
        }
    }
}
