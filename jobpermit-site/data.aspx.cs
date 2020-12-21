using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jobpermit_site
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DatabaseTableAdapters.TBLADMINTableAdapter dt = new DatabaseTableAdapters.TBLADMINTableAdapter();
            usersRepeater.DataSource = dt.getUsers();
            usersRepeater.DataBind();
        }
    }
}