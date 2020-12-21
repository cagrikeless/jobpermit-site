using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace jobpermit_site
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('" + strMsg + "')", true);
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OL0BNDU\\SQLEXPRESS;Initial Catalog=JOBPERMIT;Integrated Security=True");
            con.Open();
            string cmdQuery = "Select * from TBLADMIN where USERNAME=@P1 AND PASSWORD=@P2";
            SqlCommand cmd = new SqlCommand(cmdQuery,con);
            cmd.Parameters.AddWithValue("@P1",txt_UsernameorEmail.Text);
            cmd.Parameters.AddWithValue("@P2",txt_Password.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("data.aspx");
            }
            else
            {
                PageUtility.MessageBox(this, "Wrong email or password try again please. !");
            }
            con.Close();
        }
    }
}