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

        Single X;
        Single Y;

        int[] poligon = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        double win = 0;

        int games = 0;

        Random r1 = new Random();
        public Form4()
        {
            InitializeComponent();
        }

        private void check(int i)
        {
            if (games == 0)
            {
                MessageBox.Show("Вы не начали игру");
                return;
            }

            if (poligon[i] == -1)
            {
                MessageBox.Show("Вы уже выбирали это поле");
                return;
            }
            else if (poligon[i] == 0)
            {
                win += (X / (24 - Y)) * Y + (win / (24 - Y));
                poligon[i] = -1;
                label4.Text = String.Format("Текущий выйгрыш {0:F2} руб.", win);
            }
            else
            {
                MessageBox.Show("Вы нарвались на мину");
                games = 0;
                win = 0;
                label4.Visible = false;
                button28.Visible = false;
                return;
            }
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

            var number = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);

            if(number == false)
            {
                MessageBox.Show("Некоректное значение суммы ставки");
                return;
            }


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
                return;
            }

            if (X > BalancePlayer)
            {
                MessageBox.Show("Недостаточно средств");
                return;
            }

            if(Y <= 0 )
            {
                MessageBox.Show("Количество мин должно быть больше нуля");
                return;
            }

            if(Y >= 24)
            {
                MessageBox.Show("Количество мин должно быть меньше 24");
                return;
            }
 
            button28.Visible = true;
            label4.Visible = true;
            label4.Text = String.Format("Текущий выйгрыш 0 руб.");
            BalancePlayer -= X;
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            for (int i = 0; i < 24; i++)
            {
                poligon[i] = 0;
            }

            for(int i = 0; i < Y; i++)
            {
                poligon[i] = 1;
            }

            for (int i = 0; i < 24; i++)
            {
                int a = poligon[i];
                int k = r1.Next(0, 24);
                poligon[i] = poligon[k];
                poligon[k] = a;
            }

            games = 1;

            String f = "";
            for (int i = 0; i < 24; i++)
            {
                f += poligon[i];
            }
            label5.Text = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            check(6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            check(7);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            check(8);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            check(9);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            check(10);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            check(11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            check(12);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            check(13);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            check(14);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            check(15);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            check(16);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            check(17);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check(18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            check(19);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            check(20);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            check(21);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            check(22);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            check(23);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BalancePlayer += win;
            games = 0;
            win = 0;
            label4.Visible = false;
            button28.Visible = false;
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
            return;
        }
    }
}
