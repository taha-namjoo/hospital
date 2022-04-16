using Login.db.DB_connection.Admin;
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
    interface IInsert
    {
        bool InsertAdminData(tbl_admin admin);
        bool InsertDoctorData(tbl_doctorr doci);
        bool InsertStaffData(tbl_Staff staff);
        bool InsertPatientData(tbl_patient patient);
        bool InsertInsurance(tbl_insurance insurance);

    }
}
