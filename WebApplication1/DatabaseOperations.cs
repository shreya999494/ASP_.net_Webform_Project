using System.Data;
using System.Data.SqlClient;
namespace WebApplication1
{
    public static class DatabaseOperations
    {
        const string con_string = "Data Source=DESKTOP-N1ANFK1;User id=sb;Password=sa123;database=Test";
        public static SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(con_string);
            sqlConnection.Open();
            return sqlConnection;
        }
        public static  DataTable getDataTableValue(string query)
        {

            SqlConnection sqlConnection = getConnection();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.Fill(dt);
            return dt;

        }
    }
}