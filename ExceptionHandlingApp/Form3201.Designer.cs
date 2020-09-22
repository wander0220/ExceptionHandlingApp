namespace ExceptionHandlingApp
{
    partial class Form3201
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(55, 76);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(177, 28);
            this.txtinput.TabIndex = 0;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(55, 124);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(177, 28);
            this.txtresult.TabIndex = 1;
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(72, 188);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(128, 79);
            this.btnresult.TabIndex = 2;
            this.btnresult.Text = "결과보기";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "숫자를 입력해주세요!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtinput);
            this.Name = "Form3201";
            this.Text = "Form3201";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Label label1;
    }
}