using InterviewMalabar.BussinessLogic;
using InterviewMalabar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace InterviewMalabar
{
    public partial class Interview : System.Web.UI.Page
    {
        BLCalculation bLCalculation = new BLCalculation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
               
                ViewState["Employee"] = bLCalculation.InilizeGrid();
                this.BindGrid();
            }
        }
        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["Employee"];
            GridView1.DataBind();
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.name=txtname.Text;
            employeeModel.PhoneNO =Convert.ToInt64(txtphone.Text);
            employeeModel.Address = txtaddress.Text;

            
            bLCalculation.insertdata(employeeModel);
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Employee"];
            dt.Rows.Add(txtname.Text,txtphone.Text, txtaddress.Text);
            ViewState["Employee"] = dt;
            this.BindGrid();
            clearall();
        }
        public void clearall()
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
        }

        protected void btnread_Click(object sender, EventArgs e)
        {
            ViewState["Employee"] = bLCalculation.readdata();
            GridView1.DataSource=  bLCalculation.readdata();
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Employee"];
            dt.Rows.RemoveAt(e.RowIndex);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
          
            
        }
    }
}