using Login.db.DB_connection.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Nurselogin : Form
    {
        public Nurselogin()
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (md == true)
            {
                x = MousePosition.X - 300;
                y = MousePosition.Y - 30;
                this.SetDesktopLocation(x, y);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
        }
        
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        bool IsLogin = false;
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Main_db_login _Login = new Main_db_login();
                List<tbl_Staff> stf = new List<tbl_Staff>();
                IsLogin = _Login.StaffLogin(stf, Tbox1.Text, Textbox2.Text);
            }
            catch(Exception qq)
            {
                MessageBox.Show(qq.Message);
            }

            if(IsLogin && Main_db_login.StaffActive == true)
            {
                NuresePage np = new NuresePage();
                this.Close();
                np.Show();
            }
            else if(IsLogin && Main_db_login.StaffActive == false)
            {
                MessageBox.Show("You Dont Have Access To System :(");
            }
            else
            {
                MessageBox.Show("Wrong User or Password");
            }

        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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
            Form1 ux = new Form1();
            ux.Show();
        }
    }
}
