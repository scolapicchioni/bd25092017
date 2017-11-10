using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H08_LabEvents02.Tests {
    [TestClass]
    public class PlayerTests {
        /*
         * A Player has a Name property 
         */
        [TestMethod]
        public void GivenANewPlayer_WhenSettingAName_ThenTheNameShouldBeTheSetValue() {
            //GivenANewPlayer
            Player p1 = new Player();

            //WhenSettingAName
            p1.Name = "Simona";

            //ThenTheNameShouldBeTheSetValue
            Assert.AreEqual("Simona", p1.Name);
        }

        // A Player has a a Play method
        //that returns a random int between 1 and 6.
        [TestMethod]
        public void GivenANewPlayer_WhenPlaying_ThenTheResultShouldBeBetween1and6() {
            //GivenANewPlayer
            Player p1 = new Player();
            //WhenPlaying
            int actual = p1.Play();
            //ThenTheResultShouldBeBetween1and6
            Assert.IsTrue(actual >= 1 && actual <= 6);
        }


        
    }
}
