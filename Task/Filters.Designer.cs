namespace Task
{
    partial class Filters
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
            dgvTasks = new DataGridView();
            btnApplyFilters = new Button();
            cmbFilterStatus = new ComboBox();
            label8 = new Label();
            cmbFilterAssignee = new ComboBox();
            label7 = new Label();
            cmbFilterPriority = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(916, 140);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 82;
            dgvTasks.Size = new Size(789, 417);
            dgvTasks.TabIndex = 41;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.OrangeRed;
            btnApplyFilters.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnApplyFilters.ForeColor = SystemColors.ButtonHighlight;
            btnApplyFilters.Location = new Point(333, 341);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(302, 88);
            btnApplyFilters.TabIndex = 40;
            btnApplyFilters.Text = "Поиск";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.Font = new Font("Segoe UI", 10.125F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "в ожидании", "в работе", "выполнено" });
            cmbFilterStatus.Location = new Point(374, 251);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(422, 45);
            cmbFilterStatus.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(85, 251);
            label8.Name = "label8";
            label8.Size = new Size(207, 40);
            label8.TabIndex = 38;
            label8.Text = "Статус задачи:";
            // 
            // cmbFilterAssignee
            // 
            cmbFilterAssignee.Font = new Font("Segoe UI", 10.125F);
            cmbFilterAssignee.FormattingEnabled = true;
            cmbFilterAssignee.Items.AddRange(new object[] { "администратор", "сотрудник" });
            cmbFilterAssignee.Location = new Point(374, 196);
            cmbFilterAssignee.Name = "cmbFilterAssignee";
            cmbFilterAssignee.Size = new Size(422, 45);
            cmbFilterAssignee.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(85, 196);
            label7.Name = "label7";
            label7.Size = new Size(198, 40);
            label7.TabIndex = 36;
            label7.Text = "Исполнитель:";
            // 
            // cmbFilterPriority
            // 
            cmbFilterPriority.Font = new Font("Segoe UI", 10.125F);
            cmbFilterPriority.FormattingEnabled = true;
            cmbFilterPriority.Items.AddRange(new object[] { "низкий", "средний", "высокий" });
            cmbFilterPriority.Location = new Point(374, 141);
            cmbFilterPriority.Name = "cmbFilterPriority";
            cmbFilterPriority.Size = new Size(422, 45);
            cmbFilterPriority.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(85, 141);
            label6.Name = "label6";
            label6.Size = new Size(168, 40);
            label6.TabIndex = 34;
            label6.Text = "Приоритет:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(255, 39);
            label2.Name = "label2";
            label2.Size = new Size(396, 59);
            label2.TabIndex = 31;
            label2.Text = "Фильтрация задач:";
            label2.Click += label2_Click;
            // 
            // Filters
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 629);
            Controls.Add(dgvTasks);
            Controls.Add(btnApplyFilters);
            Controls.Add(cmbFilterStatus);
            Controls.Add(label8);
            Controls.Add(cmbFilterAssignee);
            Controls.Add(label7);
            Controls.Add(cmbFilterPriority);
            Controls.Add(label6);
            Controls.Add(label2);
            Name = "Filters";
            Text = "Filters";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasks;
        private Button btnApplyFilters;
        private ComboBox cmbFilterStatus;
        private Label label8;
        private ComboBox cmbFilterAssignee;
        private Label label7;
        private ComboBox cmbFilterPriority;
        private Label label6;
        private Label label2;
    }
}