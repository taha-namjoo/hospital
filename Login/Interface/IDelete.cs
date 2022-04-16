using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Interface
{
    interface IDelete
    {
        bool DeleteAdminData(int Admin_Id);
        bool DeleteDoctorData(string doctor_Id);
        bool DeleteStaffData(string Staff_Id);
    }
}
