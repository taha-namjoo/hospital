using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.db.Db_Insert;
using Login.db.DB_connection.Pationt;
using Login.db.Db_Update;
using Login.Forms;
using System.IO;
using Login.db.DB_connection.Insurance;
using Login.db.DB_connection;

namespace Login.UserControls
{
    public partial class AddP : UserControl
    {
        public bool flag;
        public AddP()
        {
            InitializeComponent();
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inser inser = new Inser();
            tbl_patient pdata = new tbl_patient();
            pdata.patient_firstname = Tbox1.Text;
            pdata.patient_lastname = Tbox2.Text;
            pdata.patient_city_id = int.Parse(Tbox3.Text);
            pdata.patient_gender = Tbox4.Text;
            pdata.patient_address = Tbox5.Text;
            pdata.patient_birthday = Tbox6.Text;
            pdata.patient_phonenumber = Tbox7.Text;
            //pdata.patient_debt = decimal.Parse(Tbox8.Text);
            pdata.patient_i_type = comboBox1.Text;
            pdata.patient_i_code = int.Parse(Tbox10.Text);
            pdata.patient_history = Tbox11.Text;
           // pdata.patient_cost = decimal.Parse(bunifuMaterialTextbox1.Text);

            if (inser.InsertPatientData(pdata))
            {
                MessageBox.Show("New Patient Added.");

            }
            else
                MessageBox.Show("Its not o k haji!!!!");

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            Update up = new Update();
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {

            if (flag)
            {
                DataService data = new DataService();
                List<tbl_insurance> _Insurances = new List<tbl_insurance>();
                _Insurances = data.GetAllInsuranceData();

                for (int i = 0; i < _Insurances.Capacity; i++)
                {
                    comboBox1.Items.Insert(i, _Insurances[i].insurance_name);
                }
                flag = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
