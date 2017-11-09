using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents01.Tests
{
    [TestClass]
    public class PneumaticPumpTests
    {
        //A Pump has a Turn method with a NuclearReactor parameter
        //The PneumaticPump will reduce the temperature 
        //by one degree if the temperature 
        //is higher than 100 degrees.
        [TestMethod]
        public void GivenANewPneumaticPumpAndANuclearReactorWithTemperatureOf101Degrees_WhenTurnWithANuclearReactor_ThenTheTemperatureShouldDecreaseOf1Degree() {
            //GivenANewPneumaticPumpAndANuclearReactorWithTemperatureOf101Degrees
            NuclearReactor reactor = new NuclearReactor();
            reactor.Temperature = 101;

            PneumaticPump pump = new PneumaticPump();

            //WhenTurnWithANuclearReactorWithTemperatureOf101Degrees
            pump.Turn(reactor);

            //ThenTheTemperatureShouldDecreaseOf1Degree
            Assert.AreEqual(100, reactor.Temperature);
        }

        //A Pump has a Turn method with a NuclearReactor parameter
        //The PneumaticPump will not reduce the temperature 
        //by one degree if the temperature 
        //is lower than 100 degrees.
        [TestMethod]
        public void GivenANewPneumaticPumpAndANuclearReactorWithTemperatureOf80Degrees_WhenTurnWithANuclearReactor_ThenTheTemperatureShouldStayTheSame() {
            //GivenANewPneumaticPumpAndANuclearReactorWithTemperatureOf80Degrees
            NuclearReactor reactor = new NuclearReactor();
            reactor.Temperature = 80;

            PneumaticPump pump = new PneumaticPump();

            //WhenTurnWithANuclearReactorWithTemperatureOf101Degrees
            pump.Turn(reactor);

            //ThenTheTemperatureShouldDecreaseOf1Degree
            Assert.AreEqual(80, reactor.Temperature);
        }
    }
}
