namespace Upbit_Trade
{
    partial class Main
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.bt_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(193, 11);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(119, 48);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "로그인";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(18, 11);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(169, 21);
            this.text_id.TabIndex = 1;
            // 
            // text_pw
            // 
            this.text_pw.Location = new System.Drawing.Point(18, 38);
            this.text_pw.Name = "text_pw";
            this.text_pw.Size = new System.Drawing.Size(169, 21);
            this.text_pw.TabIndex = 2;
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(18, 65);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(294, 48);
            this.bt_register.TabIndex = 3;
            this.bt_register.Text = "회원가입";
            this.bt_register.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 313);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.bt_Login);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.Button bt_register;
    }
}

