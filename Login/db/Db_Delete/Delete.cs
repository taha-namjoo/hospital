using Dapper;
using Login.db.DB_connection.Admin;
using Login.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.Db_Delete
{
    class Delete : IDelete
    {
        public bool DeleteAdminData(int Admin_Id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Delete From tbl_admin Where admin_id=@admin_id");
                    db.Execute(query, new { admin_id = Admin_Id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteDoctorData(string doctor_Id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Delete From tbl_doctor Where doctor_city_id=@doctor_city_id");
                    db.Execute(query, new { doctor_city_id = doctor_Id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteStaffData(string Staff_Id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Delete From tbl_stuff Where stuff_city_id = @stuff_city_id");
                    db.Execute(query, new { stuff_city_id = Staff_Id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }


        }
}
