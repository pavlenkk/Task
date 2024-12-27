using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Task
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=task_management;Username=postgres;Password=alina";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT role FROM users WHERE login = @login AND password = @password";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("password", password);

                    var role = command.ExecuteScalar(); // Получаем роль пользователя

                    if (role != null)
                    {
                        string userRole = role.ToString();
                        MessageBox.Show($"Добро пожаловать, {login}! Ваша роль: {userRole}.");

                        // Открываем главную форму на основе роли
                        if (userRole == "администратор")
                        {
                            var adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (userRole == "сотрудник")
                        {
                            var employeeForm = new EmployeeForm();
                            employeeForm.Show();
                        }

                        this.Hide(); // Скрываем текущую форму
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
