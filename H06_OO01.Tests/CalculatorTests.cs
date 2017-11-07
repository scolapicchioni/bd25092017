using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void GivenANewCalculator_WhenAdding21And20And1_ThenTheResultShouldBe42() {
            //GivenANewCalculator
            Calculator calculator = new Calculator();
            //WhenAdding1And2And3
            double result = calculator.Add(21, 20, 1);
            //ThenTheResultShouldBe42
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void GivenANewCalculator_WhenASubtracting48And4And2_ThenTheResultShouldBe42() {
            //GivenANewCalculator
            Calculator calculator = new Calculator();
            //WhenASubtracting48And4And2
            double result = calculator.Subtract(48, 4, 2);
            //ThenTheResultShouldBe42
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void GivenANewCalculator_WhenMultiplying7And3And2_ThenTheResultShouldBe42() {
            //GivenANewCalculator
            Calculator calculator = new Calculator();
            //WhenMultiplying7And3And2
            double result = calculator.Multiply(7, 3, 2);
            //ThenTheResultShouldBe42
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void GivenANewCalculator_WhenADividing42And7And3_ThenTheResultShouldBe2() {
            //GivenANewCalculator
            Calculator calculator = new Calculator();
            //WhenADividing42And7And3
            double result = calculator.Divide(42, 7, 3);
            //ThenTheResultShouldBe2
            Assert.AreEqual(2, result);

            //List<int> list = new List<int>();
            //list.Add(3);
            //list.Add(5);

            //List<bool> list2 = new List<bool>();
            //list2.Add(true);

            //List<Appointment> list3 = new List<Appointment>();
            //list3.Add(new Appointment());
            //list.

        }
    }
}
