namespace Task
{
    partial class RegisterForm
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.OrangeRed;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(502, 533);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(392, 100);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(602, 329);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(363, 50);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(409, 329);
            label3.Name = "label3";
            label3.Size = new Size(137, 45);
            label3.TabIndex = 10;
            label3.Text = "Пароль:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUsername.Location = new Point(602, 252);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(363, 50);
            txtUsername.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(429, 252);
            label2.Name = "label2";
            label2.Size = new Size(117, 45);
            label2.TabIndex = 8;
            label2.Text = "Логин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(468, 85);
            label1.Name = "label1";
            label1.Size = new Size(471, 100);
            label1.TabIndex = 7;
            label1.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(429, 407);
            label4.Name = "label4";
            label4.Size = new Size(97, 45);
            label4.TabIndex = 14;
            label4.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "администратор", "сотрудник" });
            cmbRole.Location = new Point(602, 407);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(363, 53);
            cmbRole.TabIndex = 15;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 708);
            Controls.Add(cmbRole);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbRole;
    }
}