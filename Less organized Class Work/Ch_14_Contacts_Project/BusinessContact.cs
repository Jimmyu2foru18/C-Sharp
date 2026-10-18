using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_14_Contacts_Project
{
    public class BusinessContact : Contact
    {
        public BusinessContact(string name, string phoneNumber) : base(name, phoneNumber) { }

        public override string GetContactType()
        {
            return "Business Contact";
        }
    }
}