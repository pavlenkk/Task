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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletedTasks_Click(object sender, EventArgs e)
        {
            // Получаем даты из DateTimePicker
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Начальная дата не может быть позже конечной.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var databaseManager = new DatabaseManager();

            // Вызываем метод для получения количества выполненных задач
            int completedTasksCount = databaseManager.GetCompletedTasksCount(startDate, endDate);

            // Отображаем результат в метке
            lblCompletedTasksCount.Text = $"Выполнено задач: {completedTasksCount}";
        }
    }
}
