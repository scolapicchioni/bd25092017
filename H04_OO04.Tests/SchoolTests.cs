using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04.Tests {
    [TestClass]
    public class SchoolTests {
        [TestMethod]
        public void GivenANewSchool_WhenAskingForACourse_ThenSchoolShouldReturnACourse() {
            //GivenANewSchool
            School s = new School();

            //WhenAskingForACourse
            string courseName = "History";
            Course c = s.GetCourse(courseName);

            //ThenSchoolShouldReturnCourseWhoseNameIsTheInput
            Assert.AreEqual(courseName, c.Name);
        }

        [TestMethod]
        public void GivenANewSchool_WhenAskingTwiceForACourse_ThenSchoolShouldReturnTheSameCourse() {
            //GivenANewSchool
            School s = new School();

            //WhenAskingForACourse
            string courseName = "History";
            Course c1 = s.GetCourse(courseName);
            Course c2 = s.GetCourse(courseName);

            //ThenSchoolShouldReturnCourseWhoseNameIsTheInput
            Assert.AreEqual(c1, c2);
        }
    }
}
