namespace ZooManagementSystemBoundary
{
    partial class LogoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.picZooLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picZooLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have successfully logged out. Have a nice day!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picZooLogo
            // 
            this.picZooLogo.Image = ((System.Drawing.Image)(resources.GetObject("picZooLogo.Image")));
            this.picZooLogo.Location = new System.Drawing.Point(4, 93);
            this.picZooLogo.Name = "picZooLogo";
            this.picZooLogo.Size = new System.Drawing.Size(776, 56);
            this.picZooLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picZooLogo.TabIndex = 1;
            this.picZooLogo.TabStop = false;
            this.picZooLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(334, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Return Home";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.picZooLogo);
            this.Controls.Add(this.label1);
            this.Name = "LogoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logout";
            ((System.ComponentModel.ISupportInitialize)(this.picZooLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picZooLogo;
        private System.Windows.Forms.Button btnLogout;
    }
}