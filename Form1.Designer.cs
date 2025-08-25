namespace FortuneTeller
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbBitrhtime = new System.Windows.Forms.TextBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowResult);
            this.groupBox1.Controls.Add(this.tbBitrhtime);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사주 결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 입력하세요.(예: 2003.11.21)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 입력해주세요.(예: 새벽 3시 3분 -> 03)";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(23, 107);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(212, 21);
            this.tbBirthday.TabIndex = 2;
            // 
            // tbBitrhtime
            // 
            this.tbBitrhtime.Location = new System.Drawing.Point(23, 184);
            this.tbBitrhtime.Name = "tbBitrhtime";
            this.tbBitrhtime.Size = new System.Drawing.Size(265, 21);
            this.tbBitrhtime.TabIndex = 3;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(23, 313);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(272, 42);
            this.btnShowResult.TabIndex = 4;
            this.btnShowResult.Text = "사주팔자 결과 보기";
            this.btnShowResult.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(6, 20);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(378, 400);
            this.tbResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "포츈텔러";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbBitrhtime;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

