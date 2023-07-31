using System;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public static class DataSourceBinding
    {
        public static void bindDropdown(DropDownList ddl_country, string query, string textField, string valueField)
        {
            DataTable dt = DatabaseOperations.getDataTableValue(query);
            ddl_country.DataSource = dt;
            ddl_country.DataTextField = textField;
            ddl_country.DataValueField = valueField;
            ddl_country.DataBind();
        }
        public static void bindGrid(GridView grid, string query)
        {
            DataTable dt = DatabaseOperations.getDataTableValue(query);

            grid.DataSource = dt;
            grid.DataBind();
        }
    }
}