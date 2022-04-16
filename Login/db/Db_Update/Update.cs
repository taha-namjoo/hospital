using Dapper;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Insurance;
using Login.db.DB_connection.Pationt;
using Login.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace Login.db.Db_Update
{
    class Update : UPdate
    {
        public bool DoctorAccess(bool binery, string id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Update tbl_doctor Set doctor_active = @doctor_active where doctor_pass=@doctor_pass");
                    db.Execute(query, new { doctor_active = binery, doctor_pass = id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool InsertAdminData(tbl_admin admin)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Update tbl_admin Set admin_id=@admin_id,admin_user=@admin_user,admin_pass=@admin_pass,admin_active=@admin_active");
                    db.Execute(query, admin);
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool PatientAccess(bool binery, string id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Update tbl_patient Set patient_active = @patient_active where patient_city_id=@patient_city_id");
                    db.Execute(query, new { patient_active = binery, patient_city_id = id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public List<tbl_patient> GetAllPateintData(int city_id)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)

                    db.Open();

                return db.Query<tbl_patient>($"SELECT * FROM tbl_patient where patient_city_id={city_id}").ToList();

            }
        }


        public bool PatientDebt(tbl_patient debt)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ($"Update tbl_patient Set patient_debt = {debt.patient_debt} where patient_city_id = {debt.patient_city_id}");
                    db.Execute(query, debt);
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException qq)
            {
                Console.WriteLine(qq.Message);
                return false;
            }

        }

        public bool PatientIllness(string ill, int id)
        {

            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Update tbl_patient Set patient_illness = @patient_illness where patient_city_id=@patient_city_id");
                    db.Execute(query, new { patient_illness = ill, patient_city_id = id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool StaffAccess(bool binery, string id)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Update tbl_stuff Set stuff_active = @stuff_active where stuff_pass=@stuff_pass");
                    db.Execute(query, new { stuff_active = binery, stuff_pass = id });
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool UpdateHistoryPatient(tbl_patient history)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ($"Update tbl_patient Set patient_history=@patient_history where patient_id={history.patient_id}");
                    db.Execute(query, history);
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException qq)
            {
                Console.WriteLine(qq.Message);
                return false;
            }
        }

        public bool PatientCost(tbl_patient cost)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ($"Update tbl_patient Set patient_cost = {cost.patient_cost} where patient_city_id = {cost.patient_city_id}");
                    db.Execute(query, cost);
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException qq)
            {
                Console.WriteLine(qq.Message);
                return false;
            }
        }

        public bool UpdateInsuranceDebt(tbl_insurance debt)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();



                    string query = ($"Update tbl_insurence Set insurance_debt = {debt.insurance_debt} where insurance_name = '{debt.insurance_name}' ");
                    db.Execute(query, debt);

                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException qq)
            {
                Console.WriteLine(qq.Message);
                return false;
            }
        }

        public bool sumSalary(int darsad, string typePersoal)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ($"update tbl_{typePersoal} set {typePersoal}_salary = {typePersoal}_salary +((doctor_salary* {darsad})/100)");
                    db.Execute(query);
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
