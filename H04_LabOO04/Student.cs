using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO04 {
    public class Student {
        private int _number;

        public int Number {
            get { return _number; }
            set { _number = value; }
        }


        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private Course course;

        public Course CurrentlyFollowingCourse {
            get { return course; }
            set { course = value; }
        }
        public Student(int number, string name, Course course) {
            Number = number;
            Name = name;
            CurrentlyFollowingCourse = course;
        }
    }
}
