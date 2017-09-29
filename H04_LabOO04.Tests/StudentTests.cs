using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO04.Tests {
    [TestClass]
    public class StudentTests {
        [TestMethod]
        public void GivenANewStudentWithANumberOf1_ThenTheStudentShouldHaveANumberOf1() {
            Course c = new Course("History");
            Student s = new Student(1, "Mike", c);
            Assert.AreEqual(1, s.Number);
        }

        [TestMethod]
        public void GivenANewStudentWithANameOfMike_ThenTheStudentShouldHaveANameOfMike() {
            Course c = new Course("History");
            Student s = new Student(1, "Mike", c);
            Assert.AreEqual("Mike", s.Name);
        }

        [TestMethod]
        public void GivenANewStudentAndACourseWithANameHistory_ThenTheStudentShouldHaveACourseWithTheNameOfHistory() {
            Course c = new Course("History");
            Student s = new Student(1, "Mike", c);
            Assert.AreEqual(c.Name, s.CurrentlyFollowingCourse.Name);
        }
    }
}
