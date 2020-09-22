namespace ExceptionHandlingApp
{
    partial class Form3119
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(132, 39);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(159, 25);
            this.textInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "숫자를 넣어주세요!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(93, 102);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(242, 53);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "숫자를 변환해서 100 곱하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(132, 71);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(159, 25);
            this.textResult.TabIndex = 3;
            // 
            // Form3119
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 181);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Name = "Form3119";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox textResult;
    }
}