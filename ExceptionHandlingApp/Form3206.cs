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
    public partial class Form3206 : Form
    {
        public Form3206()
        {
            InitializeComponent();
        }

        private void btnResult_Click_TextChanged(object sender, EventArgs e)
        {
            String input = txtInput.Text;
            int result = int.Parse(input) * 100;
            txtResult.Text = result.ToString();
        }
    }
}
