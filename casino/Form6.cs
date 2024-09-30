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
    public partial class Form6 : Form
    {
        public Double BalancePlayer;
        Double MoneyForClick = 3;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.BalancePlayer = BalancePlayer;
            form_1.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Хамстер Криминал";
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
            label2.Text = String.Format("Приыбль за клик\n{0:F2} руб.", MoneyForClick);
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BalancePlayer += MoneyForClick;
            label1.Text = String.Format("Баланс\n{0:F2} руб.", BalancePlayer);
        }
    }
}
