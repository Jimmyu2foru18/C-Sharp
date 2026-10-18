using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_13_Exercise_13_3
{
    internal class Repair
    {
        //Propreties
        public string Description { get; set; }
        public decimal Amount { get; set; }
            //Constructor
            public Repair(string description, decimal amount)
            {
                Description = description;
                //oil repair
                Amount = amount;
                //$30
            }
            //To String
            public override string ToString()
            {
                return $"{Description} - ${Amount}";
            }
    }
}

