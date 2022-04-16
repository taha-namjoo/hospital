using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Admin
{
    public class tbl_admin
    {
        public int admin_id { get; set; }
        public string admin_user { get; set; }
        public string admin_pass { get; set; }
        public bool admin_active { get; set; }
        public string admin_firstname { get; set; }
        public string admin_lastname { get; set; }
        public string admin_salary { get; set; }
    }
}
