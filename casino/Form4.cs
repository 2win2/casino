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

        Color ColorButton = Color.White;

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
                ColorButton = Color.Green;
            }
            else
            {
                MessageBox.Show("Вы нарвались на мину");
                games = 0;
                win = 0;
                label4.Visible = false;
                button28.Visible = false;
                ColorButton = Color.Red;
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

            button3.Text = " "; button3.BackColor = Color.White;
            button4.Text = " "; button4.BackColor = Color.White;
            button5.Text = " "; button5.BackColor = Color.White;
            button6.Text = " "; button6.BackColor = Color.White;
            button7.Text = " "; button7.BackColor = Color.White;
            button8.Text = " "; button8.BackColor = Color.White;
            button9.Text = " "; button9.BackColor = Color.White;
            button10.Text = " "; button10.BackColor = Color.White;
            button11.Text = " "; button11.BackColor = Color.White;
            button12.Text = " "; button12.BackColor = Color.White;
            button13.Text = " "; button13.BackColor = Color.White;
            button14.Text = " "; button14.BackColor = Color.White;
            button15.Text = " "; button15.BackColor = Color.White;
            button16.Text = " "; button16.BackColor = Color.White;
            button17.Text = " "; button17.BackColor = Color.White;
            button18.Text = " "; button18.BackColor = Color.White;
            button19.Text = " "; button19.BackColor = Color.White;
            button20.Text = " "; button20.BackColor = Color.White;
            button21.Text = " "; button21.BackColor = Color.White;
            button22.Text = " "; button22.BackColor = Color.White;
            button23.Text = " "; button23.BackColor = Color.White;
            button24.Text = " "; button24.BackColor = Color.White;
            button25.Text = " "; button25.BackColor = Color.White;
            button26.Text = " "; button26.BackColor = Color.White;
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

            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
            button26.BackColor = Color.White;

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check(0);
            button3.BackColor = ColorButton;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check(1);
            button4.BackColor = ColorButton;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check(2);
            button5.BackColor = ColorButton;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check(3);
            button6.BackColor = ColorButton;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check(4);
            button7.BackColor = ColorButton;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check(5);
            button8.BackColor = ColorButton;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            check(6);
            button9.BackColor = ColorButton;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            check(7);
            button12.BackColor = ColorButton;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            check(8);
            button13.BackColor = ColorButton;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            check(9);
            button14.BackColor = ColorButton;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            check(10);
            button15.BackColor = ColorButton;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            check(11);
            button18.BackColor = ColorButton;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            check(12);
            button10.BackColor = ColorButton;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            check(13);
            button16.BackColor = ColorButton;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            check(14);
            button19.BackColor = ColorButton;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            check(15);
            button20.BackColor = ColorButton;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            check(16);
            button23.BackColor = ColorButton;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            check(17);
            button25.BackColor = ColorButton;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check(18);
            button11.BackColor = ColorButton;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            check(19);
            button17.BackColor = ColorButton;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            check(20);
            button21.BackColor = ColorButton;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            check(21);
            button22.BackColor = ColorButton;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            check(22);
            button24.BackColor = ColorButton;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            check(23);
            button26.BackColor = ColorButton;
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
