namespace Login
{
    partial class NuresePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuresePage));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.staffPayCheck1 = new Login.UserControls.StaffPayCheck();
            this.addP1 = new Login.UserControls.AddP();
            this.sendPatient1 = new Login.UserControls.SendPatient();
            this.peyment1 = new Login.UserControls.Peyment();
            this.pBill1 = new Login.UserControls.PBill();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
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
            this.button4.BackColor = System.Drawing.Color.DarkOrchid;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(41, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 38);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 36);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Fuchsia;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Delete, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(440, 101);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(152, 39);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Send";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.Fuchsia;
            this.Mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Mail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Mail.FlatAppearance.BorderSize = 0;
            this.Mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.Color.White;
            this.Mail.Location = new System.Drawing.Point(141, 101);
            this.Mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(156, 39);
            this.Mail.TabIndex = 6;
            this.Mail.Text = "Mail";
            this.Mail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mail.UseVisualStyleBackColor = false;
            this.Mail.Click += new System.EventHandler(this.Mail_Click_1);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.DarkOrchid;
            this.Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Pay, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Pay.FlatAppearance.BorderSize = 0;
            this.Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.White;
            this.Pay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pay.Location = new System.Drawing.Point(-12, 101);
            this.Pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(166, 39);
            this.Pay.TabIndex = 5;
            this.Pay.Text = "Payment";
            this.Pay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkOrchid;
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.Add, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(584, 101);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(167, 39);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(320, 8);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(431, 60);
            this.button6.TabIndex = 4;
            this.button6.Text = "Staff Preview";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Bill
            // 
            this.Bill.BackColor = System.Drawing.Color.DarkOrchid;
            this.Bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.Bill, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Bill.FlatAppearance.BorderSize = 0;
            this.Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.Color.White;
            this.Bill.Location = new System.Drawing.Point(290, 101);
            this.Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(154, 39);
            this.Bill.TabIndex = 9;
            this.Bill.Text = "Bill";
            this.Bill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bill.UseVisualStyleBackColor = false;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.Pay);
            this.panel2.Controls.Add(this.Mail);
            this.panel2.Controls.Add(this.Delete);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 143);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(742, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "PayCheck";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(23, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 78);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            // 
            // staffPayCheck1
            // 
            this.staffPayCheck1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.staffPayCheck1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.staffPayCheck1.Location = new System.Drawing.Point(0, 172);
            this.staffPayCheck1.Name = "staffPayCheck1";
            this.staffPayCheck1.Size = new System.Drawing.Size(882, 748);
            this.staffPayCheck1.TabIndex = 12;
            // 
            // addP1
            // 
            this.addP1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.addP1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.addP1.Location = new System.Drawing.Point(0, 172);
            this.addP1.Name = "addP1";
            this.addP1.Size = new System.Drawing.Size(882, 748);
            this.addP1.TabIndex = 10;
            // 
            // sendPatient1
            // 
            this.sendPatient1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.sendPatient1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sendPatient1.Location = new System.Drawing.Point(0, 172);
            this.sendPatient1.Name = "sendPatient1";
            this.sendPatient1.Size = new System.Drawing.Size(882, 748);
            this.sendPatient1.TabIndex = 9;
            // 
            // peyment1
            // 
            this.peyment1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.peyment1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.peyment1.Location = new System.Drawing.Point(0, 172);
            this.peyment1.Name = "peyment1";
            this.peyment1.Size = new System.Drawing.Size(882, 748);
            this.peyment1.TabIndex = 8;
            // 
            // pBill1
            // 
            this.pBill1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.pBill1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pBill1.Location = new System.Drawing.Point(0, 172);
            this.pBill1.Name = "pBill1";
            this.pBill1.Size = new System.Drawing.Size(882, 748);
            this.pBill1.TabIndex = 7;
            // 
            // NuresePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 921);
            this.Controls.Add(this.staffPayCheck1);
            this.Controls.Add(this.addP1);
            this.Controls.Add(this.sendPatient1);
            this.Controls.Add(this.peyment1);
            this.Controls.Add(this.pBill1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuresePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuresePage";
            this.Load += new System.EventHandler(this.NuresePage_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Mail;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private UserControls.PBill pBill1;
        private UserControls.Peyment peyment1;
        private UserControls.SendPatient sendPatient1;
        private System.Windows.Forms.Button button3;
        private UserControls.StaffPayCheck staffPayCheck1;
        private UserControls.AddP addP1;
    }
}