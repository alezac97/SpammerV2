using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpammerV2
{
    public partial class SpammerV2 : Form
    {
        public SpammerV2()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = "Spammer attivato con successo";

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "";
            MessageBox.Show("Spammer fermato con successo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            MessageBox.Show("Velocità impostata correttamente su 100 ms");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            MessageBox.Show("Velocità impostata correttamente su 1000 ms");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            MessageBox.Show("Velocità impostata correttamente su 10 ms");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }
    }
}
