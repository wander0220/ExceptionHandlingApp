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
    public partial class Form3107 : Form
    {
        public Form3107()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClac_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int result = int.Parse(input) * 100;
            txtResult.Text = result.ToString();

        }
    }
}
