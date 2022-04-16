using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.db.Db_Insert;
using System.Windows.Forms;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Staff;
using Login.db.DB_connection.Pationt;

namespace Login.UserControls
{
    public partial class AddD : UserControl
    {
        bool hidden;
        int panelw;
        public AddD()
        {
            InitializeComponent();
           
            panelw = panelslide1.Width;
            hidden = true;
            panelslide1.Width = 0;

            {
                if (Tbox6.Text == "" && Tbox1.Text == "" && Tbox2.Text == "" && Tbox3.Text == "" && Tbox5.Text == "" && Tbox8.Text == "")
                    button3.Enabled = false;

                if (Tbox4.Enabled == true)
                {
                    if (Tbox4.Text == "")
                        button3.Enabled = false;
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(panelslide1.Width == 0) { label5.Visible = true; Tbox4.Visible = true; Tbox4.Enabled = true; }

            { Tbox1.Text = ""; Tbox2.Text = ""; Tbox3.Text = ""; Tbox4.Text = ""; Tbox5.Text = ""; Tbox6.Text = ""; Tbox8.Text = ""; }

            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(panelslide1.Width == 0){ label5.Visible = false; Tbox4.Visible = false; Tbox4.Enabled = false; }

            { Tbox1.Text = ""; Tbox2.Text = ""; Tbox3.Text = ""; Tbox4.Text = ""; Tbox5.Text = ""; Tbox6.Text = ""; Tbox8.Text = ""; }

            timer1.Start();
        }

       

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelslide1.Width += 40;
                if (panelslide1.Width >= panelw)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                panelslide1.Width -= 40;
                if (panelslide1.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Tbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox1.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox8_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox8.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox6_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox6.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox5.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox3_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox3.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox2.Text == "") button3.Enabled = false;
            else button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void Tbox4_OnValueChanged(object sender, EventArgs e)
        {
            if (Tbox4.Text == "") button3.Enabled = false;
            else
                button3.Enabled = true;
            if (Tbox6.Text.Length > 10 || Tbox6.Text.Length < 10)
                button3.Enabled = false;
        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {
            if (Tbox6.Text == "" || Tbox1.Text == "" || Tbox2.Text == "" || Tbox3.Text == "" || Tbox5.Text == "" || Tbox8.Text == "")
                button3.Enabled = false;

            if (Tbox4.Enabled == true)
            {
                if (Tbox4.Text == "")
                    button3.Enabled = false;
            }
        }

        private void Tbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Tbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Tbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void panelslide1_Paint(object sender, PaintEventArgs e)
        {

        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void button3_Click(object sender, EventArgs e)
        {
            Inser insert = new Inser();

            tbl_doctorr doctorData = new tbl_doctorr();
            doctorData.doctor_user = User.Text;
            doctorData.doctor_pass = pass.Text;
            doctorData.doctor_firstname = Tbox1.Text;
            doctorData.doctor_lastname = Tbox8.Text;
            doctorData.doctor_city_id = Tbox6.Text;
            doctorData.doctor_birthday = dateTimePicker1.Text;
            doctorData.doctor_salary = int.Parse(Tbox5.Text);
            doctorData.doctor_gender = comboBox1.Text;
            doctorData.doctor_phonenumber = Tbox3.Text;
            doctorData.doctor_address = Tbox2.Text;

            tbl_Staff staffData = new tbl_Staff();
            staffData.stuff_user = User.Text;
            staffData.stuff_pass = pass.Text;
            staffData.stuff_firstname = Tbox1.Text;
            staffData.stuff_lastname = Tbox8.Text;
            staffData.stuff_city_id = Tbox6.Text;
            staffData.stuff_birthday = dateTimePicker1.Text;
            staffData.stuff_salary = int.Parse(Tbox5.Text);
            staffData.stuff_gender = comboBox1.Text;
            staffData.stuff_phonenumber = Tbox3.Text;
            staffData.stuff_address = Tbox2.Text;


            if (Tbox4.Visible)
            {

                doctorData.doctor_MSVC = Tbox4.Text;

                if (insert.InsertDoctorData(doctorData))
                {
                    MessageBox.Show("New Doctor Added.");

                }
                else
                    MessageBox.Show("Its not o k haji!!!!");
            }
            else
            {
                if (insert.InsertStaffData(staffData))
                {
                    MessageBox.Show("New Staff Added.");
                }
                else
                    MessageBox.Show("Its not ok");
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
