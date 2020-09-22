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
    public partial class Form3201 : Form
    {
        public Form3201()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            try { 
            string input = txtinput.Text;
            int result = int.Parse(input) * 100;
            txtresult.Text = result.ToString();
             
            }
            catch(FormatException ex)
            {
                MessageBox.Show("제대로 숫자를 입력해주세요\n"+  ex.Message);
                txtinput.Text = "";
                txtresult.Text = "";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러가 발생했습니다.\n" + ex.Message);
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
