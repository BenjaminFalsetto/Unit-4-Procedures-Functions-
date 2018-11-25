using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefBenF
{
    public partial class frmPassByRefBenF : Form
    {
        Random randNumGen = new Random();

        public frmPassByRefBenF()
        {
            InitializeComponent();
        }

        //declare global variables
        Random randNumberGenerator = new Random();

        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            const int MAX_NUM_CARDS = 3;

            int aRandomNumber;

            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}
5