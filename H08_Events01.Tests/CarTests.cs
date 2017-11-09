using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace H08_Events01.Tests
{
    [TestClass]
    public class CarTests
    {

        [TestMethod]
        public void GivenANewCar_WhenColorChanges_ThenAnEventShouldBeRaisedWithTheNewColor()
        {
            //GivenANewCar
            Car c = new Car();
            ConsoleColor actual = ConsoleColor.Black;

            c.ColorChanged += color => {
                actual = color;
            };
            

            //WhenColorChanges
            c.Color = ConsoleColor.Red;

            //ThenAnEventShouldBeRaisedWithTheNewColor
            Assert.AreEqual(ConsoleColor.Red, actual);
        }
        

    }
}
