namespace Login.Forms
{
    partial class DoctorPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPage));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.circleButton1 = new Login.CircleButton();
            this.Insur = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.staffPayCheck1 = new Login.UserControls.StaffPayCheck();
            this.recivePatient1 = new Login.UserControls.RecivePatient();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.circleButton1);
            this.panel2.Controls.Add(this.Insur);
            this.panel2.Controls.Add(this.Mail);
            this.panel2.Controls.Add(this.Delete);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 143);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.button4);
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(109, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 42);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(35, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 38);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(317, 7);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(431, 60);
            this.button6.TabIndex = 4;
            this.button6.Text = "Doctor Preview";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // circleButton1
            // 
            this.circleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleButton1.BackgroundImage")));
            this.circleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.circleButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Location = new System.Drawing.Point(12, 5);
            this.circleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(91, 82);
            this.circleButton1.TabIndex = 1;
            this.circleButton1.UseVisualStyleBackColor = true;
            // 
            // Insur
            // 
            this.Insur.BackColor = System.Drawing.Color.DarkGreen;
            this.Insur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Insur, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Insur.FlatAppearance.BorderSize = 0;
            this.Insur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insur.ForeColor = System.Drawing.Color.White;
            this.Insur.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Insur.Location = new System.Drawing.Point(-12, 101);
            this.Insur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insur.Name = "Insur";
            this.Insur.Size = new System.Drawing.Size(292, 39);
            this.Insur.TabIndex = 5;
            this.Insur.Text = "Receive";
            this.Insur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Insur.UseVisualStyleBackColor = false;
            this.Insur.Click += new System.EventHandler(this.Insur_Click);
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.LimeGreen;
            this.Mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Mail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Mail.FlatAppearance.BorderSize = 0;
            this.Mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.Color.White;
            this.Mail.Location = new System.Drawing.Point(275, 101);
            this.Mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(323, 39);
            this.Mail.TabIndex = 6;
            this.Mail.Text = "Mail";
            this.Mail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mail.UseVisualStyleBackColor = false;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkGreen;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Delete, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(590, 101);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(292, 39);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "PayCheck";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 36);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(837, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel3;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 17;
            // 
            // staffPayCheck1
            // 
            this.staffPayCheck1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.staffPayCheck1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.staffPayCheck1.Location = new System.Drawing.Point(0, 171);
            this.staffPayCheck1.Name = "staffPayCheck1";
            this.staffPayCheck1.Size = new System.Drawing.Size(882, 748);
            this.staffPayCheck1.TabIndex = 10;
            // 
            // recivePatient1
            // 
            this.bunifuTransition1.SetDecoration(this.recivePatient1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.recivePatient1.Location = new System.Drawing.Point(0, 171);
            this.recivePatient1.Name = "recivePatient1";
            this.recivePatient1.Size = new System.Drawing.Size(882, 748);
            this.recivePatient1.TabIndex = 9;
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 884);
            this.Controls.Add(this.staffPayCheck1);
            this.Controls.Add(this.recivePatient1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPage";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private CircleButton circleButton1;
        private System.Windows.Forms.Button Insur;
        private System.Windows.Forms.Button Mail;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private UserControls.RecivePatient recivePatient1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private UserControls.StaffPayCheck staffPayCheck1;
    }
}