using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_14_Contacts_Project
{
    public class Friend : Contact
    {
        public Friend(string name, string phoneNumber) : base(name, phoneNumber) { }

        public override string GetContactType()
        {
            return "Friend";
        }
    }
}