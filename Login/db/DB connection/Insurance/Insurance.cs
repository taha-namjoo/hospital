using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Insurance
{
    public class tbl_insurance
    {
       public int insurance_id{ get; set; }
       public string insurance_name { get; set; }
       public decimal insurance_percent_cost { get; set; }
       public decimal insurance_debt { get; set; }
    }
}
