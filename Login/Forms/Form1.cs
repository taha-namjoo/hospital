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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            doctorlogin dl = new doctorlogin();
            this.Hide();
            dl.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void manager_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            this.Hide();
            ml.Show();

        }

        private void nurse_Click(object sender, EventArgs e)
        {
            Nurselogin nu = new Nurselogin();
            this.Hide();
            nu.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
