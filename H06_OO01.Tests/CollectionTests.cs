using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01.Tests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod]
        public void GivenANewContactsCollection_WhenAddingAContact_ThenTheCountShouldBe1() {
            Collection<Contact> cc = new Collection<Contact>();
            cc.Add(new Contact());
            Assert.AreEqual(1, cc.Count);
        }
    }
}
