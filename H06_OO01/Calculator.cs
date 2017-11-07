using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class Calculator : App
    {
        //Add(1,2,3)
        //Add(1.5,2,7,9,4,2,2)
        
        //double[] list = new double[4] {4,8,2,3};
        //Add(list)
        public double Add(params double[] numbers) {
            double total = 0;
            foreach (double item in numbers) {
                total += item;
            }
            return total;
        }

        public double Subtract(params double[] numbers) {
            double total = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                total -= numbers[i];
            }
            return total;
        }

        public double Multiply(params double[] numbers) {
            double total = 1;
            for (int i = 0; i < numbers.Length; i++) {
                total *= numbers[i];
            }
            return total;
        }

        public double Divide(params double[] numbers) {
            double total = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                total /= numbers[i];
            }
            return total;
        }

        public override void Start() {
           
        }
    }

}
