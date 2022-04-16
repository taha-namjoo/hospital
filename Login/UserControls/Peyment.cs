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
using Login.db.DB_connection.Pationt;
using Login.db.Db_Update;
using System.IO;

namespace Login.UserControls
{
    public partial class Peyment : UserControl
    {
        public Peyment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataService service = new DataService();
            dataGridView1.DataSource = service.GetAllPateintData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_patient pdata = new tbl_patient();
            List<tbl_patient> pcost = new List<tbl_patient>();
            Update pda = new Update();
            pcost = pda.GetAllPateintData((int)(dataGridView1.CurrentRow.Cells[3].Value));


            SumPatientCost sumCust = new SumPatientCost(pcost[0].patient_cost);
            pdata.patient_cost = Convert.ToDecimal(Tbox1.Text);


            MinusDebt minus = new MinusDebt(pcost[0].patient_debt,0,0);
            pdata.patient_debt = pcost[0].patient_debt;
            

            pdata.patient_city_id = (int)(dataGridView1.CurrentRow.Cells[3].Value);


            if (pdata.patient_debt >= pdata.patient_cost)
            {
                pdata.patient_debt = minus.MinusIt(Convert.ToDecimal(Tbox1.Text));
                pdata.patient_cost = sumCust.SumIt(Convert.ToDecimal(Tbox1.Text));

                if (pda.PatientCost(pdata) && pda.PatientDebt(pdata))
                {
                    MessageBox.Show("Payment Added.");
                    string str;
                    if (File.Exists($"PBill{pdata.patient_city_id}.txt"))
                    {
                        str = File.ReadAllText($"PBill{pdata.patient_city_id}.txt");
                    }
                    else str = "";


                    TextWriter File1 = new StreamWriter($"PBill{pdata.patient_city_id}.txt");
                    File1.WriteLine(str + "پرداختی " + "        " + Tbox1.Text + "\r\n");
                    File1.Close();
                    textBox1.Text = File.ReadAllText($"PBill{pdata.patient_city_id}.txt") + "\n";
                    textBox1.Text = textBox1.Text + "Sum of Debts : " + pdata.patient_debt;
                }
            }
            else
            {
                MessageBox.Show("This Patient Dont Have any Debt Or The Cost is Greater than Debt!");
                textBox1.Text = "Payment Did Not Agreed "+"         " + "Sum of Debts : " + pdata.patient_debt;
                
            }
            
            }
    }
}
