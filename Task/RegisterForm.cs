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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=task_management;Username=postgres;Password=alina";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users (login, password, role) VALUES (@login, @password, @role)";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role", role);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Пользователь успешно зарегистрирован!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при регистрации: {ex.Message}");
                    }
                }
            }

        }
    }
}
