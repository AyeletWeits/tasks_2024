using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace tasks
{
    public partial class signIn : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["sub"] != null)
            {
                string password = Request.Form["userPass"];
                string mail = Request.Form["userMail"];
                string selectUser = $"select * from workers where password='{password}' and mail='{mail}'";
                string selectAdmin = $"select * from Administrators where password='{password}' and mail='{mail}'";

                string db = "tasks.mdf";
                //בדיקה האם מנהל
                if (Helper.IsExist(db, selectAdmin))
                {
                    DataTable table = Helper.ExecuteDataTable(db, selectAdmin);
                    int length = table.Rows.Count;
                    if (length != 0)
                    {
                        Session["admin"] = "yes";
                        Session["code"] = table.Rows[0]["code"];
                        Session["mail"] = table.Rows[0]["mail"];
                        Session["name"] = table.Rows[0]["name"];
                        Response.Redirect("tasks.aspx");
                    }
                }
                //בדיקה האם עובד
                else
                {
                    if (Helper.IsExist(db, selectUser))
                    {
                        DataTable table = Helper.ExecuteDataTable(db, selectUser);
                        int length = table.Rows.Count;
                        if (length == 0)
                            msg += $"<div><h2>לא קיים במערכת</h2><a href='signUp.aspx'>להרשמה</a></div>";
                        else
                        {
                            Session["mail"] = table.Rows[0]["mail"];
                            Session["name"] = table.Rows[0]["name"];
                            Response.Redirect("tasks.aspx");
                        }
                    }
                    msg += $"<div><h2>לא קיים במערכת</h2><a href='signUp.aspx'>להרשמה</a></div>";
                }

            }
        }
    }
}