using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS305_Web_Master_Project.Demos.WageCalculator
{
    public partial class WageEntrySummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

       

        protected void BindData()
        {

            string constr = "Data Source=misapps.flagler.edu;Initial Catalog=jwang;Persist Security Info=True;User ID=jwang;Password=Password#1";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM WageEntry";

                    cmd.Connection = con;
                    // cmd.Parameters   hint: use this to perform a search!

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
}