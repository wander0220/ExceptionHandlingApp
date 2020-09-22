namespace ExceptionHandlingApp
{
    partial class Form3103
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(148, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 28);
            this.txtInput.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(148, 125);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 28);
            this.txtResult.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(123, 171);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(158, 84);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "숫자를 변환해서 100 곱하기";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "숫자를 넣어주세요";
            // 
            // Form3103
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Name = "Form3103";
            this.Text = "Form3103";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label1;
    }
}