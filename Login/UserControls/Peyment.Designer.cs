namespace Login.UserControls
{
    partial class Peyment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peyment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 280);
            this.dataGridView1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(804, 292);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(602, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Tbox1.HintText = "Rial";
            this.Tbox1.isPassword = false;
            this.Tbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.Tbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.Tbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Tbox1.LineThickness = 3;
            this.Tbox1.Location = new System.Drawing.Point(350, 38);
            this.Tbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox1.MaxLength = 32767;
            this.Tbox1.Name = "Tbox1";
            this.Tbox1.Size = new System.Drawing.Size(224, 37);
            this.Tbox1.TabIndex = 19;
            this.Tbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTextbox1
            // 
            this.SearchTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTextbox1.HintText = "Search Here :)";
            this.SearchTextbox1.isPassword = false;
            this.SearchTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTextbox1.LineThickness = 3;
            this.SearchTextbox1.Location = new System.Drawing.Point(75, 38);
            this.SearchTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextbox1.MaxLength = 32767;
            this.SearchTextbox1.Name = "SearchTextbox1";
            this.SearchTextbox1.Size = new System.Drawing.Size(247, 37);
            this.SearchTextbox1.TabIndex = 25;
            this.SearchTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Peyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SearchTextbox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbox1);
            this.Name = "Peyment";
            this.Size = new System.Drawing.Size(882, 748);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Tbox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTextbox1;
    }
}
