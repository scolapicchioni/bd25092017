using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using H04_OO04;

namespace H04_OO04.Tests {
    [TestClass]
    public class CourseTests {
        [TestMethod]
        public void GivenANewCourseWhenInitializingWithHistoryThenTheNameShouldBeHistory() {
            string expected = "Cooking";
            //GivenANewCourse
            //WhenInitializingWithHistory

            Course c = new Course(expected);

            //ThenTheNameShouldBeHistory
            Assert.AreEqual(expected, c.Name);

        }
    }
}
