using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H06_OO01.Tests
{
    [TestClass]
    public class PhoneBookTests
    {
        [TestMethod]
        public void GivenANewPhoneBook_ThenTheContactsShouldNotBeNull()
        {
            //GivenANewPhoneBook
            PhoneBook pb = new PhoneBook();
            //ThenTheContactsShouldNotBeNull
            Assert.IsNotNull(pb.Contacts);
        }
    }
}
