using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H08_LabEvents01.Tests
{
    [TestClass]
    public class NuclearReactorTests {
        // NuclearReactor can split atoms, 
        // but everytime it splits them, 
        // its temperature increases by one degree.
        [TestMethod]
        public void GivenANewNuclearReactor_WhenSplitting_ThenTemperatureShouldIncreaseBy1()
        {
            //GivenANewNuclearReactor
            NuclearReactor fukushima = new NuclearReactor();

            int prev = fukushima.Temperature;

            //WhenSplitting
            fukushima.Split();

            int current = fukushima.Temperature;

            //ThenTemperatureShouldIncreaseBy1
            Assert.AreEqual(1, current - prev);

        }

        //it has an alarm that goes on 
        //everytime its temperature increases
        [TestMethod]
        public void GivenANewNuclearReactor_WhenTemperatureIncreases_ThenAlarmGoes() {
            //GivenANewNuclearReactor
            NuclearReactor fukushima = new NuclearReactor();

            NuclearReactor eventSource = null;

            bool alarmHandled = false;
            //ThenAlarmGoes
            fukushima.Alarm += (r) => {
                eventSource = r;
                alarmHandled = true;
            };

            //WhenTemperatureIncreases
            fukushima.Split();
            
            Assert.IsTrue(alarmHandled);
            Assert.AreEqual(fukushima, eventSource);
        }

    }
}
