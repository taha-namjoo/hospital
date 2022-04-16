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

namespace Login.Forms
{
    public partial class DoctorPage : Form
    {
        
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void recivePatient1_Load(object sender, EventArgs e)
        {
            
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(staffPayCheck1);
            bunifuTransition1.HideSync(recivePatient1);
        }
        private void Insur_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(recivePatient1);
            bunifuTransition1.HideSync(staffPayCheck1);
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
            DialogResult dl = MessageBox.Show("Are you sure wanna log out ?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                doctorlogin m = new doctorlogin();
                this.Close();
                m.Show();
                Main_db_login.DoctorActive = false;
            }
        }

        private void Mail_Click(object sender, EventArgs e)
        {
         
            Process.Start("psiphon3.exe");
            Thread.Sleep(500);
            Process.Start("chrome.exe", "https://web.telegram.org/#/im");
        }
    }
}
