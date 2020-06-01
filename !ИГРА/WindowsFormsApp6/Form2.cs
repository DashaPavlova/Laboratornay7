using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FlappyBird.Form1(); 
            form.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Arcanoid.Form1(); 
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new testing.Form1(); 
            form.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var form = new testing.Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new AppCSharp.Form1();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new Snake.Form1();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new Game_1.FormGame15();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form = new Game_picture.Form1();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new Final.Form1();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var form = new Game_OSU.Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
