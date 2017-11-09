using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H08_Events03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            button1.Click += React;
            button1.Click += AlsoReactHere;

            button2.Click += React;
        }

        private void React(object sender, EventArgs e) {
            MessageBox.Show("YO!");
        }

        private void AlsoReactHere(object sender, EventArgs e) {
            MessageBox.Show("hfkdhfgudsilhgj!");
        }
    }
}
