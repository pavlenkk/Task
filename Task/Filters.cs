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
    public partial class Filters : Form
    {
        private DatabaseManager dbManager;

        public Filters()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadTasks();
        }

        private void LoadTasks()
        {
            dgvTasks.DataSource = dbManager.GetTasks();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            var databaseManager = new DatabaseManager();

            string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "";
            string filterAssignee = cmbFilterAssignee.SelectedItem?.ToString() ?? "";
            string filterPriority = cmbFilterPriority.SelectedItem?.ToString() ?? "";

            DataTable filteredTasks = databaseManager.GetFilteredTasks(filterStatus, filterAssignee, filterPriority);
            dgvTasks.DataSource = filteredTasks;
        }
    }
}
