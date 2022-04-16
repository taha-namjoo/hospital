using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.db.Db_Update;
using Login.db.DB_connection;

namespace Login.UserControls
{
    public partial class SendPatient : UserControl
    {
        public SendPatient()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SendPatient_Load(object sender, EventArgs e)
        {
            //DataService service = new DataService();
            //dataGridView1.DataSource = service.GetAllPateintData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataService service = new DataService();
            dataGridView1.DataSource = service.GetAllPateintData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update Send = new Update();
            bool n = (bool)dataGridView1.CurrentRow.Cells[16].Value;
            string n1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            n = true;
            
            if (Send.PatientAccess(n, n1))
            {
                MessageBox.Show("Sent....");
            }
            else
            {
                MessageBox.Show("Not Sent....");
            }
        }
    }
}
