using System;
using System.Text;
using System.Windows.Forms;

namespace Task
{
    public partial class AdminForm : Form
    {
        private DatabaseManager dbManager;

        public AdminForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadData();
        }
        private void LoadData()
        {
            dgvUsers.DataSource = dbManager.GetUsers();
            dgvTasks.DataSource = dbManager.GetTasks();
        }
        private void LoadTasks()
        {
            dgvUsers.DataSource = dbManager.GetUsers();
            dgvTasks.DataSource = dbManager.GetTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var AddTaskForm = new AddTaskForm();
            AddTaskForm.Show();
        }


        private void btnEditTask_Click(object sender, EventArgs e)
        {

            var EditTaskForm = new EditTaskForm();
            EditTaskForm.Show();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ ��� ��������.");
                return;
            }

            DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
            int taskId = (int)selectedRow.Cells["task_id"].Value;

            // ������������� ����� ���������
            DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ��� ������?", "������������� ��������", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var databaseManager = new DatabaseManager();
                // �������� ������
                databaseManager.DeleteTask(taskId);
                MessageBox.Show("������ ������� �������.");

                LoadTasks(); // ������������ �����
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            LoadTasks(); // ������������ �����
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FiltersForm = new Filters();
            FiltersForm.Show();
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            var StatForm = new Statistic();
            StatForm.Show();
        }

        private void btnExportUsers_Click(object sender, EventArgs e)
        {
            // ��������� ������ ���������� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV ����� (*.csv)|*.csv",
                Title = "��������� ���� �������������",
                FileName = "users.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportDataGridViewToCSV(dgvUsers, saveFileDialog.FileName);
                    MessageBox.Show("������ ������� ��������������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"��������� ������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportDataGridViewToCSV(DataGridView dgvUsers, string filePath)
        {
            // ���������� StringBuilder ��� ������������ ������
            StringBuilder csvContent = new StringBuilder();

            // ��������� ��������
            for (int i = 0; i < dgvUsers.Columns.Count; i++)
            {
                csvContent.Append(dgvUsers.Columns[i].HeaderText);
                if (i < dgvUsers.Columns.Count - 1)
                    csvContent.Append(","); // �����������
            }
            csvContent.AppendLine(); // ������� �� ����� ������

            // ������ �����
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (!row.IsNewRow) // ���������� ������ ��� ����� ����� ������
                {
                    for (int i = 0; i < dgvUsers.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString().Replace(",", " ")); // �������� ������� �� �������
                        if (i < dgvUsers.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }
            }

            // ���������� ������ � ����
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }
    }
}
