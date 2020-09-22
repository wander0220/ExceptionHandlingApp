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
    public partial class Form3119 : Form
    {
        public Form3119()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textInput.Text;
            try
            {
                int result = int.Parse(input) * 100;
                textResult.Text = result.ToString();
            }catch (FormatException exception)
            {
                MessageBox.Show("올바른 숫자를 입력해주세요.\n"+exception.Message);
                textInput.Text = "";
                textResult.Text = "";

            }
            catch(Exception exception)
            {
                MessageBox.Show("올바른 값을 입력하지 않았습니다.\n" + exception.Message);
                textInput.Text = "";
                textResult.Text = "";
            }
            finally
            {
                textInput.Focus();

            }
        }

        private void Form3119_Load(object sender, EventArgs e)
        {
            textInput.Focus();
        }
    }
}
