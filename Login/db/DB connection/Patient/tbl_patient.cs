using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Pationt
{
    public class tbl_patient
    {
        public int patient_id { get; set; }
        public string patient_firstname { get; set; }
        public string patient_lastname { get; set; }
        public int patient_city_id { get; set; }
        public string patient_gender { get; set; }
        public string patient_address { get; set; }
        public string patient_birthday { get; set; }
        public string patient_phonenumber { get; set; } 
        public decimal patient_debt { get; set; }
        public string patient_i_type { get; set; }
        public int patient_i_code { get; set; }
        public string patient_history { get; set; }
        public string patient_service { get; set; }
        public string patient_illness { get; set; }
        public decimal patient_cost { get; set; }
        public string patient_dateofcost { get; set; }
        public bool patient_active { get; set; }


        //..........omadi inja baghye property ha ro benevia!
        //zadam !

    }
}
