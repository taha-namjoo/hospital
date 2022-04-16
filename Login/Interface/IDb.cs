using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Category;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Insurance;
using Login.db.DB_connection.Pationt;
using Login.db.DB_connection.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Interface
{
    interface IDb
    {

        List<tbl_user_category> GetAllCategoryData();

        List<tbl_admin> GetAllAdminData();

        List<tbl_doctorr> GetAllDoctorData();
    
        List<tbl_Staff> GetAllStaffData();

        List<tbl_patient> GetAllPateintData();

        List<tbl_patient> TruePatients();

        List<tbl_insurance> GetAllInsuranceData();

        List<tbl_doctorr> GetSUMDoctorSalary(string monthago, string now);

        List<tbl_Staff> GetSUMstuffSalary(string monthago, string now);

        List<tbl_patient> GetSUMpatientcost(string monthago, string now);


    }
}
