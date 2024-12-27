namespace Task
{
    partial class EditTaskForm
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
            btnUpdateTask = new Button();
            cmbEditStatus = new ComboBox();
            label8 = new Label();
            cmbEditAssignee = new ComboBox();
            label7 = new Label();
            cmbEditPriority = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtEditDescription = new TextBox();
            label2 = new Label();
            dgvTasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.BackColor = Color.OrangeRed;
            btnUpdateTask.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdateTask.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateTask.Location = new Point(299, 436);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(302, 88);
            btnUpdateTask.TabIndex = 29;
            btnUpdateTask.Text = "Редактировать";
            btnUpdateTask.UseVisualStyleBackColor = false;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // cmbEditStatus
            // 
            cmbEditStatus.Font = new Font("Segoe UI", 10.125F);
            cmbEditStatus.FormattingEnabled = true;
            cmbEditStatus.Items.AddRange(new object[] { "в ожидании", "в работе", "выполнено" });
            cmbEditStatus.Location = new Point(340, 346);
            cmbEditStatus.Name = "cmbEditStatus";
            cmbEditStatus.Size = new Size(422, 45);
            cmbEditStatus.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(51, 346);
            label8.Name = "label8";
            label8.Size = new Size(207, 40);
            label8.TabIndex = 27;
            label8.Text = "Статус задачи:";
            // 
            // cmbEditAssignee
            // 
            cmbEditAssignee.Font = new Font("Segoe UI", 10.125F);
            cmbEditAssignee.FormattingEnabled = true;
            cmbEditAssignee.Items.AddRange(new object[] { "администратор", "сотрудник" });
            cmbEditAssignee.Location = new Point(340, 291);
            cmbEditAssignee.Name = "cmbEditAssignee";
            cmbEditAssignee.Size = new Size(422, 45);
            cmbEditAssignee.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(51, 291);
            label7.Name = "label7";
            label7.Size = new Size(198, 40);
            label7.TabIndex = 25;
            label7.Text = "Исполнитель:";
            // 
            // cmbEditPriority
            // 
            cmbEditPriority.Font = new Font("Segoe UI", 10.125F);
            cmbEditPriority.FormattingEnabled = true;
            cmbEditPriority.Items.AddRange(new object[] { "низкий", "средний", "высокий" });
            cmbEditPriority.Location = new Point(340, 236);
            cmbEditPriority.Name = "cmbEditPriority";
            cmbEditPriority.Size = new Size(422, 45);
            cmbEditPriority.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(51, 236);
            label6.Name = "label6";
            label6.Size = new Size(168, 40);
            label6.TabIndex = 23;
            label6.Text = "Приоритет:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(51, 184);
            label5.Name = "label5";
            label5.Size = new Size(256, 40);
            label5.TabIndex = 22;
            label5.Text = "Описание задачи:";
            // 
            // txtEditDescription
            // 
            txtEditDescription.Font = new Font("Segoe UI", 10.125F);
            txtEditDescription.Location = new Point(340, 178);
            txtEditDescription.Name = "txtEditDescription";
            txtEditDescription.Size = new Size(422, 43);
            txtEditDescription.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(190, 32);
            label2.Name = "label2";
            label2.Size = new Size(496, 59);
            label2.TabIndex = 16;
            label2.Text = "Редактирование задачи";
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(895, 107);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 82;
            dgvTasks.Size = new Size(789, 417);
            dgvTasks.TabIndex = 30;
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 629);
            Controls.Add(dgvTasks);
            Controls.Add(btnUpdateTask);
            Controls.Add(cmbEditStatus);
            Controls.Add(label8);
            Controls.Add(cmbEditAssignee);
            Controls.Add(label7);
            Controls.Add(cmbEditPriority);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEditDescription);
            Controls.Add(label2);
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateTask;
        private ComboBox cmbEditStatus;
        private Label label8;
        private ComboBox cmbEditAssignee;
        private Label label7;
        private ComboBox cmbEditPriority;
        private Label label6;
        private Label label5;
        private TextBox txtEditDescription;
        private Label label2;
        private DataGridView dgvTasks;
    }
}