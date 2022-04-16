namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doctor = new Login.CircleButton();
            this.manager = new Login.CircleButton();
            this.nurse = new Login.CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 82);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Managment System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login as :";
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.Color.RoyalBlue;
            this.doctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doctor.BackgroundImage")));
            this.doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doctor.FlatAppearance.BorderSize = 0;
            this.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor.Location = new System.Drawing.Point(73, 325);
            this.doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(161, 153);
            this.doctor.TabIndex = 2;
            this.doctor.UseVisualStyleBackColor = false;
            this.doctor.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // manager
            // 
            this.manager.BackColor = System.Drawing.Color.RoyalBlue;
            this.manager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manager.BackgroundImage")));
            this.manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manager.FlatAppearance.BorderSize = 0;
            this.manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager.Location = new System.Drawing.Point(275, 325);
            this.manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(157, 153);
            this.manager.TabIndex = 3;
            this.manager.UseVisualStyleBackColor = false;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // nurse
            // 
            this.nurse.BackColor = System.Drawing.Color.RoyalBlue;
            this.nurse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nurse.BackgroundImage")));
            this.nurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nurse.FlatAppearance.BorderSize = 0;
            this.nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nurse.Location = new System.Drawing.Point(483, 325);
            this.nurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nurse.Name = "nurse";
            this.nurse.Size = new System.Drawing.Size(161, 153);
            this.nurse.TabIndex = 4;
            this.nurse.UseVisualStyleBackColor = false;
            this.nurse.Click += new System.EventHandler(this.nurse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Manager";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(732, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nurse);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Mangement System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CircleButton doctor;
        private CircleButton manager;
        private CircleButton nurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

