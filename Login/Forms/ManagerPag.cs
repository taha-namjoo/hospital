using Login.db.DB_connection;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Category;
using Login.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ManagerPag : Form
    {
        bool hidden2;
        int pwith;
        public ManagerPag()
        {
            InitializeComponent();
            hidden2 = true;
            pwith = panel3.Width;
            panel3.Width = 0;
            dataGrid1.Visible = true;
            addD1.Visible = true;
           // mail1.Visible = false;
          
        }

        int x, y;
        bool mdown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mdown)
            {
                x = MousePosition.X - 400;
                y = MousePosition.Y - 20;
                this.SetDesktopLocation(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mdown = false;
        }
     
/////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hidden2)
            {

                panel3.Width += 20;
                if (panel3.Width >= pwith)
                {
                    timer2.Stop();
                    hidden2 = false;
                    this.Refresh();
                }

            }
            else
            {
                panel3.Width -= 20;
                if (panel3.Width <= 0)
                {
                    timer2.Stop();
                    hidden2 = true;
                    this.Refresh();
                }

            }
        }

/////////////////////////////////////////////////////////////////////////////////////////////////

        private void circleButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(dataGrid1);
            bunifuTransition1.ShowSync(addD1);
            bunifuTransition1.HideSync(staffPayCheck1);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(addD1);
            bunifuTransition1.ShowSync(dataGrid1);
            bunifuTransition1.HideSync(staffPayCheck1);

        }

        private void Mail_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo start1 = new ProcessStartInfo();
            //start1.Arguments = "psiphon3.exe";
            //start1.FileName = "C:\\Users\\CHR\\Downloads\\psiphon3.exe";
            //start1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start("psiphon3.exe");
            Thread.Sleep(500);
            Process.Start("chrome.exe","https://web.telegram.org/#/im");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(addD1);
            bunifuTransition1.HideSync(dataGrid1);
            bunifuTransition1.ShowSync(staffPayCheck1);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Insurance i = new Insurance();
            i.Show();
        }


        private void ManagerPag_Load(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure wanna Exit ?", "EXIT", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure wanna log out ?","LOG OUT",MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                ManagerLogin m = new ManagerLogin();
                this.Close();
                m.Show();
                Main_db_login.AdminActive = false;
            }


        }

        private void dataGrid1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bill_Click(object sender, EventArgs e)
        {
            InsuranceDebt id = new InsuranceDebt();
            id.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
