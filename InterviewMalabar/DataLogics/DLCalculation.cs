using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom;
using InterviewMalabar.Models;
using System.Drawing;

namespace InterviewMalabar.DataLogics
{
    public class DLCalculation
    {
        string con = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        SqlConnection conn = null;
      
        public void Insert(EmployeeModel emp)
        {
            SqlConnection conn = new SqlConnection(con);
            try
            {
                conn=new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.AddWithValue("@employeename", emp.name);
                cmd.Parameters.AddWithValue("@employeephoneno", emp.PhoneNO);
                cmd.Parameters.AddWithValue("@employeeAddress", emp.Address);
                cmd.Parameters.Add("@employeeid", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                string id = cmd.Parameters["@employeeid"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            
        }

        public DataTable ReadData()
        {
            try
            {
                conn = new SqlConnection(con);
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SelectEmployee", con);
                conn.Open();
                adapt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally 
            { 
                conn.Close();
            }

        }
    }
    }
