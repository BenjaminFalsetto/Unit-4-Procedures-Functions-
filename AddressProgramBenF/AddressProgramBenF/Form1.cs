using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressProgramBenF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintName(String firstName, String middleName, String lastName)
        {
            MessageBox.Show("Your name is: " + firstName + " " + middleName + " " + lastName);
        }

        public void PrintName(String firstName, String lastName)
        {
            MessageBox.Show("Your name is " + firstName + " " + lastName);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String userFirstName, userMiddleName, userLastName;

            userFirstName = this.txtFirstName.Text;
            userMiddleName = this.txtMiddleName.Text;
            userLastName = this.txtLastName.Text;
            Console.WriteLine("User first name is " + userFirstName);

            if (userFirstName == "")
            {
                MessageBox.Show("Please enter your first name.", "Full Name Program");
            }
            else if (userLastName == "")
            {
                MessageBox.Show("Please enter your last name.", "Full Name Program");
            }
            else if (userMiddleName == "")
            {
                PrintName(userFirstName, userLastName);
            }
            else
            {
                PrintName(userFirstName, userMiddleName, userLastName);
            }
        }
    }
}
