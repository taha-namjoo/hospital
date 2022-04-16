using Login.db.DB_connection;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Pationt;
using Login.db.DB_connection.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Salary
    {
        int sumD;
        int sumS;
        decimal sumP;
        public int sumSalarydoctor()
        {
            DateTime myDate = DateTime.Now;
            string Now = myDate.Month.ToString() + "/" + myDate.Day.ToString() + "/" + myDate.Year.ToString();
            DateTime newDate = myDate.AddMonths(-1);
            string ago = newDate.Month.ToString() + "/" + newDate.Day.ToString() + "/" + newDate.Year.ToString();
            tbl_doctorr tbl_ = new tbl_doctorr();
            List<tbl_doctorr> tbl_s = new List<tbl_doctorr>();
            DataService data = new DataService();
            tbl_s = data.GetSUMDoctorSalary(ago, Now);
            foreach (tbl_doctorr b in tbl_s)
            {
                sumD += b.doctor_salary;
            }

            return sumD;
        }

        public int sumSalarystuff()
        {
            DateTime myDate = DateTime.Now;
            string Now = myDate.Month.ToString() + "/" + myDate.Day.ToString() + "/" + myDate.Year.ToString();
            DateTime newDate = myDate.AddMonths(-1);
            string ago = newDate.Month.ToString() + "/" + newDate.Day.ToString() + "/" + newDate.Year.ToString();
            tbl_Staff tbl_ = new tbl_Staff();
            List<tbl_Staff> tbl_s = new List<tbl_Staff>();
            DataService data = new DataService();
            tbl_s = data.GetSUMstuffSalary(ago, Now);
            foreach (tbl_Staff b in tbl_s)
            {
                sumS += b.stuff_salary;
            }
            return sumS;
        }

        public decimal sumCostPatient()
        {
            DateTime myDate = DateTime.Now;
            string Now = myDate.Month.ToString() + "/" + myDate.Day.ToString() + "/" + myDate.Year.ToString();
            DateTime newDate = myDate.AddMonths(-6);
            string ago = newDate.Month.ToString() + "/" + newDate.Day.ToString() + "/" + newDate.Year.ToString();
            tbl_patient tbl_ = new tbl_patient();
            List<tbl_patient> tbl_s = new List<tbl_patient>();
            DataService data = new DataService();
            tbl_s = data.GetSUMpatientcost(ago, Now);
            foreach (tbl_patient b in tbl_s)
            {
                sumP += b.patient_cost;
            }
            return sumP;
        }
    }
}
