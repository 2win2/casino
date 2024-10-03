using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casino
{
    public partial class Form2 : Form
    {
        public Double BalancePlayer;

        int[] BlackNumber = {2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};
        int[] RedNumber = {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};

        Single X;

        Random roulette = new Random();

        private void CheckNumber(int numPlayer)
        {
            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            if (number == false)
            {
                MessageBox.Show("Некорректное значение суммы ставки");
                return;
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }
            int col = roulette.Next(0, 37);
            if (col == 0 && numPlayer == 0)
            {
                BalancePlayer += X * 36;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("0", 0);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 35);
                label6.BackColor = Color.Green;
                return;
            }
            if (BlackNumber.Contains(col) && BlackNumber.Contains(numPlayer) && col == numPlayer)
            {
                BalancePlayer += X * 36;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", col);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 35);
                label6.BackColor = Color.Gray;
                return;
            }
            if (RedNumber.Contains(col) && RedNumber.Contains(numPlayer) && col == numPlayer)
            {
                BalancePlayer += X * 36;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", col);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 35);
                label6.BackColor = Color.Red;
                return;
            }
            else
            {
                BalancePlayer -= X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label2.Text = String.Format("Вы проиграли\n{0:F2} руб.", X);
                if (BlackNumber.Contains(col))
                {
                    label6.Text = String.Format("{0}", BlackNumber[roulette.Next(0, 18)]);
                    label6.BackColor = Color.Gray;
                    return;
                }
                if (RedNumber.Contains(col))
                {
                    label6.Text = String.Format("{0}", RedNumber[roulette.Next(0, 18)]);
                    label6.BackColor = Color.Red;
                    return;
                }
                else
                {
                    label6.Text = String.Format("0");
                    label6.BackColor = Color.Green;
                    return;
                }
            }
        }

        private void CheckColor(int colPlayer)
        {
            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            if (number == false)
            {
                MessageBox.Show("Некорректное значение суммы ставки");
                return;
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            int col = roulette.Next(0, 37);

            if (col == 0 && colPlayer == 0)
            {
                BalancePlayer += X * 36;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("0", 0);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 20);
                label6.BackColor = Color.Green;
                return;
            }
            if (BlackNumber.Contains(col) && colPlayer == 1)
            {
                BalancePlayer += X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", BlackNumber[roulette.Next(0, 18)]);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 0.9);
                label6.BackColor = Color.Gray;
                return;
            }
            if(RedNumber.Contains(col) && colPlayer == 2)
            {
                BalancePlayer += X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", RedNumber[roulette.Next(0, 18)]);
                label2.Text = String.Format("Вы выйграли\n{0:F2} руб.", X * 0.9);
                label6.BackColor = Color.Red;
                return;
            }
            else
            {
                BalancePlayer -= X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label2.Text = String.Format("Вы проиграли\n{0:F2} руб.", X);
                if (BlackNumber.Contains(col))
                {
                    label6.Text = String.Format("{0}", BlackNumber[roulette.Next(0, 18)]);
                    label6.BackColor = Color.Gray;
                    return;
                }
                if(RedNumber.Contains(col))
                {
                    label6.Text = String.Format("{0}", RedNumber[roulette.Next(0, 18)]);
                    label6.BackColor = Color.Red;
                    return;
                }
                else
                {
                    label6.Text = String.Format("0");
                    label6.BackColor = Color.Green;
                    return;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Roulette Wheel";
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            label6.Text = " ";

            label2.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckColor(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckColor(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.BalancePlayer = BalancePlayer;
            form_1.Show();
            Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckNumber(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckNumber(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckNumber(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckNumber(8);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CheckNumber(10);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CheckNumber(11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckNumber(13);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckNumber(15);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CheckNumber(17);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CheckNumber(20);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CheckNumber(22);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CheckNumber(24);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CheckNumber(26);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CheckNumber(28);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CheckNumber(29);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CheckNumber(31);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CheckNumber(33);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CheckNumber(35);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            CheckNumber(1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            CheckNumber(3);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            CheckNumber(5);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CheckNumber(7);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CheckNumber(9);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CheckNumber(12);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CheckNumber(14);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CheckNumber(16);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CheckNumber(18);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            CheckNumber(19);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CheckNumber(21);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            CheckNumber(23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            CheckNumber(25);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CheckNumber(27);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CheckNumber(30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CheckNumber(32);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CheckNumber(34);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CheckNumber(36);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            CheckNumber(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
