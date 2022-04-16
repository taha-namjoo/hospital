namespace Login.Forms
{
    partial class Insurance
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Tbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Agreement = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Percentage : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Insurance Name :";
            // 
            // Tbox2
            // 
            this.Tbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Tbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Tbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Tbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Tbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tbox2.HintForeColor = System.Drawing.Color.Empty;
            this.Tbox2.HintText = "Percentage";
            this.Tbox2.isPassword = false;
            this.Tbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.Tbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.Tbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Tbox2.LineThickness = 3;
            this.Tbox2.Location = new System.Drawing.Point(173, 100);
            this.Tbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox2.MaxLength = 32767;
            this.Tbox2.Name = "Tbox2";
            this.Tbox2.Size = new System.Drawing.Size(177, 34);
            this.Tbox2.TabIndex = 36;
            this.Tbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tbox1
            // 
            this.Tbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Tbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Tbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Tbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Tbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tbox1.HintForeColor = System.Drawing.Color.Empty;
            this.Tbox1.HintText = "Name";
            this.Tbox1.isPassword = false;
            this.Tbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.Tbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.Tbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Tbox1.LineThickness = 3;
            this.Tbox1.Location = new System.Drawing.Point(173, 39);
            this.Tbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox1.MaxLength = 32767;
            this.Tbox1.Name = "Tbox1";
            this.Tbox1.Size = new System.Drawing.Size(177, 31);
            this.Tbox1.TabIndex = 35;
            this.Tbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Agreement
            // 
            this.Agreement.AutoSize = true;
            this.Agreement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agreement.Location = new System.Drawing.Point(416, 52);
            this.Agreement.Name = "Agreement";
            this.Agreement.Size = new System.Drawing.Size(113, 22);
            this.Agreement.TabIndex = 39;
            this.Agreement.Text = "Agreement";
            this.Agreement.UseVisualStyleBackColor = true;
            this.Agreement.CheckedChanged += new System.EventHandler(this.Agreement_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(194)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(163, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 56);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agreement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbox2);
            this.Controls.Add(this.Tbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Insurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Tbox2;
        private System.Windows.Forms.CheckBox Agreement;
        private System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Tbox1;
    }
}