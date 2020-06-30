using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            if (y == 0)
            {
                this.labelResult.Text = "除数不能为0";
            }
            else
            {
                var z = x / y;
                this.labelResult.Text = z.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.labelResult.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x - y;
            this.labelResult.Text = z.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.labelResult.Text = z.ToString();
           // this.labelResult.Text = this.textBoxOp1.Text + this.textBoxOp2.Text;
        }
    }
}
