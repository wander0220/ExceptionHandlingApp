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
    public partial class Form3204 : Form
    {
        public Form3204()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                int result = int.Parse(input) * 100;
                txtResult.Text = result.ToString();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("제대로 숫자를 입력해주세요!\n"+exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";
            }
            catch (Exception exception)
            { 
                MessageBox.Show("우주인이 왔나봐요! 에러 발생!\n" + exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";  
            }
            finally
            {
                txtInput.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
