using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.db.DB_connection;
using Login.db.Db_Update;
using System.IO;
using Login.db.DB_connection.Pationt;

namespace Login.UserControls
{
    public partial class RecivePatient : UserControl
    {
        public RecivePatient()
        {
            InitializeComponent();
        }

        private void RecivePatient_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update p = new Update();
            tbl_patient pdata = new tbl_patient();
          
            pdata.patient_city_id = Convert.ToInt32((int)(dataGridView1.CurrentRow.Cells[3].Value));
            string n = textBox1.Text;
            int n1 = (int)dataGridView1.CurrentRow.Cells[3].Value;

            if (p.PatientIllness(n, n1))
            {
                MessageBox.Show("shod..");
            }
            else
                MessageBox.Show("nshod..");



            string str;

            if (File.Exists($"PHistory{pdata.patient_city_id}.txt"))
            {
                str = File.ReadAllText($"PHistory{pdata.patient_city_id}.txt");
            }
            else str = "";


            TextWriter File1 = new StreamWriter($"PHistory{pdata.patient_city_id}.txt");
            File1.WriteLine(str + dateTimePicker1.Text + "        " + textBox1.Text + "\r\n");
            File1.Close();


            textBox2.Text = File.ReadAllText($"PHistory{pdata.patient_city_id}.txt") + "\n";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataService service = new DataService();
            dataGridView1.DataSource = service.TruePatients();
        }
    }
}
