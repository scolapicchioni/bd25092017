using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance02 {
    class Program {
        static void Main(string[] args) {
            /*
             * A Control has a Top, Left, Width, Height, Color, BackgroundColor and Text properties. 
             * A Control can Draw itself.
             * Implement two types of Controls: a TextBox and a Label
             * A Label draws itself by printing its text in its color
             * A TextBox draws itself by printing its text surrounded by a border
             * A TextBox adds an Input method
             * The Input method reads an input from the console and sets its Text property
             * A Form contains a collection of Controls
             * A Form Draws itself by drawing all its controls
             * 
             * Write an application that creates an instance new Form
             * Add two Label and a TextBox to the form Controls collection
             * Set the top, left, width, height, backgroundcolor and color of each control 
             * Set the text of the first label to : What's your name?
             * Draw the form
             * Input the textbox 
             * Set the text of the second label to: "Hello" + the text of the textbox 
             */

            //Write an application that creates an instance new Form
            Form f1 = new Form();

            // Add two Label and a TextBox to the form Controls collection
            Label label1 = new Label();
            Label label2 = new Label();
            TextBox textbox1 = new TextBox();

            f1.Controls.Add(label1);
            f1.Controls.Add(label2);
            f1.Controls.Add(textbox1);

            // * Set the top, left, width, height, backgroundcolor and color of each control
            label1.Top = 3;
            label1.Left = 2;
            label1.Width = 20;
            label1.Height = 3;
            label1.Color = ConsoleColor.Yellow;
            label1.BackgroundColor = ConsoleColor.Blue;

            label2.Top = 10;
            label2.Left = 2;
            label2.Width = 20;
            label2.Height = 3;
            label2.Color = ConsoleColor.Cyan;
            label2.BackgroundColor = ConsoleColor.Magenta;

            textbox1.Top = 3;
            textbox1.Left = 24;
            textbox1.Width = 20;
            textbox1.Height = 3;
            textbox1.Color = ConsoleColor.Green;
            textbox1.BackgroundColor = ConsoleColor.Red;
            
            // * Set the text of the first label to: What's your name?
            label1.Text = "What's your name?";

            //* Draw the form
            f1.Draw();

            //  *Input the textbox
            textbox1.Input();

            //  *Set the text of the second label to: "Hello" + the text of the textbox
            label2.Text = $"Hello {textbox1.Text}";

            Console.ReadLine();
        }
    }
}
