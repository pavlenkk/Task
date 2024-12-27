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
    public partial class EditTaskForm : Form
    {
        private DatabaseManager dbManager;

        public EditTaskForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadTasks();
        }
        private void LoadTasks()
        {
            dgvTasks.DataSource = dbManager.GetTasks();
        }
        
        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTasks.SelectedRows[0];
                txtEditDescription.Text = row.Cells["description"].Value.ToString();
                cmbEditPriority.SelectedItem = row.Cells["priority"].Value.ToString();
                cmbEditAssignee.SelectedItem = row.Cells["assignee"].Value.ToString();
                cmbEditStatus.SelectedItem = row.Cells["status"].Value.ToString();
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования.");
                return;
            }

            DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
            int taskId = (int)selectedRow.Cells["task_id"].Value;

            string newDescription = txtEditDescription.Text;
            string newPriority = cmbEditPriority.SelectedItem.ToString();
            string newAssignee = cmbEditAssignee.SelectedItem.ToString();
            string newStatus = cmbEditStatus.SelectedItem.ToString();

            var databaseManager = new DatabaseManager();

            
            databaseManager.UpdateTask(taskId, newDescription, newPriority, newAssignee, newStatus);

            MessageBox.Show("Задача успешно обновлена.");
            
            LoadTasks();

           
        }


    }
}
