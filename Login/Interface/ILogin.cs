using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Interface
{
    interface ILogin
    {

        bool AdminLogin(List<tbl_admin> adminMainList, string adminId, string adminPass);
        bool DoctorLogin(List<tbl_doctorr> doctorMainList , string user, string pass);
        bool StaffLogin(List<tbl_Staff> staffmainlist , string user, string pass);

    }
}
