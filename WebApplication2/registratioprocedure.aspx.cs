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
    public partial class registratioprocedure : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=craft;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                grid();   
 
            }
        }

        public void grid()
        {
            SqlCommand cmd = new SqlCommand("viewpage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

            
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Submit")
            {
                SqlCommand cmd = new SqlCommand("reg_1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@age", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@password", TextBox4.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                grid();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update_qry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@age", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@password", TextBox4.Text);
                cmd.Parameters.AddWithValue("@r_id", TextBox5.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                grid();
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlCommand cmd = new SqlCommand("editing_id", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                TextBox1.Text = dt.Rows[0][1].ToString();
                TextBox2.Text = dt.Rows[0][2].ToString();
                TextBox3.Text = dt.Rows[0][3].ToString();
                TextBox4.Text = dt.Rows[0][4].ToString();
                TextBox5.Text = dt.Rows[0][0].ToString();
            }
            Button1.Text = "UPDATE";

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlCommand cmd = new SqlCommand("delet_qry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();  
        }
    }
}