namespace _011_ex
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
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtKo = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblKorean = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEverage = new System.Windows.Forms.TextBox();
            this.lblEverage = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEn);
            this.groupBox1.Controls.Add(this.txtMath);
            this.groupBox1.Controls.Add(this.txtKo);
            this.groupBox1.Controls.Add(this.lblEnglish);
            this.groupBox1.Controls.Add(this.lblMath);
            this.groupBox1.Controls.Add(this.lblKorean);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(68, 90);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(94, 23);
            this.txtEn.TabIndex = 5;
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(68, 51);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(94, 23);
            this.txtMath.TabIndex = 4;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKo
            // 
            this.txtKo.Location = new System.Drawing.Point(68, 16);
            this.txtKo.Name = "txtKo";
            this.txtKo.Size = new System.Drawing.Size(94, 23);
            this.txtKo.TabIndex = 3;
            this.txtKo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(15, 93);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(31, 15);
            this.lblEnglish.TabIndex = 2;
            this.lblEnglish.Text = "영어";
            this.lblEnglish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(15, 54);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(31, 15);
            this.lblMath.TabIndex = 1;
            this.lblMath.Text = "수학";
            this.lblMath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKorean
            // 
            this.lblKorean.AutoSize = true;
            this.lblKorean.Location = new System.Drawing.Point(15, 21);
            this.lblKorean.Name = "lblKorean";
            this.lblKorean.Size = new System.Drawing.Size(31, 15);
            this.lblKorean.TabIndex = 0;
            this.lblKorean.Text = "국어";
            this.lblKorean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEverage);
            this.groupBox2.Controls.Add(this.lblEverage);
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(289, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // txtEverage
            // 
            this.txtEverage.Location = new System.Drawing.Point(61, 51);
            this.txtEverage.Name = "txtEverage";
            this.txtEverage.ReadOnly = true;
            this.txtEverage.Size = new System.Drawing.Size(75, 23);
            this.txtEverage.TabIndex = 7;
            this.txtEverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEverage
            // 
            this.lblEverage.AutoSize = true;
            this.lblEverage.Location = new System.Drawing.Point(17, 54);
            this.lblEverage.Name = "lblEverage";
            this.lblEverage.Size = new System.Drawing.Size(31, 15);
            this.lblEverage.TabIndex = 1;
            this.lblEverage.Text = "평균";
            this.lblEverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(61, 18);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(75, 23);
            this.txtSum.TabIndex = 6;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(17, 21);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 15);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "총점";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(350, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtKo;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Label lblKorean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEverage;
        private System.Windows.Forms.Label lblEverage;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
    }
}

