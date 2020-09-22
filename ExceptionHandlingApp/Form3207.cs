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
    public partial class Form3207 : Form
    {
        public Form3207()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtinput.Text;
                int result = int.Parse(input) * 100;
                txtResult.Text = result.ToString();
                txtinput.Focus();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("숫자를 입력해 주세요\n" + exception.Message);
                txtinput.Text = "";
                txtResult.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("알 수 없는 예외가 발생했습니다.\n" + exception.Message);
                txtinput.Text = "";
                txtResult.Text = "";
            }
            finally
            {
                txtinput.Focus();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
