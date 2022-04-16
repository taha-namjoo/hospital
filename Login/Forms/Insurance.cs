using Login.db.DB_connection.Insurance;
using Login.db.Db_Insert;
using Login.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login.Forms
{
    public partial class Insurance : Form
    {
        
        public Insurance()
        {
            
            InitializeComponent();
            Tbox2.Enabled = false;
        }

        private void Agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (Agreement.Checked == true)
                Tbox2.Enabled = true;
            else
                Tbox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inser inser = new Inser();
            tbl_insurance insertinsurance = new tbl_insurance();
            insertinsurance.insurance_name = Tbox1.Text;
            insertinsurance.insurance_percent_cost = decimal.Parse(Tbox2.Text);
      
          

            if (inser.InsertInsurance(insertinsurance))
            {
                MessageBox.Show("Insurance Added");
                

            }
            else
                MessageBox.Show("Its Not Ok");

           
        }
    }
}
