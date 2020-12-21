using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jobpermit_site
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        public static class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('" + strMsg + "')", true);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(Request.QueryString["ID"].ToString());
            DatabaseTableAdapters.TBLADMINTableAdapter dt = new DatabaseTableAdapters.TBLADMINTableAdapter();
            TextBox1.Text = z.ToString();
            TextBox1.Enabled = false;

            if (Page.IsPostBack == false)
            {
                TextBox2.Text = dt.getUsersData(Convert.ToInt32(TextBox1.Text))[0].USERNAME;
                TextBox3.Text = dt.getUsersData(Convert.ToInt32(TextBox1.Text))[0].PASSWORD;
                TextBox4.Text = dt.getUsersData(Convert.ToInt32(TextBox1.Text))[0].PASSWORD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DatabaseTableAdapters.TBLADMINTableAdapter dt = new DatabaseTableAdapters.TBLADMINTableAdapter();
            if (TextBox3.Text == TextBox4.Text)
            {
                dt.updateUsers(TextBox2.Text, TextBox3.Text, Convert.ToInt32(TextBox1.Text));
                Response.Redirect("data.aspx");
            }
            else
            {
                PageUtility.MessageBox(this, "Passwords do not match");

            }
        }
    }
}