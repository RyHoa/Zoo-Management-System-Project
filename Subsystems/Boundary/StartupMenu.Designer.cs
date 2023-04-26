namespace ZooManagementSystemBoundary
{
    partial class StartupMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupMenu));
            this.picZooLogo = new System.Windows.Forms.PictureBox();
            this.picZebra = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picZooLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZebra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picZooLogo
            // 
            this.picZooLogo.Image = ((System.Drawing.Image)(resources.GetObject("picZooLogo.Image")));
            this.picZooLogo.Location = new System.Drawing.Point(152, 11);
            this.picZooLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picZooLogo.Name = "picZooLogo";
            this.picZooLogo.Size = new System.Drawing.Size(477, 69);
            this.picZooLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picZooLogo.TabIndex = 2;
            this.picZooLogo.TabStop = false;
            // 
            // picZebra
            // 
            this.picZebra.Image = ((System.Drawing.Image)(resources.GetObject("picZebra.Image")));
            this.picZebra.Location = new System.Drawing.Point(203, 154);
            this.picZebra.Margin = new System.Windows.Forms.Padding(2);
            this.picZebra.Name = "picZebra";
            this.picZebra.Size = new System.Drawing.Size(148, 116);
            this.picZebra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZebra.TabIndex = 3;
            this.picZebra.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.login);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name: Carl\r\nDiet: Herbivore\r\nSpecies: Zebra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name: Chanel\r\nDiet: Herbivore\r\nSpecies: Long Neck Boi";
            // 
            // StartupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picZebra);
            this.Controls.Add(this.picZooLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartupMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Management System";
            ((System.ComponentModel.ISupportInitialize)(this.picZooLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZebra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picZooLogo;
        private System.Windows.Forms.PictureBox picZebra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}