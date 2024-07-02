using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tasks
{
    public partial class signUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["sub"] != null)
            {
                string password = Request.Form["userPass"];
                string name = Request.Form["userName"];
                string mail = Request.Form["userMail"];
                int userAdmin =int.Parse(Request.Form["userAdmin"]);
                string addUser = $"insert into workers values(N'{password}','{name}','{mail}',{userAdmin})";
                Helper.DoQuery("tasks.mdf", addUser);
                Session["mail"] = mail;
                Session["name"] = name;
                Response.Redirect("tasks.aspx");
            }
        }
    }
}