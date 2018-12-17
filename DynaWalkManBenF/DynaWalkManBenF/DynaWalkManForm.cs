/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/12/14
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Dynamic Walking man
 * This program changes images to make a figure seem like it's walking when dynamicly
 * created picture boxes are clicked
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
using System.Threading;

namespace DynaWalkManBenF
{
    public partial class DynaWalkManForm : Form
    {
        public DynaWalkManForm()
        {
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            //generate each picture box on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }
        
        private void btnStart_Clicked(object sender, EventArgs e)
        {
            GeneratePictureBoxes();
            this.lblInstructions.Show();
        }

        private void GeneratePictureBox(int x, int y)
        {
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            tmpPicMan.Location = pntPic;

            tmpPicMan.Image = Properties.Resources.walk1;

            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                pictureFrameCounter++;
                this.Refresh();
                Thread.Sleep(100);
            }
        }
    }
}
