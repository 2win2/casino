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
    public partial class Form5 : Form
    {
        public Double BalancePlayer;
       
        Double MoneyForCredit = 10000;

        Double DolgForCredit = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);

            label7.Text = String.Format("Доступно для кредита: {0:F2} руб.", MoneyForCredit);
            label8.Text = String.Format("Долг: {0:F2} руб.", DolgForCredit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.BalancePlayer = BalancePlayer;
            form_1.Show();
            Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
