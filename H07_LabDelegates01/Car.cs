using System;
using System.Collections.Generic;
using System.Text;

namespace H07_LabDelegates01
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(string brand, string model, decimal price) {
            Model = model;
            Brand = brand;
            Price = price;
        }
    }
}
