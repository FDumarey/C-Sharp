using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneButtonedBandit
{
    public partial class Form1 : Form
    {
        int bankRoll;
        Random myRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bankRoll = Convert.ToInt32(lblBank.Text);
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (bankRoll == 0)
            {
                MessageBox.Show("Out of Cash!", "Game Over", MessageBoxButtons.OK);
                this.Close();
            }
            bankRoll--;
            lblBank.Text = bankRoll.ToString();
            btnSpin.Enabled = false;
            timSpin.Enabled = true;
            timDone.Enabled = true;
        }

        private void timSpin_Tick(object sender, EventArgs e)
        {
            picBandit0.Image = ShowImage(myRandom.Next(4));
            picBandit1.Image = ShowImage(myRandom.Next(4));
            picBandit2.Image = ShowImage(myRandom.Next(4));
        }

        private Image ShowImage(int i)
        {
            switch (i)
            {
                case 0:
                    return (picChoice0.Image);
                case 1:
                    return (picChoice1.Image);
                case 2:
                    return (picChoice2.Image);
                case 3:
                    return (picChoice3.Image);
                default:
                    return (null);
            }
        }

        private void timDone_Tick(object sender, EventArgs e)
        {
            int p0, p1, p2;
            int winnings = 0;
            const int jackpot = 3;
            btnSpin.Enabled = true;
            timSpin.Enabled = false;
            timDone.Enabled = false;

            p0 = myRandom.Next(4);
            p1 = myRandom.Next(4);
            p2 = myRandom.Next(4);
            picBandit0.Image = ShowImage(p0);
            picBandit1.Image = ShowImage(p1);
            picBandit2.Image = ShowImage(p2);

            if (p0 == jackpot)
            {
                winnings = 1;
                if (p1 == jackpot)
                {
                    winnings = 3;
                    if (p2 == jackpot)
                    {
                        winnings = 10;
                    }
                }
            }
            else if (p0 == p1)
            {
                winnings = 2;
                if (p1 == p2)
                {
                    winnings = 4;
                }
            }

            bankRoll += winnings;
            lblBank.Text = bankRoll.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ended up with " + bankRoll.ToString() + " points.", "Game Over", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
