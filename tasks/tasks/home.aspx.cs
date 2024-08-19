using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tasks
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["signIn"] != null)
                Response.Redirect("signIn.aspx");
            if (Request.Form["signUp"] != null)
                Response.Redirect("signUp.aspx");
        }
    }
}