using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO04.Tests {
    [TestClass]
    public class TeacherTests {
        [TestMethod]
        public void GivenANewTeacherWithASalaryOf1_ThenTheTeacherShouldHaveASalaryOf1() {
            Course c = new Course("History");
            Teacher t = new Teacher(1, "Mike", c);
            Assert.AreEqual(1, t.Salary);
        }

        [TestMethod]
        public void GivenANewTeacherWithANameOfMike_ThenTheTeacherShouldHaveANameOfMike() {
            Course c = new Course("History");
            Teacher s = new Teacher(1, "Mike", c);
            Assert.AreEqual("Mike", s.Name);
        }

        [TestMethod]
        public void GivenANewTeacherAndACourseWithANameHistory_ThenTheTeacherShouldHaveACourseWithTheNameOfHistory() {
            Course c = new Course("History");
            Teacher s = new Teacher(1, "Mike", c);
            Assert.AreEqual(c.Name, s.CurrentlyTeachingCourse.Name);
        }
    }
}
