using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_14_Contacts_Project
{
    public abstract class Contact
    {
        // Properties
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor
        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public abstract string GetContactType();

        // Override ToString
        public override string ToString()
        {
            return $"Name: {Name}\nPhone Number: {PhoneNumber}\nType: {GetContactType()}";
        }
    }
}