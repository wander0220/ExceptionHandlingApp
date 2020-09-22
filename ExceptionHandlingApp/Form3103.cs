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
    public partial class Form3103: Form
    {
        public Form3103()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int result = int.Parse(input) * 100;
            txtResult.Text = result.ToString();
        }
    }
}
