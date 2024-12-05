using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    
    public class dboperation
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public dboperation()
        {
            con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=newregister;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
        } 
        public SqlConnection getcon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void dbclose()
        {
            con.Close();
        }
        public int exenonquery(String sql)
        {
            getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
   
            return i;
        }
        public DataTable exetable(string sql)
        {
            getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
    }
}