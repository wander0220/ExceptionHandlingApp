namespace ExceptionHandlingApp
{
    partial class Form3107
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClac = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(115, 110);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(152, 25);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "숫자를 입력해주세요!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClac
            // 
            this.btnClac.Location = new System.Drawing.Point(97, 155);
            this.btnClac.Name = "btnClac";
            this.btnClac.Size = new System.Drawing.Size(202, 53);
            this.btnClac.TabIndex = 2;
            this.btnClac.Text = "숫자로 변환해서 100곱하기";
            this.btnClac.UseVisualStyleBackColor = true;
            this.btnClac.Click += new System.EventHandler(this.btnClac_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(115, 69);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(152, 25);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form3107
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 258);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Name = "Form3107";
            this.Text = "Form3107";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClac;
        private System.Windows.Forms.TextBox txtInput;
    }
}