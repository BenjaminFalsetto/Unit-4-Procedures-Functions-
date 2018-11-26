/*
 * Created by: Benjami Falsetto
 * Created on: 2018/11/26
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program takes two strings and compares them to see if they're equal
 * then the program tells the user whether the strings are equal or not
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityBenF
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declare local variables
            bool ans;
            string userString1, userString2;

            //get the strings and assign them to their respective variables
            userString1 = this.txtString1.Text;
            userString2 = this.txtString2.Text;

            //convert each string to lowercase
            userString1.ToLower();
            userString2.ToLower();

            //call the compare function
            ans = StringsEqual(userString1, userString2);

            //see if the strings are equal to one another and show message boxes accordingly
            if (ans == true)
            {
                MessageBox.Show("The strings are equal");
            }
            else
            {
                MessageBox.Show("The strings are not equal");
            }
        }

        private bool StringsEqual(string string1, string string2)
        {
            //declare local variables
            bool ans;

            //check to see if the two strings are equal
            if (string1 == string2)
            {
                ans = true;
            }
            else
            {
                ans = false;
            }

            //return the boolean variable
            return ans;
        }
    }
}
