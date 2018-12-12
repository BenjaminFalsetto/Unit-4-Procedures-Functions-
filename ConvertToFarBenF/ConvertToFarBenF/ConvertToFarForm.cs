/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/12/12
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Temperature Converter
 * This program takes user input as degrees celsius and converts it to farenheit
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

namespace ConvertToFarBenF
{
    public partial class frmConvertToFar : Form
    {
        public frmConvertToFar()
        {
            InitializeComponent();
        }

        public void ConvertTemperature(double celsius)
        {
            //declare local variables
            double farenheit;

            //calculate the temperature in farenheit
            farenheit = ((double)(9) / (double)(5)) * celsius + 32;

            //display the temperature to the user
            MessageBox.Show("The temperature in farenheit is " + farenheit);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare local variables
            double celsius;

            //get the temperature in celsius from the user
            celsius = double.Parse(txtCelsius.Text);

            //call ConvertTemperature and pass it the temperature in celsius
            ConvertTemperature(celsius);
        }
    }
}
