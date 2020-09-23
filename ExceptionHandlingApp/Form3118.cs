﻿using System;
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
    public partial class Form3118 : Form
    {
        public Form3118()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            try
            {
                int result = int.Parse(input) * 100;
                txtResult.Text = result.ToString();
            }
            catch(FormatException exception)
            {
                MessageBox.Show("올바른 숫자를 입력해주세요." + exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";
                txtInput.Focus();
            }catch(Exception exception)
            {
                MessageBox.Show("올바른 숫자를 입력해주세요." + exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";
                txtInput.Focus();
            }

        }

        private void Form3118_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}
