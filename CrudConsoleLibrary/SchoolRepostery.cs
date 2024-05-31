using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace CrudConsoleLibrary
{
   public class SchoolRepostery
    {
       
        string connectionstring = "Data source=DESKTOP-CC47JG8\\SQLEXPRESS;Initial Catalog=PonmadeshVelusamy;User id=sa;password=Anaiyaan@123";
        SqlConnection objj;
        SchoolDetails obj = new SchoolDetails();
        public SchoolRepostery()
        {
            objj = new SqlConnection(connectionstring);

        }

        public void Schoolsignup(SchoolDetails obj)
        {
            try
            
            {
                var insert = ($"exec SchoolDetails  '{obj.SchoolName}',{obj.ContactNo},'{obj.Email}','{obj.Address}',{obj.Pincode}");
                objj.Open();
                objj.Execute(insert);
                objj.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<SchoolDetails> Showall()
        {
            try
            {
                var selectquery = $"select SchoolID,SchoolName,ContactNo,Email,Address,Pincode from SchoolDetails";
                objj.Open();
                var result = objj.Query<SchoolDetails>(selectquery);
                objj.Close();
                return result;


            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EditorUpdate(long SchoolID, long ContactNo, String Email)
        {
            try
            {
                var Update = $"update EditorUpdate  set {ContactNo},'{Email}' where '{SchoolID}";
                objj.Open();
                objj.Execute(Update);
                objj.Close();

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteDetails(long SchoolID)
        {
            try
            {
                var Remove = $"select* from  DeleteDetails where={SchoolID}";
                objj.Open();
                objj.Execute(Remove);
                objj.Close();

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;

            }
        }

    }
}
