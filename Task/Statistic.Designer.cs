namespace Task
{
    partial class Statistic
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
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            btnCompletedTasks = new Button();
            lblCompletedTasksCount = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(85, 106);
            label4.Name = "label4";
            label4.Size = new Size(696, 40);
            label4.TabIndex = 20;
            label4.Text = "Выберите период для расчета выполненных задач";
            label4.Click += label4_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpStartDate.Location = new Point(295, 207);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(422, 43);
            dtpStartDate.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(153, 210);
            label3.Name = "label3";
            label3.Size = new Size(136, 40);
            label3.TabIndex = 17;
            label3.Text = "Начало -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(266, 37);
            label2.Name = "label2";
            label2.Size = new Size(364, 59);
            label2.TabIndex = 16;
            label2.Text = "Статистика задач";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpEndDate.Location = new Point(295, 256);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(422, 43);
            dtpEndDate.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(153, 256);
            label1.Name = "label1";
            label1.Size = new Size(120, 40);
            label1.TabIndex = 30;
            label1.Text = "Конец -";
            // 
            // btnCompletedTasks
            // 
            btnCompletedTasks.BackColor = Color.OrangeRed;
            btnCompletedTasks.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCompletedTasks.ForeColor = SystemColors.ButtonHighlight;
            btnCompletedTasks.Location = new Point(295, 338);
            btnCompletedTasks.Name = "btnCompletedTasks";
            btnCompletedTasks.Size = new Size(302, 88);
            btnCompletedTasks.TabIndex = 32;
            btnCompletedTasks.Text = "Рассчитать";
            btnCompletedTasks.UseVisualStyleBackColor = false;
            btnCompletedTasks.Click += btnCompletedTasks_Click;
            // 
            // lblCompletedTasksCount
            // 
            lblCompletedTasksCount.AutoSize = true;
            lblCompletedTasksCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCompletedTasksCount.Location = new Point(295, 513);
            lblCompletedTasksCount.Name = "lblCompletedTasksCount";
            lblCompletedTasksCount.Size = new Size(313, 45);
            lblCompletedTasksCount.TabIndex = 33;
            lblCompletedTasksCount.Text = "Выполнено задач: X";
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 627);
            Controls.Add(lblCompletedTasksCount);
            Controls.Add(btnCompletedTasks);
            Controls.Add(dtpEndDate);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Statistic";
            Text = "Statistic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTask;
        private ComboBox cmbStatus;
        private Label label8;
        private ComboBox cmbAssignee;
        private Label label7;
        private ComboBox cmbPriority;
        private Label label6;
        private Label label5;
        private TextBox txtTaskDescription;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private TextBox txtProjectName;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Button btnCompletedTasks;
        private Label lblCompletedTasksCount;
    }
}