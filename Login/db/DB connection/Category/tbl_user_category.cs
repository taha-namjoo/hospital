using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.DB_connection.Category
{
    public class tbl_user_category
    {

        public int category_id { get; set; }
        public string category_name { get; set; }
        public bool category_active { get; set; }
    }
}
