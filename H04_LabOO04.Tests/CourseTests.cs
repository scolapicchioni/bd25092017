using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H04_LabOO04.Tests {
    [TestClass]
    public class CourseTests {
        [TestMethod]
        public void GivenACourseWithANameOfCourse1_ThenCourseShouldHaveNameEqualToCourse1() {
            string expected = "Course1";
            Course c = new Course(expected);
            Assert.AreEqual(expected, c.Name);
        }


    }
}
