namespace ExceptionHandlingApp
{
    partial class Form3206
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 149);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(221, 82);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 53);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(221, 28);
            this.txtInput.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(221, 28);
            this.txtResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "숫자를 입력해주세요";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3206
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnResult);
            this.Name = "Form3206";
            this.Text = "Form3206";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}