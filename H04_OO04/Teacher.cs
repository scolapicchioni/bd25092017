using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04 {
    public class Teacher {
        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private decimal _salary;

        public decimal Salary {
            get { return _salary; }
            set { _salary = value; }
        }

        private Course course;

        public Course CurrentlyTeachingCourse {
            get { return course; }
            set { course = value; }
        }

        public Teacher(string name, decimal salary, Course course) {
            Name = name;
            Salary = salary;
            CurrentlyTeachingCourse = course;
        }
    }
}
