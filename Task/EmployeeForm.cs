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
    public partial class EmployeeForm : Form
    {
        private DatabaseManager dbManager;

        public EmployeeForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadData();
        }
        private void LoadData()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var FiltersForm = new Filters();
            FiltersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в техническую поддержку, TG: @pavlenkk", "Возникновение проблем", MessageBoxButtons.OK);

        }
    }
}
