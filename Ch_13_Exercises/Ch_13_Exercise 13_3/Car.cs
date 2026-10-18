using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ch_13_Exercise_13_3
{
    internal class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructors
        public Car(string make_p, string model_p, int year_p)
        {
            this.Make = make_p;
            this.Model = model_p;
            this.Year = year_p;
        }

        // ToString method
        public override string ToString()
        {
            return $"Make: {Make} \n\nModel: {Model} \n\nYear: {Year:d}";
        }
    }
}
