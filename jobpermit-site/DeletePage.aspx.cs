using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jobpermit_site
{
    public partial class DeletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["ID"].ToString());
            DatabaseTableAdapters.TBLADMINTableAdapter dt = new DatabaseTableAdapters.TBLADMINTableAdapter();
            dt.deleteUsers(ID);
            Response.Redirect("data.aspx");
        }
    }
}