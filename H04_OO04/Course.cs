namespace H04_OO04 {
    public class Course {
        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public Course(string name) {
            Name = name;
        }
    }
}
