using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class markuplod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();

                grid();
            }
              

        }
        public void drop()
        {
            string query = "select r_id,name from reg_tabl";
            dboperation db = new dboperation();

            DataTable dt = db.exetable(query);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "r_id";
            DropDownList1.DataBind();

        }

        public void grid()
        {
            string query = "SELECT [m_id],[phy] ,[chem]    ,[bio]    ,[dbo].[m_tabl].[r_id],name FROM [dbo].[m_tabl] inner join reg_tabl on reg_tabl.r_id=m_tabl.r_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetable(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "insert into m_tabl values ('" + TextPHY.Text + "','" + TextCHEM.Text + "','" + TextBIO.Text + "','" + DropDownList1.SelectedValue + "' )";
            dboperation db = new dboperation();
            db.exenonquery(query);
        }

       

        }
   
}