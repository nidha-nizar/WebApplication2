using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class totalmark : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(phy+chem+bio) as total from m_tabl inner join reg_tabl on reg_tabl.r_id=m_tabl.r_id   where m_tabl.r_id='"+DropDownList1.SelectedValue+"' group by m_tabl.r_id";
            dboperation db = new dboperation();
            DataTable dt = db.exetable(query);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                TextBox1.Text = "no value".ToString();
            }
            
        }
    }
}