using Dapper;
using Login.db.DB_connection.Admin;
using Login.db.DB_connection.Doctor;
using Login.db.DB_connection.Insurance;
using Login.db.DB_connection.Pationt;
using Login.db.DB_connection.Staff;
using Login.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.db.Db_Insert
{
    class Inser : IInsert
    {

        public bool InsertAdminData(tbl_admin admin)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Insert Into tbl_admin (admin_id,admin_user,admin_pass,admin_active) Values (@admin_id,@admin_user,@admin_pass,@admin_active)");
                    db.Execute(query, admin);
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool InsertDoctorData(tbl_doctorr doci)
        {
            try
            {

                using(IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Insert Into tbl_doctor (doctor_id,doctor_user,doctor_pass,doctor_active,doctor_firstname,doctor_lastname,doctor_birthday,doctor_city_id,doctor_salary,doctor_gender,doctor_phonenumber,doctor_address,doctor_MSVC) Values (@doctor_id,@doctor_user,@doctor_pass,@doctor_active,@doctor_firstname,@doctor_lastname,@doctor_birthday,@doctor_city_id,@doctor_salary,@doctor_gender,@doctor_phonenumber,@doctor_address,@doctor_MSVC)");
                    db.Execute(query, doci);
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool InsertInsurance(tbl_insurance insurance)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = ("Insert Into tbl_insurence (insurance_id,insurance_name,insurance_percent_cost,insurance_debt) Values (@insurance_id,@insurance_name,@insurance_percent_cost,@insurance_debt)");
                    db.Execute(query, insurance);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool InsertPatientData(tbl_patient patient)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Insert Into tbl_patient (patient_id,patient_firstname,patient_lastname,patient_city_id,patient_gender,patient_address,patient_birthday,patient_phonenumber,patient_debt,patient_i_type,patient_i_code,patient_history,patient_cost,patient_active) Values (@patient_id,@patient_firstname,@patient_lastname,@patient_city_id,@patient_gender,@patient_address,@patient_birthday,@patient_phonenumber,@patient_debt,@patient_i_type,@patient_i_code,@patient_history,@patient_cost,@patient_active)");
                    db.Execute(query, patient);
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool InsertStaffData(tbl_Staff staff)
        {
            try
            {

                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)

                        db.Open();

                    string query = ("Insert Into tbl_stuff (stuff_id,stuff_user,stuff_pass,stuff_active,stuff_firstname,stuff_lastname,stuff_birthday,stuff_city_id,stuff_salary,stuff_gender,stuff_phonenumber,stuff_address) Values (@stuff_id,@stuff_user,@stuff_pass,@stuff_active,@stuff_firstname,@stuff_lastname,@stuff_birthday,@stuff_city_id,@stuff_salary,@stuff_gender,@stuff_phonenumber,@stuff_address)");
                    db.Execute(query, staff);
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
