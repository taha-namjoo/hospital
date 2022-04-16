using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.db.DB_connection.Staff;
using Login.db.DB_connection;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Doctor;

namespace Login.UserControls
{
    public partial class StaffPayCheck : UserControl
    {
        public StaffPayCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();

            if (Main_db_login.StaffActive)
            {
                List<tbl_Staff> staffList = new List<tbl_Staff>();
                staffList = dataService.GetAllStaffData();
                foreach (tbl_Staff x in staffList)
                {
                    if (Main_db_login.StaffPass == x.stuff_pass)
                    {

                        NameTbox.Text = x.stuff_firstname.ToString();
                        FamilyTbox.Text = x.stuff_lastname;
                        double _nohDarsadAzSalary = (0.09 * Convert.ToInt32(x.stuff_salary));
                        IncomeTax.Text = _nohDarsadAzSalary.ToString();
                        AddvanTBox.Text = x.stuff_salary.ToString();
                        string pay = ((Convert.ToDouble(x.stuff_salary)) - (_nohDarsadAzSalary)).ToString();
                        PMonthTbox.Text = pay;
                        PYearTbox.Text = (12 * Convert.ToDouble(pay)).ToString();
                    }
                }
            }

            else if (Main_db_login.AdminActive)
            {
                List<tbl_admin> adminList = new List<tbl_admin>();
                adminList = dataService.GetAllAdminData();
                foreach (tbl_admin x in adminList)
                {
                    if (Main_db_login.AdminPass == x.admin_pass)
                    {

                        NameTbox.Text = x.admin_firstname.ToString();
                        FamilyTbox.Text = x.admin_lastname;
                        double _nohDarsadAzSalary = (0.09 * Convert.ToInt32(x.admin_salary));
                        IncomeTax.Text = _nohDarsadAzSalary.ToString();
                        AddvanTBox.Text = x.admin_salary;
                        string pay = ((Convert.ToDouble(x.admin_salary)) - (_nohDarsadAzSalary)).ToString();
                        PMonthTbox.Text = pay;
                        PYearTbox.Text = (12 * Convert.ToDouble(pay)).ToString();

                    }
                }
            }

            else if (Main_db_login.DoctorActive)
            {
                List<tbl_doctorr> doctorList = new List<tbl_doctorr>();
                doctorList = dataService.GetAllDoctorData();
                foreach (tbl_doctorr x in doctorList)
                {
                    if (Main_db_login.DoctorPass == x.doctor_pass)
                    {

                        NameTbox.Text = x.doctor_firstname;
                        FamilyTbox.Text = x.doctor_lastname;
                        double _nohDarsadAzSalary = (0.09 * Convert.ToInt32(x.doctor_salary));
                        IncomeTax.Text = _nohDarsadAzSalary.ToString();
                        AddvanTBox.Text = x.doctor_salary.ToString();
                        string pay = ((Convert.ToDouble(x.doctor_salary)) - (_nohDarsadAzSalary)).ToString();
                        PMonthTbox.Text = pay;
                        PYearTbox.Text = (12 * Convert.ToDouble(pay)).ToString();

                    }
                }
            }
        }
    }
}
