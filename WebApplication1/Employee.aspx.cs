using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void lnk_edit_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect("EditEmployee.aspx?Emp_id=" + e.CommandArgument);
        }

        protected void lnk_delete_Click(object sender, CommandEventArgs e)
        {
            //int.TryParse(Request.QueryString["Emp_id"], out int employeeId);
            int.TryParse(e.CommandArgument.ToString(), out int emp_id);
            string deletequery = "delete from Employees where Emp_id=" + emp_id;
            SqlConnection sqlConnection = DatabaseOperations.getConnection();

            SqlCommand cmd = new SqlCommand(deletequery, sqlConnection);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            BindGrid();

        }

        protected void BindGrid() 
        {
            string gridquery = "Select * from Employees";
            DataSourceBinding.bindGrid(grid_emp, gridquery);    
        }

    }
}