using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Interface;
using Login;
using Login.db.DB_connection.Doctor;
using Login.Forms;

namespace Login
{
    public partial class doctorlogin : Form
    {
        public doctorlogin()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure wanna Exit ?", "EXIT", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        int x, y;
        bool md;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (md == true)
            {
                x = MousePosition.X - 300;
                y = MousePosition.Y - 30;
                this.SetDesktopLocation(x, y);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
        }
 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        bool IsLogn = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Main_db_login mdl = new Main_db_login();
                List<tbl_doctorr> docLog = new List<tbl_doctorr>();
                IsLogn = mdl.DoctorLogin(docLog, Tbox1.Text, Textbox2.Text);
            }
            catch (Exception qq)
            {
                MessageBox.Show(qq.Message);
            }

            if (IsLogn && Main_db_login.DoctorActive == true)
            {
                DoctorPage n = new DoctorPage();
                this.Close();
                n.Show();
            }
            else if(IsLogn && Main_db_login.DoctorActive == false)
            {
                MessageBox.Show("You Dont Have Access to System :( ");
            }
            else
            {
                MessageBox.Show("Wrong User or Password !");
            }

        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Show();
            button5.Hide();
            Textbox2.isPassword = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Textbox2.isPassword = true;
            button5.Show();
            button4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
