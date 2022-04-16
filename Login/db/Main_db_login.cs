using Login.db.DB_connection;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Staff;
using Login.Interface;
using System.Collections.Generic;

namespace Login
{
    class Main_db_login : ILogin
    {
        public static bool AdminActive = false;
        public static string AdminPass = "";
        public bool AdminLogin(List<tbl_admin> adminMainList, string adminId, string adminPass)
        {
            IDb dbTest = new DataService();
            List<tbl_admin> adminList = new List<tbl_admin>();
            adminList = dbTest.GetAllAdminData();
            bool result = false;
            foreach (tbl_admin adminTest in adminList)
            {
                if (adminTest.admin_user == adminId && adminTest.admin_pass == adminPass)
                {
                    result = true;
                    if(adminTest.admin_active)
                    {
                        AdminActive = true;
                        AdminPass = adminPass;
                    }
                }

            }


            return result;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool DoctorActive = false;
        public static string DoctorPass = "";
        public bool DoctorLogin(List<tbl_doctorr> doctorMainList, string user, string pass)
        {

            IDb dbTest = new DataService();
            List<tbl_doctorr> doctorList = new List<tbl_doctorr>();
            doctorList = dbTest.GetAllDoctorData();
            bool IsLogin = false;

            foreach (tbl_doctorr dlog in doctorList)
            {
                if (dlog.doctor_pass == pass && dlog.doctor_user == user)
                {
                    IsLogin = true;
                    if (dlog.doctor_active)
                    {
                        DoctorActive = true;
                        DoctorPass = pass;
                    }
                }
            }

            return IsLogin;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool StaffActive = false;
        public static string StaffPass = "";
        public bool StaffLogin(List<tbl_Staff> staffmainlist, string user, string pass)
        {
            DataService db = new DataService();
            List<tbl_Staff> stafflog = new List<tbl_Staff>();
            stafflog = db.GetAllStaffData();
            
            bool IsLog = false;
            foreach (tbl_Staff st in stafflog)
            {
                if (st.stuff_user == user && st.stuff_pass == pass)
                    IsLog = true;
                    if(st.stuff_active)
                    {
                        StaffActive = true;
                        StaffPass = pass;
                    }

            }

            return IsLog;

        }
    }
}
