using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01.Tests
{
    [TestClass]
    public class PhoneTests
    {
        [TestMethod]
        public void GivenANewPhone_ThenACalculatorShouldBeFound() {
            Phone phone = new Phone();
            Calculator calculator = phone.Apps.FirstOrDefault<Calculator>();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void GivenANewPhone_ThenAPhoneBookShouldBeFound() {
            Phone phone = new Phone();
            PhoneBook pb = phone.Apps.FirstOrDefault<PhoneBook>();
            Assert.IsNotNull(pb);
        }

        [TestMethod]
        public void GivenANewPhone_ThenACalendarShouldBeFound() {
            Phone phone = new Phone();
            Calendar calendar = phone.Apps.FirstOrDefault<Calendar>();
            Assert.IsNotNull(calendar);
        }
    }
}
