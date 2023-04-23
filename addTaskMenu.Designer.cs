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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addTaskMenu));
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
            this.SuspendLayout();
            // 
            // comboTaskType
            // 
            resources.ApplyResources(this.comboTaskType, "comboTaskType");
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            resources.GetString("comboTaskType.Items"),
            resources.GetString("comboTaskType.Items1"),
            resources.GetString("comboTaskType.Items2"),
            resources.GetString("comboTaskType.Items3"),
            resources.GetString("comboTaskType.Items4")});
            this.comboTaskType.Name = "comboTaskType";
            // 
            // comboAnID
            // 
            resources.ApplyResources(this.comboAnID, "comboAnID");
            this.comboAnID.FormattingEnabled = true;
            this.comboAnID.Items.AddRange(new object[] {
            resources.GetString("comboAnID.Items"),
            resources.GetString("comboAnID.Items1"),
            resources.GetString("comboAnID.Items2"),
            resources.GetString("comboAnID.Items3"),
            resources.GetString("comboAnID.Items4"),
            resources.GetString("comboAnID.Items5"),
            resources.GetString("comboAnID.Items6")});
            this.comboAnID.Name = "comboAnID";
            // 
            // comboEmpID
            // 
            resources.ApplyResources(this.comboEmpID, "comboEmpID");
            this.comboEmpID.FormattingEnabled = true;
            this.comboEmpID.Items.AddRange(new object[] {
            resources.GetString("comboEmpID.Items"),
            resources.GetString("comboEmpID.Items1"),
            resources.GetString("comboEmpID.Items2"),
            resources.GetString("comboEmpID.Items3"),
            resources.GetString("comboEmpID.Items4"),
            resources.GetString("comboEmpID.Items5")});
            this.comboEmpID.Name = "comboEmpID";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblEmpID
            // 
            resources.ApplyResources(this.lblEmpID, "lblEmpID");
            this.lblEmpID.Name = "lblEmpID";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSubmitTask
            // 
            resources.ApplyResources(this.btnSubmitTask, "btnSubmitTask");
            this.btnSubmitTask.Name = "btnSubmitTask";
            this.btnSubmitTask.UseVisualStyleBackColor = true;
            this.btnSubmitTask.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // addTaskCal
            // 
            resources.ApplyResources(this.addTaskCal, "addTaskCal");
            this.addTaskCal.MinDate = new System.DateTime(2023, 4, 17, 0, 0, 0, 0);
            this.addTaskCal.Name = "addTaskCal";
            // 
            // addTaskMenu
            // 
            this.AcceptButton = this.btnSubmitTask;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}