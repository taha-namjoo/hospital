namespace Login.UserControls
{
    partial class PBill
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(680, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "تزریقات",
            "عمومی"});
            this.comboBox1.Location = new System.Drawing.Point(338, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.Tbox1.Location = new System.Drawing.Point(503, 44);
            this.Tbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox1.MaxLength = 32767;
            this.Tbox1.Name = "Tbox1";
            this.Tbox1.Size = new System.Drawing.Size(150, 37);
            this.Tbox1.TabIndex = 13;
            this.Tbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 425);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(804, 292);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 280);
            this.dataGridView1.TabIndex = 18;
            // 
            // SearchTBox
            // 
            this.SearchTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTBox.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTBox.HintText = "Sesrch Here :)";
            this.SearchTBox.isPassword = false;
            this.SearchTBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTBox.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchTBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTBox.LineThickness = 3;
            this.SearchTBox.Location = new System.Drawing.Point(52, 44);
            this.SearchTBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTBox.MaxLength = 32767;
            this.SearchTBox.Name = "SearchTBox";
            this.SearchTBox.Size = new System.Drawing.Size(258, 37);
            this.SearchTBox.TabIndex = 19;
            this.SearchTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SearchTBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tbox1);
            this.Name = "PBill";
            this.Size = new System.Drawing.Size(882, 748);
            this.Load += new System.EventHandler(this.PBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Tbox1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTBox;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
