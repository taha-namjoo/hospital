using Login.db.DB_connection;
using Login.db.DB_connection.Pationt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class SumPatientCost
    {
        decimal sumcost;
        public SumPatientCost(decimal n)
        {
            sumcost = n;
        }
         

        public decimal SumIt(decimal s)
        {

            sumcost += s;

            return sumcost;

        }
    }
}
