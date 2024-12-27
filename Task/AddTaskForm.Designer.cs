namespace Task
{
    partial class AddTaskForm
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
            label2 = new Label();
            txtProjectName = new TextBox();
            label3 = new Label();
            dtpCreationDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtTaskDescription = new TextBox();
            label6 = new Label();
            cmbPriority = new ComboBox();
            cmbAssignee = new ComboBox();
            label7 = new Label();
            cmbStatus = new ComboBox();
            label8 = new Label();
            btnSaveTask = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(324, 33);
            label2.Name = "label2";
            label2.Size = new Size(415, 59);
            label2.TabIndex = 2;
            label2.Text = "Добавление задачи";
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Segoe UI", 10.125F);
            txtProjectName.Location = new Point(460, 135);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(422, 43);
            txtProjectName.TabIndex = 4;
            txtProjectName.TextChanged += txtProjectName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(171, 252);
            label3.Name = "label3";
            label3.Size = new Size(216, 40);
            label3.TabIndex = 3;
            label3.Text = "Дата создания:";
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpCreationDate.Location = new Point(460, 252);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(422, 43);
            dtpCreationDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(171, 141);
            label4.Name = "label4";
            label4.Size = new Size(266, 40);
            label4.TabIndex = 6;
            label4.Text = "Название проекта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(171, 197);
            label5.Name = "label5";
            label5.Size = new Size(256, 40);
            label5.TabIndex = 8;
            label5.Text = "Описание задачи:";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Font = new Font("Segoe UI", 10.125F);
            txtTaskDescription.Location = new Point(460, 191);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(422, 43);
            txtTaskDescription.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(171, 307);
            label6.Name = "label6";
            label6.Size = new Size(168, 40);
            label6.TabIndex = 9;
            label6.Text = "Приоритет:";
            // 
            // cmbPriority
            // 
            cmbPriority.Font = new Font("Segoe UI", 10.125F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "низкий", "средний", "высокий" });
            cmbPriority.Location = new Point(460, 307);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(422, 45);
            cmbPriority.TabIndex = 10;
            // 
            // cmbAssignee
            // 
            cmbAssignee.Font = new Font("Segoe UI", 10.125F);
            cmbAssignee.FormattingEnabled = true;
            cmbAssignee.Items.AddRange(new object[] { "администратор", "сотрудник" });
            cmbAssignee.Location = new Point(460, 362);
            cmbAssignee.Name = "cmbAssignee";
            cmbAssignee.Size = new Size(422, 45);
            cmbAssignee.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(171, 362);
            label7.Name = "label7";
            label7.Size = new Size(198, 40);
            label7.TabIndex = 11;
            label7.Text = "Исполнитель:";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10.125F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "в ожидании", "в работе", "выполнено" });
            cmbStatus.Location = new Point(460, 417);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(422, 45);
            cmbStatus.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(171, 417);
            label8.Name = "label8";
            label8.Size = new Size(207, 40);
            label8.TabIndex = 13;
            label8.Text = "Статус задачи:";
            // 
            // btnSaveTask
            // 
            btnSaveTask.BackColor = Color.OrangeRed;
            btnSaveTask.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSaveTask.ForeColor = SystemColors.ButtonHighlight;
            btnSaveTask.Location = new Point(379, 522);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(302, 88);
            btnSaveTask.TabIndex = 15;
            btnSaveTask.Text = "Добавить";
            btnSaveTask.UseVisualStyleBackColor = false;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 685);
            Controls.Add(btnSaveTask);
            Controls.Add(cmbStatus);
            Controls.Add(label8);
            Controls.Add(cmbAssignee);
            Controls.Add(label7);
            Controls.Add(cmbPriority);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTaskDescription);
            Controls.Add(label4);
            Controls.Add(dtpCreationDate);
            Controls.Add(txtProjectName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtProjectName;
        private Label label3;
        private DateTimePicker dtpCreationDate;
        private Label label4;
        private Label label5;
        private TextBox txtTaskDescription;
        private Label label6;
        private ComboBox cmbPriority;
        private ComboBox cmbAssignee;
        private Label label7;
        private ComboBox cmbStatus;
        private Label label8;
        private Button btnSaveTask;
    }
}