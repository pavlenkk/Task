namespace Task
{
    partial class EmployeeForm
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
            button1 = new Button();
            Update = new Button();
            btnEditTask = new Button();
            btnAddTask = new Button();
            label1 = new Label();
            dgvTasks = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(890, 558);
            button1.Name = "button1";
            button1.Size = new Size(282, 71);
            button1.TabIndex = 17;
            button1.Text = "Фильтрация задач";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ButtonHighlight;
            Update.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Update.ForeColor = Color.OrangeRed;
            Update.Location = new Point(1180, 163);
            Update.Name = "Update";
            Update.Size = new Size(50, 50);
            Update.TabIndex = 16;
            Update.Text = "O";
            Update.UseVisualStyleBackColor = false;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.OrangeRed;
            btnEditTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditTask.ForeColor = SystemColors.ButtonHighlight;
            btnEditTask.Location = new Point(489, 558);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(380, 71);
            btnEditTask.TabIndex = 14;
            btnEditTask.Text = "Редактировать задачу";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.OrangeRed;
            btnAddTask.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddTask.ForeColor = SystemColors.ButtonHighlight;
            btnAddTask.Location = new Point(189, 558);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(282, 71);
            btnAddTask.TabIndex = 13;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(511, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 84);
            label1.TabIndex = 12;
            label1.Text = "TaskManager";
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(210, 163);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 82;
            dgvTasks.Size = new Size(941, 350);
            dgvTasks.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(500, 717);
            button2.Name = "button2";
            button2.Size = new Size(353, 46);
            button2.TabIndex = 18;
            button2.Text = "Возникли проблемы?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 806);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Controls.Add(label1);
            Controls.Add(dgvTasks);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Update;
        private Button btnEditTask;
        private Button btnAddTask;
        private Label label1;
        private DataGridView dgvTasks;
        private Button button2;
    }
}