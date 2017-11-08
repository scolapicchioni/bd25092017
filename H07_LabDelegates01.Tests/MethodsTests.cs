using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace H07_LabDelegates01.Tests
{
    [TestClass]
    public class MethodsTests
    {
        [TestMethod]
        public void GivenAListOfCars_WhenFiltering_ThenTheReturnValueShouldContainEveryAndOnlyCarsMatchingTheCondition()
        {
            //GivenAListOfCars
            List<Car> list = new List<Car>() {
                new Car("Audi", "A1", 12345),
                new Car("Audi", "A2", 23456),
                new Car("Audi", "A3", 34567),
                new Car("FIAT", "500", 9876),
                new Car("FIAT", "Punto", 10987),
                new Car("FIAT", "Panda", 11109),
                new Car("Ferrari", "Testarossa", 111000),
                new Car("Ferrari", "Enzo", 112000)
            };

            //WhenFiltering
            List<Car> result = Program.Filter(list, brandFilter);

            //ThenTheReturnValueShouldContainEveryAndOnlyCarsMatchingTheCondition
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(list[0], result[0]);
            Assert.AreEqual(list[1], result[1]);
            Assert.AreEqual(list[2], result[2]);

            foreach (var item in result) {
                Assert.AreEqual(true, brandFilter(item));
            }

        }

        private bool brandFilter(Car car) {
            return car.Brand == "Audi";
        }

        [TestMethod]
        public void GivenAListOfCars_WhenFindingFirstCar_ThenTheReturnValueShouldBeTheFirstCarMatchingTheCondition() {
            //GivenAListOfCars
            List<Car> list = new List<Car>() {
                new Car("Audi", "A1", 12345),
                new Car("Audi", "A2", 23456),
                new Car("Audi", "A3", 34567),
                new Car("FIAT", "500", 9876),
                new Car("FIAT", "Punto", 10987),
                new Car("FIAT", "Panda", 11109),
                new Car("Ferrari", "Testarossa", 111000),
                new Car("Ferrari", "Enzo", 112000)
            };

            //WhenFindingFirstCar
            Car result = Program.FindFirst(list, brandFilter);

            //ThenTheReturnValueShouldBeTheFirstCarMatchingTheCondition
            Assert.IsNotNull(result);
            Assert.AreEqual(list[0], result);
            Assert.AreEqual(true, brandFilter(result));
        }
    }
}
