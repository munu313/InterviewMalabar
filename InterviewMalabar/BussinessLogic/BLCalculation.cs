using InterviewMalabar.DataLogics;
using InterviewMalabar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InterviewMalabar.BussinessLogic
{
    public class BLCalculation
    {
       
        DLCalculation dLCalculation = new DLCalculation();
        
        
        public void insertdata(EmployeeModel emp)
        {
            dLCalculation.Insert(emp);
            
        }
        public DataTable InilizeGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Employeename"), new DataColumn("EmployeeePhone"), new DataColumn("EmployeeeAddress") });
            return dt;
        }
        public DataTable readdata()
        {
            DataTable dataTable=dLCalculation.ReadData();
            return dataTable;
        }
    }
}