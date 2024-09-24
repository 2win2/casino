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

        Random roulette = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Roulette Wheel";
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            label5.Text = "Введите сумму ставки";

            label6.Text = " ";

            button1.Text = " ";
            button2.Text = " ";

            button4.Text = "Черный";
            button5.Text = "Красный";
            button6.Text = "Зеленый";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single X;
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

            int ran = roulette.Next(0, 36);

            if (ran == 0)
            {
                BalancePlayer -= X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", ran);
                label6.BackColor = Color.Green;
            }
            else
            {
                Random color = new Random();
                int col = color.Next(0, 2);
                if (col == 0)
                {
                    BalancePlayer += X * 0.9;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Gray;
                }
                else
                {
                    BalancePlayer -= X;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Red;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Single X;
            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            if (number == false)
            {
                MessageBox.Show("Некорректное значение");
                return;
            }

            if(X <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            int ran = roulette.Next(0, 36);

            if (ran == 0)
            {
                BalancePlayer -= X;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", ran);
                label6.BackColor = Color.Green;
            }
            else
            {
                Random color = new Random();
                int col = color.Next(0, 2);
                if (col == 0)
                {
                    BalancePlayer -= X;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Gray;
                }
                else
                {
                    BalancePlayer += X * 0.9;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Red;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Single X;
            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            if (number == false)
            {
                MessageBox.Show("Некорректное значение");
                return;
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            int ran = roulette.Next(0, 36);

            if (ran == 0)
            {
                BalancePlayer += X * 20;
                label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                label6.Text = String.Format("{0}", ran);
                label6.BackColor = Color.Green;
            }
            else
            {
                Random color = new Random();
                int col = color.Next(0, 2);
                if (col == 0)
                {
                    BalancePlayer -= X;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Gray;
                }
                else
                {
                    BalancePlayer -= X;
                    label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
                    label6.Text = String.Format("{0}", ran);
                    label6.BackColor = Color.Red;
                }
            }
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
    }
}
