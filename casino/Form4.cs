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
    public partial class Form4 : Form
    {
        public Double BalancePlayer;

        Random r1 = new Random();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Мины";

            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            button1.Text = " ";
            button2.Text = " ";

            label2.Text = "Введите сумму ставки";

            label3.Text = "Введите количество мин";

            button27.Text = "Старт";

            label4.Text = " ";

            button28.Text = "Забрать выйгрыш";
            button28.Visible = false;

            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button10.Text = " ";
            button11.Text = " ";
            button12.Text = " ";
            button13.Text = " ";
            button14.Text = " ";
            button15.Text = " ";
            button16.Text = " ";
            button17.Text = " ";
            button18.Text = " ";
            button19.Text = " ";
            button20.Text = " ";
            button21.Text = " ";
            button22.Text = " ";
            button23.Text = " ";
            button24.Text = " ";
            button25.Text = " ";
            button26.Text = " ";
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.BalancePlayer = BalancePlayer;
            form_1.Show();
            Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Single X;

            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);

            if(number == false)
            {
                MessageBox.Show("Некоректное значение суммы ставки");
                return;
            }

            Single Y;

            number = Single.TryParse(textBox2.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out Y);

            if (number == false)
            {
                MessageBox.Show("Некоректное значение количества мин");
                return;
            }

            if (X <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
