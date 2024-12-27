namespace Task
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            dgvTasks = new DataGridView();
            label1 = new Label();
            btnAddTask = new Button();
            btnEditTask = new Button();
            btnDeleteTask = new Button();
            Update = new Button();
            button1 = new Button();
            btnStat = new Button();
            btnExportUsers = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(55, 211);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 82;
            dgvUsers.Size = new Size(680, 350);
            dgvUsers.TabIndex = 0;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(777, 211);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 82;
            dgvTasks.Size = new Size(941, 350);
            dgvTasks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(724, 55);
            label1.Name = "label1";
            label1.Size = new Size(395, 84);
            label1.TabIndex = 2;
            label1.Text = "TaskManager";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.OrangeRed;
            btnAddTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddTask.ForeColor = SystemColors.ButtonHighlight;
            btnAddTask.Location = new Point(225, 607);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(282, 71);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.OrangeRed;
            btnEditTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditTask.ForeColor = SystemColors.ButtonHighlight;
            btnEditTask.Location = new Point(525, 607);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(380, 71);
            btnEditTask.TabIndex = 4;
            btnEditTask.Text = "Редактировать задачу";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = SystemColors.ButtonHighlight;
            btnDeleteTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteTask.ForeColor = Color.OrangeRed;
            btnDeleteTask.Location = new Point(1262, 607);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(282, 71);
            btnDeleteTask.TabIndex = 5;
            btnDeleteTask.Text = "Удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ButtonHighlight;
            Update.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Update.ForeColor = Color.OrangeRed;
            Update.Location = new Point(1738, 211);
            Update.Name = "Update";
            Update.Size = new Size(50, 50);
            Update.TabIndex = 6;
            Update.Text = "O";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(926, 607);
            button1.Name = "button1";
            button1.Size = new Size(282, 71);
            button1.TabIndex = 7;
            button1.Text = "Фильтрация задач";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnStat
            // 
            btnStat.BackColor = Color.OrangeRed;
            btnStat.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStat.ForeColor = SystemColors.ButtonHighlight;
            btnStat.Location = new Point(374, 706);
            btnStat.Name = "btnStat";
            btnStat.Size = new Size(282, 71);
            btnStat.TabIndex = 8;
            btnStat.Text = "Статистика задач";
            btnStat.UseVisualStyleBackColor = false;
            btnStat.Click += btnStat_Click;
            // 
            // btnExportUsers
            // 
            btnExportUsers.BackColor = Color.OrangeRed;
            btnExportUsers.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExportUsers.ForeColor = SystemColors.ButtonHighlight;
            btnExportUsers.Location = new Point(777, 706);
            btnExportUsers.Name = "btnExportUsers";
            btnExportUsers.Size = new Size(431, 71);
            btnExportUsers.TabIndex = 9;
            btnExportUsers.Text = "Выгрузка пользователей";
            btnExportUsers.UseVisualStyleBackColor = false;
            btnExportUsers.Click += btnExportUsers_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(741, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 45);
            label2.TabIndex = 10;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 845);
            Controls.Add(label2);
            Controls.Add(btnExportUsers);
            Controls.Add(btnStat);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Controls.Add(label1);
            Controls.Add(dgvTasks);
            Controls.Add(dgvUsers);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private DataGridView dgvTasks;
        private Label label1;
        private Button btnAddTask;
        private Button btnEditTask;
        private Button btnDeleteTask;
        private Button Update;
        private Button button1;
        private Button btnStat;
        private Button btnExportUsers;
        private Label label2;
    }
}
