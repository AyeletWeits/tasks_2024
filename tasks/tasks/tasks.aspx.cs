using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tasks
{
    public partial class tasks : System.Web.UI.Page
    {
        public string msg = "", tasksList = "", menuManager = "", msgAdmin = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == "yes")
            {
                menuManager += "<button name='viewWorkers'>הצגת משימות העובדים שלי</button>";
            }
            if (Request.Form["btnAdd"] != null)
            {
                string task = Request.Form["task"];
                DateTime taskDate = Convert.ToDateTime(Request.Form["taskDate"]);
                functions.Add(task, taskDate, Session["mail"].ToString());
            }

            //הצגת כל המטלות
            if (Request.Form["viewTasks"] != null)
            {
                string selectTasks = $"select * from tasks where mail='{Session["mail"].ToString()}'";
                if (Helper.IsExist("tasks.mdf", selectTasks))
                {
                    DataTable table = Helper.ExecuteDataTable("tasks.mdf", selectTasks);
                    if (table.Rows.Count == 0)
                        msg = "לא קיימות מטלות";
                    else
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            tasksList += $"<li class='task'><h2>{table.Rows[i]["task"]}</h2><h2>{table.Rows[i]["date"]}</h2></li>";
                        }
                    }
                }
                else
                    msg = "לא קיימות מטלות";

            }
            //הצגת מטלות עובדים למנהל
            if (Request.Form["viewWorkers"] != null)
            {

                DataTable table = functions.ReturnTasksWorkers(int.Parse(Session["code"].ToString()));
                if (table != null)
                {
                    if (table.Rows.Count == 0)
                        msgAdmin = "לא קיימות מטלות";
                    else
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            tasksList += $"<li class='task'><h2>{table.Rows[i]["name"]}</h2><h2>{table.Rows[i]["task"]}</h2><h2>{table.Rows[i]["date"]}</h2></li>";
                        }
                    }
                }
                else
                    msgAdmin = "לא קיימות מטלות";
            }
          
        }

    }
}
}