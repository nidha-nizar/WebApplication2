using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "select * from reg_tabl where name='"+TextBox1.Text+"' and class='"+TextBox2.Text+"'";
            dboperation db = new dboperation();
            DataTable dt= db.exetable(query);
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