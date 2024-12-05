using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class loginstoredprocedure : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=craft;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
         if(!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("login_qry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                Response.Redirect("register.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "invalid";

            }
        }
    }
}