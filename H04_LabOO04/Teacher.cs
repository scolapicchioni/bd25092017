using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO04 {
    public class Teacher {
        private decimal _salary;

        public decimal Salary{
            get { return _salary; }
            set { _salary = value; }
        }


        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private Course course;

        public Course CurrentlyTeachingCourse {
            get { return course; }
            set { course = value; }
        }
        public Teacher(int number, string name, Course course) {
            Salary = number;
            Name = name;
            CurrentlyTeachingCourse = course;
        }
    }
}
