using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Doctor
{
    public class tbl_doctorr
    {

        public int doctor_id { get; set; }
        public string doctor_user { get; set; }
        public string doctor_pass { get; set; }
        public bool doctor_active { get; set; }
        public string doctor_firstname { get; set; }
        public string doctor_lastname { get; set; }
        public string doctor_birthday { get; set; }
        public string doctor_city_id { get; set; }
        public int doctor_salary { get; set; }
        public string doctor_gender { get; set; }
        public string doctor_phonenumber { get; set; }
        public string doctor_address { get; set; }
        public string doctor_MSVC { get; set; }
        
    }
}
