namespace ExceptionHandlingApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();

            this.btn3107 = new System.Windows.Forms.Button();
            this.btn3119 = new System.Windows.Forms.Button();
            this.btn3110 = new System.Windows.Forms.Button();
            this.btn3105 = new System.Windows.Forms.Button();
            this.btn3199 = new System.Windows.Forms.Button();

            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 

            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(299, 26);

            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 20);
            this.toolStripStatusLabel1.Text = "NCP 수업 - 예외 처리";
            // 
            // groupBox1
            // 

            this.groupBox1.Controls.Add(this.btn3107);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
          
            this.groupBox1.Controls.Add(this.btn3119);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

            this.groupBox1.Controls.Add(this.btn3110);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);


            this.groupBox1.Controls.Add(this.btn3105);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);

            this.groupBox1.Controls.Add(this.btn3199);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);

            this.groupBox1.Name = "groupBox1";

            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(271, 200);


            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3-1";
            // 
            // groupBox2
            // 

            this.groupBox2.Location = new System.Drawing.Point(15, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(271, 200);

            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3-2";
            // 

            // btn3107
            // 
            this.btn3107.Location = new System.Drawing.Point(6, 36);
            this.btn3107.Name = "btn3107";
            this.btn3107.Size = new System.Drawing.Size(102, 27);
            this.btn3107.TabIndex = 0;
            this.btn3107.Text = "3107 소민지";
            this.btn3107.UseVisualStyleBackColor = true;
            this.btn3107.Click += new System.EventHandler(this.btn3107_Click);

            // btn3119
            // 
            this.btn3119.Location = new System.Drawing.Point(7, 26);
            this.btn3119.Name = "btn3119";
            this.btn3119.Size = new System.Drawing.Size(104, 23);
            this.btn3119.TabIndex = 0;
            this.btn3119.Text = "3119 황다희";
            this.btn3119.UseVisualStyleBackColor = true;
            this.btn3119.Click += new System.EventHandler(this.btn3119_Click);

            // btn3110
            // 
            this.btn3110.Location = new System.Drawing.Point(69, 53);
            this.btn3110.Name = "btn3110";
            this.btn3110.Size = new System.Drawing.Size(129, 48);
            this.btn3110.TabIndex = 0;
            this.btn3110.Text = "3110 양아름";
            this.btn3110.UseVisualStyleBackColor = true;
            this.btn3110.Click += new System.EventHandler(this.btn3110_Click);

            // btn3105
            // 
            this.btn3105.Location = new System.Drawing.Point(22, 42);
            this.btn3105.Name = "btn3105";
            this.btn3105.Size = new System.Drawing.Size(118, 58);
            this.btn3105.TabIndex = 0;
            this.btn3105.Text = "3105 박소영";
            this.btn3105.UseVisualStyleBackColor = true;
            this.btn3105.Click += new System.EventHandler(this.btn3105_Click);

            // btn3199
            // 
            this.btn3199.Location = new System.Drawing.Point(7, 21);
            this.btn3199.Name = "btn3199";
            this.btn3199.Size = new System.Drawing.Size(82, 23);
            this.btn3199.TabIndex = 0;
            this.btn3199.Text = "3199 함기훈";
            this.btn3199.UseVisualStyleBackColor = true;
            this.btn3199.Click += new System.EventHandler(this.btn3199_Click);

            // 
            // Form1
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);


            this.Name = "Form1";
            this.Text = "예외 처리 실습";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button btn3107;
        private System.Windows.Forms.Button btn3119;
        private System.Windows.Forms.Button btn3110;
        private System.Windows.Forms.Button btn3105;
        private System.Windows.Forms.Button btn3199;
    }
}

