using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        int loopCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random myRandom = new Random();
            int lowNumber = Convert.ToInt16(textBoxLow.Text),
                highNumber = Convert.ToInt16(textBoxHigh.Text) + 1;

            int theNumber = myRandom.Next(lowNumber, highNumber);

            MessageBox.Show("Your random number is: " + theNumber);

        }

        private void buttonLoopUntil_Click(object sender, EventArgs e)
        {
            loopCounter = 0;
            Random myRandomForLoop = new Random();
            int lowNumber = Convert.ToInt16(textBoxLow.Text),
                highNumber = Convert.ToInt16(textBoxHigh.Text) + 1; // Added 1 to allow the full maximum number to be in the list of possible numbers

            int generatedNumber = myRandomForLoop.Next(lowNumber, highNumber);
            int desiredNumber = Convert.ToInt16(textBoxLoopUntil.Text);

            // Bad user input handling
            if (desiredNumber < lowNumber)
            {
                MessageBox.Show("The number is below the minimum range");
                return;
            }
            else if (desiredNumber > highNumber - 1)
            {
                MessageBox.Show("The number is above the maximum range");
                return;
            }

            //MessageBox.Show("Past error checking");


            while (generatedNumber != desiredNumber)
            {
                generatedNumber = myRandomForLoop.Next(lowNumber, highNumber);
                //MessageBox.Show("The generated number is: " + generatedNumber);
                loopCounter++;
                labelLoopCount.Text = loopCounter.ToString();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Matt Gabiou on 8-15-13");
        }
    }
}
