using Login.db.DB_connection;
using Login.db.DB_connection.Insurance;
using Login.db.Db_Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class InsuranceDebt : Form
    {
        public InsuranceDebt()
        {
            InitializeComponent();
        }

        private void InsuranceDebt_Load(object sender, EventArgs e)
        {
            DataService data = new DataService();
            List<tbl_insurance> _Insurances = new List<tbl_insurance>();
            _Insurances = data.GetAllInsuranceData();

            for (int i = 0; i < _Insurances.Capacity; i++)
            {
                comboBox1.Items.Insert(i, _Insurances[i].insurance_name);
            }

            DateTime m = DateTime.Now;
            DateTime newDate = m.AddMonths(-1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataService data = new DataService();
            List<tbl_insurance> _Insurances = new List<tbl_insurance>();
            _Insurances = data.GetAllInsuranceData();
            foreach (tbl_insurance i in _Insurances)
            {
                if (comboBox1.Text == i.insurance_name)
                    textBox1.Text = i.insurance_debt.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            if (u.sumSalary(int.Parse(textBox2.Text), comboBox2.Text))
            {
                MessageBox.Show("shod");
            }
            else
            {
                MessageBox.Show("nasho");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            textBox5.Text = s.sumSalarydoctor().ToString();
            textBox3.Text = s.sumSalarystuff().ToString();
            textBox4.Text = s.sumCostPatient().ToString();
        }
    }
}
