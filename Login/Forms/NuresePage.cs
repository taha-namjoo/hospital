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
using Login.db.DB_connection;
using Login.Forms;
using Login.UserControls;
using MySql.Data.MySqlClient;

namespace Login
{

    public partial class NuresePage : Form
    {
        bool hidden2;
        int pwith;
        public NuresePage()
        {
            InitializeComponent();
            hidden2 = true;
            pwith = panel3.Width;
            panel3.Width = 0;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden2)
            {

                panel3.Width += 20;
                if (panel3.Width >= pwith)
                {
                    timer1.Stop();
                    hidden2 = false;
                    this.Refresh();
                }

            }
            else
            {
                panel3.Width -= 20;
                if (panel3.Width <= 0)
                {
                    timer1.Stop();
                    hidden2 = true;
                    this.Refresh();
                }

            }
        }
//////////////////////////////////////////////////////////////////////////////////////

        int x, y;
        bool mp;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mp)
            {
                x = MousePosition.X - 400;
                y = MousePosition.Y - 20;
                this.SetDesktopLocation(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mp = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mp = true;
        }

//////////////////////////////////////////////////////////////////////////////////////


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure wanna Exit ?", "EXIT", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure wanna log out ?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Nurselogin m = new Nurselogin();
                this.Close();
                m.Show();
                Main_db_login.StaffActive = false;
            }
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(pBill1);
            bunifuTransition1.HideSync(sendPatient1);
            bunifuTransition1.ShowSync(addP1);
            bunifuTransition1.HideSync(peyment1);
            bunifuTransition1.HideSync(staffPayCheck1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(sendPatient1);
            bunifuTransition1.HideSync(pBill1);
            bunifuTransition1.HideSync(addP1);
            bunifuTransition1.HideSync(peyment1);      
            bunifuTransition1.HideSync(staffPayCheck1);
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(pBill1);
            bunifuTransition1.HideSync(sendPatient1);
            bunifuTransition1.HideSync(addP1);
            bunifuTransition1.HideSync(peyment1);   
            bunifuTransition1.HideSync(staffPayCheck1);
        }

        private void Pay_Click(object sender, EventArgs e)
        {

            bunifuTransition1.ShowSync(peyment1);
            bunifuTransition1.HideSync(pBill1);
            bunifuTransition1.HideSync(sendPatient1);
            bunifuTransition1.HideSync(addP1); 
            bunifuTransition1.HideSync(staffPayCheck1);
        }
       
        private void Mail_Click_1(object sender, EventArgs e)
        {
           
            Process.Start("psiphon3.exe");
            Thread.Sleep(500);
            Process.Start("chrome.exe", "https://web.telegram.org/#/im");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(pBill1);
            bunifuTransition1.HideSync(sendPatient1);
            bunifuTransition1.ShowSync(staffPayCheck1);
            bunifuTransition1.HideSync(peyment1);
            bunifuTransition1.HideSync(addP1);
           
        }

        private void peyment1_Load(object sender, EventArgs e)
        {
            
        }

        private void addP2_Load(object sender, EventArgs e)
        {

        }
        private void pBill1_Load(object sender, EventArgs e)
        {

        }

        private void pBill1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void NuresePage_Load(object sender, EventArgs e)
        {

        }
       
    }

    }
