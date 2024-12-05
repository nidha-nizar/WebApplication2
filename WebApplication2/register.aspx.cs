using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid();

        }
        public void  grid()
        {
            string query = "select * from reg_tabl";
            dboperation db = new dboperation();
            DataTable dt = db.exetable(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
        
            string query = "insert into  reg_tabl(name,age,class,parentname) values('" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + TextBox4.Text + "')";
            dboperation db = new dboperation();
            db.exenonquery(query);
            grid();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "select * from reg_tabl where r_id='" + id + "'";
            dboperation db = new dboperation();
            DataTable dt= db.exetable(query);
            if(dt.Rows.Count>0)
            {
                TextBox5.Text = dt.Rows[0][0].ToString();
                TextBox1.Text = dt.Rows[0][1].ToString();
                TextBox2.Text = dt.Rows[0][2].ToString();
                TextBox3.Text = dt.Rows[0][3].ToString();
                TextBox4.Text = dt.Rows[0][4].ToString();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string query = "update reg_tabl set name='" + TextBox1.Text + "',age='" + TextBox2.Text + "',class='" + TextBox3.Text + "',parentname='" + TextBox4.Text + "' where r_id='" + TextBox5.Text + "' ";
            dboperation db = new dboperation();
            db.exenonquery(query);
            grid();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete from reg_tabl where r_id='" + id + "'";
            dboperation db = new dboperation();
            db.exenonquery(query);
            grid();
        }
    }
}