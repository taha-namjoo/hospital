using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Staff
{
    public class tbl_Staff
    {
        public int stuff_id { get; set; }
        public string stuff_user { get; set; }
        public string stuff_pass { get; set; }
        public bool stuff_active { get; set; }
        public string stuff_firstname { get; set; }
        public string stuff_lastname { get; set;}
        public string stuff_birthday { get; set; }
        public string stuff_city_id { get; set; }
        public int stuff_salary { get; set; }
        public string stuff_gender { get; set; }
        public string stuff_phonenumber { get; set; }
        public string stuff_address { get; set; }

    }
}
