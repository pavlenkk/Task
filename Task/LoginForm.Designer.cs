namespace Task
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(451, 92);
            label1.Name = "label1";
            label1.Size = new Size(491, 100);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(433, 279);
            label2.Name = "label2";
            label2.Size = new Size(117, 45);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUsername.Location = new Point(606, 279);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(363, 50);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(606, 356);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(363, 50);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(413, 356);
            label3.Name = "label3";
            label3.Size = new Size(137, 45);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(534, 460);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(325, 100);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRegister.ForeColor = Color.OrangeRed;
            btnRegister.Location = new Point(413, 601);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(556, 68);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 737);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button btnRegister;
    }
}