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
    public partial class Form3213 : Form
    {
        public Form3213()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                int result = int.Parse(input) * 100;
                txtResult.Text = result.ToString();
            }
            catch (FormatException e1)
            {
                MessageBox.Show("제대로 숫자를 입력해주세요\n" + e1.Message);
                txtInput.Text = "";
                txtResult.Text = "";
            }
            catch (Exception e2) 
            {
                MessageBox.Show("에러가 발생했습니다\n" + e2.Message);
                txtInput.Text = "";
                txtResult.Text = "";
            }
            finally
            {
                txtInput.Focus();
            }
        }
    }
}
