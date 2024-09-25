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
    public partial class Form3 : Form
    {

        public Double BalancePlayer = 1000;
        double kf;

        Random r = new Random(); 
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Ракетка";

            label4.Text = " ";
            label6.Text = " ";

            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.BalancePlayer = BalancePlayer;
            form_1.Show();
            Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single X;
            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);

            if(number == false)
            {
                MessageBox.Show("Некоректное значение коэффициента");
                return;
            }

            Single Y;
            number = Single.TryParse(textBox2.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out Y);

            if (number == false)
            {
                MessageBox.Show("Некоректное значение суммы ставки");
                return;
            }

            if (Y <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
            }

            if (Y > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            int pod = r.Next(1, 1001);

            if (pod >= 0 && pod <= 100) kf = 0;
            if (pod >= 101 && pod <= 250) kf = r.NextDouble() * 0.5;
            if (pod >= 251 && pod <= 500) kf = r.NextDouble() * 2.5;
            if (pod >= 501 && pod <= 700) kf = r.NextDouble() * 5;
            if (pod >= 701 && pod <= 850) kf = r.NextDouble() * 9;
            if (pod >= 851 && pod <= 900) kf = r.NextDouble() * 13;
            if (pod >= 901 && pod <= 920) kf = r.NextDouble() * 20;
            if (pod >= 921 && pod <= 970) kf = r.NextDouble() * 50;
            if (pod >= 971 && pod <= 1000) kf = r.NextDouble() * 100;

            label4.Text = String.Format("{0:F2}", kf);

            if (X <= kf)
            {
                BalancePlayer += Y * X;
            }
            else BalancePlayer -= Y;

            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            label6.Text = String.Format("{0:F2}", kf) + "\n" + label6.Text;

        }
    }
}
