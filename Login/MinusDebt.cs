using Login.db.DB_connection;
using Login.db.DB_connection.Insurance;
using Login.db.Db_Update;
using System;
using System.Collections.Generic;

namespace Login
{
    public class MinusDebt
    {
        public static decimal Insurancedebt;
        decimal n;
        decimal kam;
        public MinusDebt(decimal s, decimal k,decimal a)
        {
            n = s;
            kam = k;
            Insurancedebt = a;
        }

        public decimal MinusIt(decimal values)
        {
            values = values - n;

            return Math.Abs(values);
        }

        public decimal petientDebt(decimal percantage , string s)
        {
            //Update s = new Update();
            decimal i = 0;
            tbl_insurance tbl_ = new tbl_insurance();
            List<tbl_insurance> tbl_s = new List<tbl_insurance>();
            DataService data = new DataService();
            tbl_s=data.GetAllInsuranceData();
            foreach(tbl_insurance b in tbl_s)
            {
                if (s == b.insurance_name)
                {
                    i = b.insurance_percent_cost;
                }
            }

            Insurancedebt = (percantage * i) / 100;
            kam = percantage - ((percantage * i) / 100);

            return kam;
        }
       
    }
}
