using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["Emp_id"], out int employeeId);

            if (!Page.IsPostBack)
            {
                string query = "select * from Country";
                DataSourceBinding.bindDropdown(ddl_country, query, "Country_name", "id");
                string emp_query = "select * from employees where Emp_id = " + employeeId;

                DataTable dt = DatabaseOperations.getDataTableValue(emp_query);

                BindValues(dt.Rows[0].ItemArray);
            }

            // int a = Convert.ToInt32(Request.QueryString["emp_id"]);

            if (employeeId == 0)
            {
                Response.Redirect("Error.aspx");
            }

            
        }

        protected void BindValues(object[] itemArray)
        {
            txt_firstName.Text = itemArray[1].ToString();
            txt_lastName.Text = itemArray[2].ToString();
            txt_email.Text = itemArray[3].ToString();
            if (itemArray[4] != null)
            {
                rdb_male.Checked = Convert.ToInt64 (itemArray[7]) == 1 ? true : false;
                rdb_female.Checked = Convert.ToInt64(itemArray[7]) == 2 ? true : false;
                rdb_other.Checked = Convert.ToInt64(itemArray[7]) == 3 ? true : false;
            }

            if (itemArray[6] != null)
            {
                ddl_country.Items.FindByValue(itemArray[6].ToString()).Selected = true;
            }
            txt_contactNo.Text = itemArray[4].ToString();
            txt_salary.Text = itemArray[5].ToString();
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            
            try
            {
                int.TryParse(Request.QueryString["Emp_id"], out int employeeId);
                
                    string firstName = txt_firstName.Text;
                    string lastName = txt_lastName.Text;
                    string email = txt_email.Text;
                    string contactNo = txt_contactNo.Text;
                    string salary = txt_salary.Text;
                    int countryId = Convert.ToInt32(ddl_country.SelectedValue);
                    int gender = rdb_male.Checked ? 1 : rdb_female.Checked ? 2 : 3;

                string query = "UPDATE Employees SET FirstName = '" + firstName + "'," +
                                                 "LastName = '" + lastName + "'," +
                                                 "Email = '" + email + "'," +
                                                 "ContactNo = '" + contactNo + "'," +
                                                 "Salary = '" + salary + "'," +
                                                 "Country_id = '" + countryId + "'," +
                                                 "Gender = " + gender + 
                                                 "where Emp_id="  + employeeId;


                SqlConnection sqlConnection = DatabaseOperations.getConnection();
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                

                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
            }
            catch (Exception ex)
            { throw; }
        }
    
    }
    
}