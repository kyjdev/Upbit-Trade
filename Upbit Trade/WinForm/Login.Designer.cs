namespace Upbit_Trade.WinForm
{
    partial class Login
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
            this.bt_register = new System.Windows.Forms.Button();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(12, 66);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(294, 48);
            this.bt_register.TabIndex = 7;
            this.bt_register.Text = "회원가입";
            this.bt_register.UseVisualStyleBackColor = true;
            // 
            // text_pw
            // 
            this.text_pw.Location = new System.Drawing.Point(12, 39);
            this.text_pw.Name = "text_pw";
            this.text_pw.Size = new System.Drawing.Size(169, 21);
            this.text_pw.TabIndex = 6;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(12, 12);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(169, 21);
            this.text_id.TabIndex = 5;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(187, 12);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(119, 48);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "로그인";
            this.bt_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.bt_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button bt_Login;
    }
}