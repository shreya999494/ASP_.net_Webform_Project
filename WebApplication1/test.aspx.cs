using System;
using System.Web.UI;
using System.Data.SqlClient;



namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                if (!Page.IsPostBack)
                {
                    string query = " Select * From Country";
                    SqlConnection sqlConnection = DatabaseOperations.getConnection();
                    
                    //sqlConnection.Open();
                    //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection) ;
                    //DataTable dt = new DataTable();
                    //dataAdapter.Fill(dt);
                    
                    //ddl_country.DataSource = dt;
                    //ddl_country.DataTextField = "Country_name";
                    //ddl_country.DataValueField = "id";
                    //ddl_country.DataBind();

                    DataSourceBinding.bindDropdown(ddl_country,query,"Country_name","id");
                }
            }
            catch(Exception ex)
            {
            }
            
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txt_firstName.Text;
                string lastName = txt_lastName.Text;
                string email = txt_email.Text;
                string contactNo = txt_contactNo.Text;
                string salary = txt_salary.Text;
                int countryId = Convert.ToInt32(ddl_country.SelectedValue);
                int gender = rdb_male.Checked ? 1 : rdb_female.Checked ? 2 : 3;

                string query = "INSERT INTO Employees(FirstName,LastName,Email,Gender,ContactNo,Country_id,Salary) " +
                                   "Values(@FirstName,@LastName,@Email,@Gender,@ContactNo,@Country_id,@Salary)";

                SqlConnection sqlConnection = DatabaseOperations.getConnection();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                cmd.Parameters.Add(new SqlParameter("@ContactNo", contactNo));
                cmd.Parameters.Add(new SqlParameter("@Country_Id", countryId));
                cmd.Parameters.Add(new SqlParameter("@Salary", salary));

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch(Exception ex)
            { throw; }
        }

    }
}