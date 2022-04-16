using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Insurance;
using Login.db.DB_connection.Pationt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Interface
{
    interface UPdate
    {

        bool InsertAdminData(tbl_admin admin);
        bool StaffAccess(bool binery, string id);
        bool DoctorAccess(bool binery, string id);
        bool PatientAccess(bool binery, string id);
        bool PatientCost(tbl_patient cost);
        bool PatientDebt(tbl_patient debt);
        bool PatientIllness(string ill, int id);
        bool UpdateHistoryPatient(tbl_patient history);
        bool UpdateInsuranceDebt(tbl_insurance debt);
        bool sumSalary(int darsad, string typePersoal);

    }
}
