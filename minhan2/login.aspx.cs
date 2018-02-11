using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minhan2
{
    public partial class login : System.Web.UI.Page
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (CheckLogin(account.Text, password.Text)) {
                Response.Write("<script>alert(\"登入成功!\"); </script>");
            }
            else{
                Response.Write("<script>alert(\"登入失敗QQ\"); </script>");
            }
            




        }
        private bool CheckLogin(string account, string password) {
            bool check = false;
            DB conn = new DB(WebConfigurationManager.ConnectionStrings["SQLDB"].ConnectionString.ToString());
            List<SqlParameter> paramters = new List<SqlParameter>();
            paramters.Add(new SqlParameter("ACCOUNT", account));
            paramters.Add(new SqlParameter("PASSWORD", password));
            DataTable table = conn.ExecuteProc("[test].[dbo].[CHECKLOGIN]", paramters);
            if (table.Rows.Count != 0) check = true;

            return  check;
        }
    }
}