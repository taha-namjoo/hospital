using Dapper;
using Login.db.DB_connection.Doctor;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.Search
{
    class Search
    {
        public List<tbl_doctorr> search(string user)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_doctorr>("SELECT * FROM tbl_doctor where doctor_user like '%" + user + "%'").ToList();

            }
        }
    }
}
