using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentageProgBenF
{
    public partial class frmPercentageProg : Form
    {
        public frmPercentageProg()
        {
            InitializeComponent();
        }
        
        int percentage;

        private void btncCalculatePercentage_Click(object sender, EventArgs e)
        {
            string level;
            int mark;
            level = Convert.ToString(txtLevel.Text);
            mark = ConvertToPercent(level);
            MessageBox.Show("the percentage mark from level " + level + " is " + mark + "%");
        }

        private int ConvertToPercent(String level)
        {

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 75;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;

                default:
                    percentage = -1;
                    break;
            }
            return percentage;
        }
    }
}
