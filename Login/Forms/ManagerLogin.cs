using Login.db.DB_connection;
using Login.db.DB_connection.Admin;
using Login.Interface;
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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
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

        int x , y;
        bool mdown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mdown)
            {
                x = MousePosition.X - 300;
                y = MousePosition.Y - 30;
                this.SetDesktopLocation(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mdown = false;
        }
//////////////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
           
            bool trueLogin = false;
            try
            {
                ILogin _Login = new Main_db_login();
                List<tbl_admin> adminList = new List<tbl_admin>();
                
                trueLogin = _Login.AdminLogin(adminList, bunifuMaterialTextbox1.Text, Textbox2.Text);
            }
            catch (Exception qq) {

                MessageBox.Show(qq.Message);

            }
            
            if (trueLogin && Main_db_login.AdminActive == true) {
                ManagerPag m = new ManagerPag();
                this.Close();
                m.Show();
            }
            else if(trueLogin && Main_db_login.AdminActive == false)
            {
                MessageBox.Show("You Dont Have Access to System :( ");
            }
            else
            {
                MessageBox.Show("Wrong User or Password !");
            }
            

        }
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Textbox2.isPassword = true;
            button5.Show();
            button4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Show();
            button5.Hide();
            Textbox2.isPassword = false;
        }
        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
