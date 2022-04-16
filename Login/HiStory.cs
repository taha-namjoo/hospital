using Login.db.DB_connection.Pationt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class HiStory
    {
        
        string str;
       
         public string his(string s)
        {
            str += s + " / ";

            return str;
        }
    }
}
