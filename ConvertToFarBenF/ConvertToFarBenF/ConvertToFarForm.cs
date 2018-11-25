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
            double farenheit;
            farenheit = ((double)(9) / (double)(5)) * celsius + 32;
            MessageBox.Show("The temperature in farenheit is " + farenheit);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double celsius;
            celsius = double.Parse(txtCelsius.Text);
            ConvertTemperature(celsius);
        }
    }
}
