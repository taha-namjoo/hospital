using Dapper;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Category;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Staff;
using Login.db.DB_connection.Pationt;
using Login.Interface;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Login.db.DB_connection.Insurance;

namespace Login.db.DB_connection
{
    public class DataService : IDb
    {

        public List<tbl_user_category> GetAllCategoryData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)

                    db.Open();
                return db.Query<tbl_user_category>("SELECT category_id,category_name,category_active FROM tbl_user_category").ToList();

            }
        }

        public List<tbl_admin> GetAllAdminData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_admin>("SELECT * FROM tbl_admin").ToList();

            }

        }

        public List<tbl_doctorr> GetAllDoctorData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_doctorr>("SELECT * FROM tbl_doctor").ToList();

            }

        }

        public List<tbl_Staff> GetAllStaffData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_Staff>("SELECT * FROM tbl_stuff").ToList();

            }
        }

        public List<tbl_patient> GetAllPateintData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_patient>("SELECT * FROM tbl_patient").ToList();

            }
        }

        public List<tbl_patient> TruePatients()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_patient>("SELECT * FROM tbl_patient where patient_active=1").ToList();

            }
        }

        public List<tbl_insurance> GetAllInsuranceData()
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query <tbl_insurance>("SELECT * FROM tbl_insurence").ToList();

            }
        }

        public List<tbl_doctorr> GetSUMDoctorSalary(string monthago, string now)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();

                return db.Query<tbl_doctorr>($"SELECT * from tbl_doctor where doctor_date_salary between '{monthago}'And'{now}'").ToList();
            }
        }

        public List<tbl_Staff> GetSUMstuffSalary(string monthago, string now)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<tbl_Staff>($"SELECT * FROM tbl_stuff WHERE stuff_date_salary BETWEEN '{monthago}'AND'{now}'").ToList();
            }
        }

        public List<tbl_patient> GetSUMpatientcost(string monthago, string now)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<tbl_patient>($"SELECT * FROM tbl_patient WHERE patient_dateofcost  BETWEEN '{monthago}'AND'{now}'").ToList();
            }
        }
    }
}
