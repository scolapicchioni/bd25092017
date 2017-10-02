using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04.Tests {
    [TestClass]
    public class TeacherTests {
        [TestMethod]
        public void GivenANewTeacherWhenInitializingWithMario1000HistoryThenTheNameShouldBeMarioAndTheSalaryShouldBe1000AndTheCourseNameShouldBeHistory() {
            //GivenANewTeacher
            //WhenInitializingWithMario1000History
            //Teacher t = new Teacher("Mario", 1000, "History");

            Course c = new Course("History");
            Teacher t = new Teacher("Mario", 1000, c);

            //ThenTheNameShouldBeMario
            Assert.AreEqual("Mario", t.Name);
            //AndTheSalaryShouldBe1000
            Assert.AreEqual(1000, t.Salary);
            //AndTheCourseNameShouldBeHistory
            Assert.AreEqual(c, t.CurrentlyTeachingCourse);

        }
    }
}
