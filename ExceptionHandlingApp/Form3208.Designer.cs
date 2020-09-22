namespace ExceptionHandlingApp
{
    partial class Form3208
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
            this.resultclick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(37, 66);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(211, 25);
            this.txtinput.TabIndex = 0;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(37, 97);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(211, 25);
            this.txtresult.TabIndex = 1;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // resultclick
            // 
            this.resultclick.Location = new System.Drawing.Point(37, 137);
            this.resultclick.Name = "resultclick";
            this.resultclick.Size = new System.Drawing.Size(211, 138);
            this.resultclick.TabIndex = 2;
            this.resultclick.Text = "결과보기";
            this.resultclick.UseVisualStyleBackColor = true;
            this.resultclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3208
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 287);
            this.Controls.Add(this.resultclick);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtinput);
            this.Name = "Form3208";
            this.Text = "Form3208";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button resultclick;
    }
}