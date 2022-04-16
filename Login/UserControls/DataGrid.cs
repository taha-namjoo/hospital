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
using Login.db.Db_Delete;
using Login.db.Db_Update;
using Login.db.Db_Insert;
using Login.db.Search;

namespace Login
{
    public partial class DataGrid : UserControl
    {
        public string n = "";
        public DataGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            Search sch = new Search();
            dataGridView1.DataSource = sch.search(bunifuMaterialTextbox1.Text);
            n = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataService service = new DataService();
           // string query = "Select * from tbl_stuff";
            switch(comboBox1.Text)
            {
                case "Doctor":
                    dataGridView1.DataSource = service.GetAllDoctorData();break;
                case "Staff":
                    dataGridView1.DataSource = service.GetAllStaffData();break;
            }
            n = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            Delete userdl = new Delete();
            //int n = (int)dataGridView1.CurrentRow.Cells[7].Value;

            if (n == "")
                MessageBox.Show("First Chose User!");
            else
            {
                DialogResult dl = MessageBox.Show("Are you sure wanna Delete User ?", "Delete", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    switch (comboBox1.Text)
                    {

                        case "Doctor":
                            {
                                if (userdl.DeleteDoctorData(n))
                                {
                                    MessageBox.Show("Deleted");
                                }
                                else
                                    MessageBox.Show("Its not ok");
                            }
                            break;
                        case "Staff":
                            {
                                if (userdl.DeleteStaffData(n))
                                {
                                    MessageBox.Show("Deleted");
                                }
                                else
                                    MessageBox.Show("Its not ok");
                            }
                            break;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Update p = new Update();
            bool n = (bool)dataGridView1.CurrentRow.Cells[3].Value;
            string n1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (checkBox1.Checked)
            {
                n = true;
                if (comboBox1.Text == "Staff")
                    p.StaffAccess(n, n1);
                else
                    p.DoctorAccess(n, n1);

            }
            else
            {
                n = false;
                if (comboBox1.Text == "Staff")
                    p.StaffAccess(n, n1);
                else
                    p.DoctorAccess(n, n1);
            }
        }
    }
}
