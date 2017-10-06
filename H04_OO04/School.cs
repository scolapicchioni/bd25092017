using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO04 {
    public class School {
        //private List<Course> courses = new List<Course>();
        private Course[] courses = new Course[20];
        private int count = 0;
        public Course GetCourse(string courseName) {
            Course course = null;
            for (int i = 0; i < count; i++) {
                if (courses[i].Name==courseName) {
                    course = courses[i];
                    break;
                }
            }
            if (course==null) {
                course = new Course(courseName);
                courses[count++] = course;
            }
            return course;
        }
    }
}
