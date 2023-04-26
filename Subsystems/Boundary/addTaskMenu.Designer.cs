namespace ZooManagementSystemBoundary
{
    partial class addTaskMenu 
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
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.comboAnID = new System.Windows.Forms.ComboBox();
            this.comboEmpID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubmitTask = new System.Windows.Forms.Button();
            this.addTaskCal = new System.Windows.Forms.MonthCalendar();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuccessMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTaskType
            // 
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            "Refill Food",
            "Refill Water",
            "Clean Habitat",
            "Enrichment Activity"});
            this.comboTaskType.Location = new System.Drawing.Point(174, 366);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(121, 21);
            this.comboTaskType.TabIndex = 22;
            this.comboTaskType.SelectedIndexChanged += new System.EventHandler(this.comboTaskType_SelectedIndexChanged);
            // 
            // comboAnID
            // 
            this.comboAnID.FormattingEnabled = true;
            this.comboAnID.Items.AddRange(new object[] {
            "0001",
            "0002"});
            this.comboAnID.Location = new System.Drawing.Point(174, 251);
            this.comboAnID.Name = "comboAnID";
            this.comboAnID.Size = new System.Drawing.Size(121, 21);
            this.comboAnID.TabIndex = 21;
            this.comboAnID.SelectedIndexChanged += new System.EventHandler(this.comboAnID_SelectedIndexChanged);
            // 
            // comboEmpID
            // 
            this.comboEmpID.FormattingEnabled = true;
            this.comboEmpID.Items.AddRange(new object[] {
            "1001",
            "1002",
            "1003",
            "1004",
            "1005"});
            this.comboEmpID.Location = new System.Drawing.Point(174, 138);
            this.comboEmpID.Name = "comboEmpID";
            this.comboEmpID.Size = new System.Drawing.Size(121, 21);
            this.comboEmpID.TabIndex = 20;
            this.comboEmpID.SelectedIndexChanged += new System.EventHandler(this.comboEmpID_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(306, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Add a Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(423, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose a Task Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(171, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose a task type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(171, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose Animal ID:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpID.Location = new System.Drawing.Point(171, 108);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(109, 13);
            this.lblEmpID.TabIndex = 15;
            this.lblEmpID.Text = "Choose Employee ID:";
            // 
            // btnLogout
            // 
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(675, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 33);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.logout);
            // 
            // btnSubmitTask
            // 
            this.btnSubmitTask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmitTask.Location = new System.Drawing.Point(449, 354);
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.Size = new System.Drawing.Size(158, 40);
            this.btnSubmitTask.TabIndex = 13;
            this.btnSubmitTask.Text = "Submit Task";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.submit);
            // 
            // addTaskCal
            // 
            this.addTaskCal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addTaskCal.Location = new System.Drawing.Point(426, 150);
            this.addTaskCal.MinDate = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.addTaskCal.Name = "addTaskCal";
            this.addTaskCal.ShowTodayCircle = false;
            this.addTaskCal.TabIndex = 12;
            this.addTaskCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.addTaskCal_DateChanged_1);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "ID: ";
            // 
            // SuccessMessage
            // 
            this.SuccessMessage.AutoSize = true;
            this.SuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.SuccessMessage.Location = new System.Drawing.Point(465, 323);
            this.SuccessMessage.Name = "SuccessMessage";
            this.SuccessMessage.Size = new System.Drawing.Size(123, 13);
            this.SuccessMessage.TabIndex = 24;
            this.SuccessMessage.Text = "You\'ve submitted a task!";
            this.SuccessMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuccessMessage.Visible = false;
            // 
            // addTaskMenu
            // 
            this.AcceptButton = this.btnSubmitTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.SuccessMessage);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.comboTaskType);
            this.Controls.Add(this.comboAnID);
            this.Controls.Add(this.comboEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSubmitTask);
            this.Controls.Add(this.addTaskCal);
            this.Name = "addTaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.ComboBox comboAnID;
        private System.Windows.Forms.ComboBox comboEmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSubmitTask;
        private System.Windows.Forms.MonthCalendar addTaskCal;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label SuccessMessage;
    }
}