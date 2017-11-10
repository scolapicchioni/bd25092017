using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace H09_LabMocking01.Tests
{
    [TestClass]
    public class LibraryManagerTests
    {
        [TestMethod]
        public void GivenANewLibraryManagerAndAMemberThatCanBorrow10Books_WhenCalculatingMembershipCosts_ThenTheResultShouldBe15()
        {
            //AndAMemberThatCanBorrow10Books
            LibraryMember member = new LibraryMember() {
                Id = 1,
                MaximumBooks = 10
            };

            //GivenANewLibraryManager
            var store = new Mock<ILibraryStore>();

            store.Setup(s => s.GetMember(It.IsAny<int>())).Returns(member);

            LibraryManager manager = new LibraryManager(store.Object);

            //WhenCalculatingMembershipCosts
            double actual = manager.CalculateMemberShipCost(member.Id);

            //ThenTheResultShouldBe15
            Assert.AreEqual(10 + member.MaximumBooks * 0.5, actual);
        }
    }
}
