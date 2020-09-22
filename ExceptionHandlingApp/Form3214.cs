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
    public partial class Form3214 : Form
    {
        public Form3214()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textInput.Text;
                int result = int.Parse(input) * 100;
                textResult.Text = result.ToString();
                
            } 
            catch (FormatException exception)
            {
                MessageBox.Show("숫자를 입력해주세요.\n" + exception.Message);
                textInput.Text = "";
                textResult.Text = "";
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("에러 발생.\n" + exception.Message);
                textInput.Text = "";
                textResult.Text = "";
               
            }
            finally
            {
                textInput.Focus();
           
            }
        }
    }
}
