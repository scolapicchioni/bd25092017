using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04.Tests {
    [TestClass]
    public class StudentTests {
        [TestMethod]
        public void GivenANewStudentWhenInitializingWithMario1000HistoryThenTheNameShouldBeMarioAndTheStudentIdShouldBe1000AndTheCourseNameShouldBeHistory() {
            //GivenANewStudent
            //WhenInitializingWithMario1000History
            Course c = new Course("History");
            Student t = new Student("Mario", 1000, c);

            //ThenTheNameShouldBeMario
            Assert.AreEqual("Mario", t.Name);
            //AndTheStudentIdShouldBe1000
            Assert.AreEqual(1000, t.StudentId);
            //AndTheCourseNameShouldBeHistory
            Assert.AreEqual(c, t.CurrentlyFollowingCourse);
        }
    }
}
