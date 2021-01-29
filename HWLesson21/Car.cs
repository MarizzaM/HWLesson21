using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson21
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        private int codan;

        internal int numberOfSteats;

        public Car()
        {
        }

        public Car(string model, string brand, int year, string color, int codan, int numberOfSteats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            this.codan = codan;
            this.numberOfSteats = numberOfSteats;
        }

        public override string ToString()
        {
            return $"\n {Model} {Brand} {Year} \nColor: {Color}";
        }
    }
}
