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
                MessageBox.Show("Выберите задачу для удаления.");
                return;
            }

            DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
            int taskId = (int)selectedRow.Cells["task_id"].Value;

            // Подтверждение перед удалением
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту задачу?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var databaseManager = new DatabaseManager();
                // Удаление задачи
                databaseManager.DeleteTask(taskId);
                MessageBox.Show("Задача успешно удалена.");

                LoadTasks(); // Перезагрузка задач
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            LoadTasks(); // Перезагрузка задач
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
            // Открываем диалог сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                Title = "Сохранить файл пользователей",
                FileName = "users.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportDataGridViewToCSV(dgvUsers, saveFileDialog.FileName);
                    MessageBox.Show("Данные успешно экспортированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при экспорте данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportDataGridViewToCSV(DataGridView dgvUsers, string filePath)
        {
            // Используем StringBuilder для формирования строки
            StringBuilder csvContent = new StringBuilder();

            // Заголовки столбцов
            for (int i = 0; i < dgvUsers.Columns.Count; i++)
            {
                csvContent.Append(dgvUsers.Columns[i].HeaderText);
                if (i < dgvUsers.Columns.Count - 1)
                    csvContent.Append(","); // Разделитель
            }
            csvContent.AppendLine(); // Переход на новую строку

            // Данные строк
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (!row.IsNewRow) // Пропускаем строку для ввода новых данных
                {
                    for (int i = 0; i < dgvUsers.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString().Replace(",", " ")); // Заменяем запятые на пробелы
                        if (i < dgvUsers.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }
            }

            // Записываем данные в файл
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }
    }
}
