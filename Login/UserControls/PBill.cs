using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.db.DB_connection.Pationt;
using Login.db.Db_Update;
using Login.db.DB_connection;
using System.IO;
using Login.db.DB_connection.Insurance;

namespace Login.UserControls
{
    public partial class PBill : UserControl
    {
        public PBill()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataService service = new DataService();
            dataGridView1.DataSource = service.GetAllPateintData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////// ina baraye mohasebe bedehi bimar
            
            Update pda = new Update();
            MinusDebt min = new MinusDebt(0, 0, 0);
            tbl_patient pdata = new tbl_patient();
            List<tbl_patient> patientdata = new List<tbl_patient>();
            patientdata = pda.GetAllPateintData((int)(dataGridView1.CurrentRow.Cells[3].Value));
            SumPatientCost sumCust = new SumPatientCost(patientdata[0].patient_debt);
            pdata.patient_debt = sumCust.SumIt(min.petientDebt(Convert.ToDecimal(Tbox1.Text), patientdata[0].patient_i_type));

            /////////////////////////////////////////////////// ina baraye mohasebe bedehi bime

            DataService service = new DataService();
            List<tbl_insurance> insuracedata = new List<tbl_insurance>();
            insuracedata = service.GetAllInsuranceData();
            tbl_insurance idata = new tbl_insurance();

            foreach (tbl_insurance i in insuracedata)
            {
                if(string.Compare(i.insurance_name,patientdata[0].patient_i_type)==0)
                {
                    SumPatientCost suminsurancedebt = new SumPatientCost(i.insurance_debt);
                    idata.insurance_debt=suminsurancedebt.SumIt(MinusDebt.Insurancedebt);
                    idata.insurance_name = i.insurance_name;
                    
                }
            }

            Update up = new Update();
            up.UpdateInsuranceDebt(idata);

             /////////////////////////////////////////////////////////////
                pdata.patient_city_id = (int)(dataGridView1.CurrentRow.Cells[3].Value);
                pdata.patient_service = comboBox1.Text;

                if (pda.PatientDebt(pdata))
                {
                    MessageBox.Show("Cost and Service Added.");

                }
                else
                    MessageBox.Show("Its not o k haji!!!!");


                string str;
                if (File.Exists($"PBill{pdata.patient_city_id}.txt"))
                {
                    str = File.ReadAllText($"PBill{pdata.patient_city_id}.txt");
                }
                else str = "";


                TextWriter File1 = new StreamWriter($"PBill{pdata.patient_city_id}.txt");
                File1.WriteLine(str + comboBox1.Text + "        " + Tbox1.Text + "\r\n");
                File1.Close();


                textBox1.Text = File.ReadAllText($"PBill{pdata.patient_city_id}.txt") + "\n" + "Sum of debts :" + pdata.patient_debt;

            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PBill_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
