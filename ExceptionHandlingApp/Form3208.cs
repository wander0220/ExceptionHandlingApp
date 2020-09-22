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
    public partial class Form3208 : Form
    {
        public Form3208()
        {
            InitializeComponent();
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String input = txtinput.Text;
                int result = int.Parse(input) * 100;
                txtresult.Text = result.ToString();
            }
            catch(FormatException exception)
            {
                MessageBox.Show("제대로 숫자를 입력해주세요!/n" + exception.Message);
                txtinput.Text = "";
                txtresult.Text = "";
            }
            catch(Exception exception)
            {   
                MessageBox.Show("에러가 발생했습니다!/n" + exception.Message);
                txtinput.Text = "";
                txtresult.Text = "";
            }
            finally
            {
                txtinput.Focus();
            }
        }
    }
}
