using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AddTaskForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=task_management;Username=postgres;Password=alina";

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = txtProjectName.Text;
                string description = txtTaskDescription.Text;
                string priority = cmbPriority.SelectedItem.ToString();
                string assignee = cmbAssignee.SelectedItem.ToString();
                string status = cmbStatus.SelectedItem.ToString();
                DateTime creationDate = dtpCreationDate.Value;

                var databaseManager = new DatabaseManager();

                databaseManager.AddTask(projectName, description, priority, assignee, status, creationDate);

                MessageBox.Show("Задача успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении задачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
