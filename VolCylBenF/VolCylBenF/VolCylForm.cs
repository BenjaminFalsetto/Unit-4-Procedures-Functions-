/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/22
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calculates the volume of a cylinder when given the radius and height
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

namespace VolCylBenF
{
    public partial class frmVolCyl : Form
    {
        public frmVolCyl()
        {
            InitializeComponent();
        }

        private void frmVolCyl_Load(object sender, EventArgs e)
        {
            //hide the answer label as soon as the label appears
            lblAns.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double userRadius, userHeight, userVolume;

            //get the values from the user and assign them to the appropriate variables
            userRadius = (double)nudRadius.Value;
            userHeight = (double)nudHeight.Value;

            //call the CalculateVolume function and pass the parameters
            userVolume = CalculateVolume(userRadius, userHeight);

            //assign the answers to a label and make the label visible
            lblAns.Text = String.Format("{0:0.00}", userVolume) +  " centimetres³";
            lblAns.Show();
        }

        private double CalculateVolume(double radius, double height)
        {
            //declare local variables
            double volume;

            //calculate the volume
            volume = Math.PI * Math.Pow(radius, 2) * height;

            //return the volume to the userVolume variable
            return volume;
        }
    }
}
