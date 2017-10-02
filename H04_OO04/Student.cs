using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04 {
    public class Student {
        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;

        public int StudentId {
            get { return _id ; }
            set { _id = value; }
        }

        private Course course;

        public Course CurrentlyFollowingCourse {
            get { return course; }
            set { course = value; }
        }

        public Student(string name, int id, Course course) {
            Name = name;
            StudentId = id;
            CurrentlyFollowingCourse = course;
        }
    }
}
