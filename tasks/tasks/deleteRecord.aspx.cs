using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tasks
{
    public partial class deleteRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"].ToString() != "visit")
            {
                string code = Request.QueryString["code"].ToString();
                string sqlDelete = $"DELETE FROM tasks WHERE code='{code}'";
                Helper.DoQuery("tasks", sqlDelete);
            }
            Response.Redirect("tasks.aspx");
        }
    }
}