namespace ZooManagementSystemBoundary
{
    partial class UpdateMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AnimalLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.markCompleteButton = new System.Windows.Forms.Button();
            this.nextTask = new System.Windows.Forms.Button();
            this.previousTask = new System.Windows.Forms.Button();
            this.TaskNo = new System.Windows.Forms.Label();
            this.taskType = new System.Windows.Forms.Label();
            this.taskAnimal = new System.Windows.Forms.Label();
            this.taskDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Task";
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(698, 14);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 28);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(11, 22);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID: ";
            this.idLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(370, 177);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateLabel.Size = new System.Drawing.Size(60, 15);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Task due:";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AnimalLabel
            // 
            this.AnimalLabel.AutoSize = true;
            this.AnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalLabel.Location = new System.Drawing.Point(369, 250);
            this.AnimalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnimalLabel.Name = "AnimalLabel";
            this.AnimalLabel.Size = new System.Drawing.Size(66, 15);
            this.AnimalLabel.TabIndex = 8;
            this.AnimalLabel.Text = "Animal ID: ";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(380, 307);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 15);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Task:";
            // 
            // markCompleteButton
            // 
            this.markCompleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markCompleteButton.Location = new System.Drawing.Point(354, 376);
            this.markCompleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.markCompleteButton.Name = "markCompleteButton";
            this.markCompleteButton.Size = new System.Drawing.Size(88, 47);
            this.markCompleteButton.TabIndex = 5;
            this.markCompleteButton.Text = "Mark as Complete";
            this.markCompleteButton.UseVisualStyleBackColor = true;
            this.markCompleteButton.Click += new System.EventHandler(this.markComplete);
            // 
            // nextTask
            // 
            this.nextTask.Location = new System.Drawing.Point(554, 225);
            this.nextTask.Name = "nextTask";
            this.nextTask.Size = new System.Drawing.Size(21, 23);
            this.nextTask.TabIndex = 12;
            this.nextTask.Text = ">";
            this.nextTask.UseVisualStyleBackColor = true;
            this.nextTask.Click += new System.EventHandler(this.nextTask_Click);
            // 
            // previousTask
            // 
            this.previousTask.Location = new System.Drawing.Point(218, 225);
            this.previousTask.Name = "previousTask";
            this.previousTask.Size = new System.Drawing.Size(21, 23);
            this.previousTask.TabIndex = 13;
            this.previousTask.Text = "<";
            this.previousTask.UseVisualStyleBackColor = true;
            this.previousTask.Click += new System.EventHandler(this.previousTask_Click);
            // 
            // TaskNo
            // 
            this.TaskNo.AutoSize = true;
            this.TaskNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNo.Location = new System.Drawing.Point(387, 87);
            this.TaskNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskNo.Name = "TaskNo";
            this.TaskNo.Size = new System.Drawing.Size(25, 15);
            this.TaskNo.TabIndex = 14;
            this.TaskNo.Text = "0/X";
            // 
            // taskType
            // 
            this.taskType.AutoSize = true;
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskType.Location = new System.Drawing.Point(364, 332);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(70, 15);
            this.taskType.TabIndex = 15;
            this.taskType.Text = "Refill Water";
            // 
            // taskAnimal
            // 
            this.taskAnimal.AutoSize = true;
            this.taskAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskAnimal.Location = new System.Drawing.Point(391, 270);
            this.taskAnimal.Name = "taskAnimal";
            this.taskAnimal.Size = new System.Drawing.Size(16, 17);
            this.taskAnimal.TabIndex = 16;
            this.taskAnimal.Text = "1";
            this.taskAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskDate
            // 
            this.taskDate.AutoSize = true;
            this.taskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDate.Location = new System.Drawing.Point(330, 202);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(143, 15);
            this.taskDate.TabIndex = 17;
            this.taskDate.Text = "00-00-0000 00:00:00 AM";
            // 
            // UpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.taskDate);
            this.Controls.Add(this.taskAnimal);
            this.Controls.Add(this.taskType);
            this.Controls.Add(this.TaskNo);
            this.Controls.Add(this.previousTask);
            this.Controls.Add(this.nextTask);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AnimalLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.markCompleteButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label AnimalLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button markCompleteButton;
        private System.Windows.Forms.Button nextTask;
        private System.Windows.Forms.Button previousTask;
        private System.Windows.Forms.Label TaskNo;
        private System.Windows.Forms.Label taskType;
        private System.Windows.Forms.Label taskAnimal;
        private System.Windows.Forms.Label taskDate;
    }
}