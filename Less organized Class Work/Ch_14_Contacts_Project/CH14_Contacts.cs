using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_14_Contacts_Project
{
    public partial class CH14_Contacts : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public CH14_Contacts()
        {
            InitializeComponent();
            // Add to combo box
            cboType.Items.Add("Friend");
            cboType.Items.Add("Family");
            cboType.Items.Add("Business Contact");

            // Default
            cboType.SelectedIndex = 0;
        }

        // Add contact button
        private void btnADD_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhone.Text;

            Contact contact;
            switch (cboType.SelectedItem.ToString())
            {
                case "Friend":
                    contact = new Friend(name, phoneNumber);
                    break;
                case "Family":
                    contact = new Family(name, phoneNumber);
                    break;
                case "Business Contact":
                    contact = new BusinessContact(name, phoneNumber);
                    break;
                default:
                    MessageBox.Show("Please select a contact type.");
                    return;
            }

            contacts.Add(contact);
            MessageBox.Show("Contact added successfully.");
        }

        // Remove contact 
        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            if (contacts.Count > 0)
            {
                contacts.RemoveAt(contacts.Count - 1);
                MessageBox.Show("Contact removed successfully.");
            }
            else
            {
                MessageBox.Show("No contacts to remove.");
            }
        }

        // List contacts
        private void btnLIST_Click(object sender, EventArgs e)
        {
            if (contacts.Count == 0)
            {
                MessageBox.Show("No contacts to display.");
                return;
            }

            Console.WriteLine("Listing contacts...");

            // Build the string
            string contactString = "Contacts:\n";
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
                contactString += contact.ToString() + "\n\n";
            }

            MessageBox.Show(contactString, "Contact List");
        }

        //Button to clear
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            cboType.SelectedIndex = -1;
        }
    }
}

