using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void but3109_Click(object sender, EventArgs e)
        {
            Form form = new Form3109();
            form.Show();
        }

        private void btn3102_Click(object sender, EventArgs e)
        {
            Form form = new Form3102();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form3118();
            form.Show();

        }

        private void btn3103_Click(object sender, EventArgs e)
        {
            Form form = new Form3103();
            form.Show();
        }

        private void btn3107_Click(object sender, EventArgs e)
        {
            Form form = new Form3107();
            form.Show();
        }

        private void btn3119_Click(object sender, EventArgs e)
        {
            Form form = new Form3119();
            form.Show();
        }


        private void btn3110_Click(object sender, EventArgs e)
        {
            Form form = new Form3110();
            form.Show();
        }

        private void btn3105_Click(object sender, EventArgs e)
        {
            Form form = new Form3105();
            form.Show();
        }
        
        private void btn3199_Click(object sender, EventArgs e)
        {
            Form form = new Form3199();
            form.Show();        
        }

        private void btn3206_Click(object sender, EventArgs e)
        {
            Form form = new Form3206();
            form.Show();
        }
    }
}
