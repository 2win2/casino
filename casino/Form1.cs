﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casino
{
    public partial class Form1 : Form
    {
        public Double BalancePlayer = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "1win Casino";

            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button6.Text = " ";
            button5.Text = "Взять 1000 в кредит";

            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            label2.Text = "Roulette Wheel";
            label5.Text = "Ракетка";
            label6.Text = "Мины";

            label4.Text = "Быстрые игры";

            label3.Text = "____________________________________________________________________________________________________________________________________________________________________";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.BalancePlayer = BalancePlayer;
            form_2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form_3 = new Form3();
            form_3.BalancePlayer = BalancePlayer;
            form_3.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BalancePlayer += 1000;
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form_4 = new Form4();
            form_4.BalancePlayer = BalancePlayer;
            form_4.Show();
            Hide();
        }
    }
}
