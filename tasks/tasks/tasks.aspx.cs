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
        DataTable table;
        protected void Page_Load(object sender, EventArgs e)
        {
            //הוספת כפתור להצגת מטלות עובדים למנהל
            if (Session["admin"].ToString() == "yes")
            {
                menuManager += "<button name='viewWorkers' class=\"btn btn2\" style=\"width:23%\">my employee tasks</button>";
            }
            else
                menuManager = "";
            //הוספת מטלה, ולאחר מכן עדכון כל המטלות מיידית
            if (Request.Form["btnAdd"] != null)
            {
                if (Session["mail"].ToString() == "visit")
                    msg = "אינך מחובר";
                else
                {
                    string task = Request.Form["task"];
                    DateTime taskDate = Convert.ToDateTime(Request.Form["taskDate"]);
                    functions.Add(task, taskDate, Session["mail"].ToString());
                    //הצגת משימות עובד
                    string selectTasks = $"select * from tasks where mail='{Session["mail"].ToString()}' order by tasks.date";
                    if (Helper.IsExist("tasks.mdf", selectTasks))
                    {
                        table = Helper.ExecuteDataTable("tasks.mdf", selectTasks);
                        if (table.Rows.Count == 0)
                            msg = "There are no tasks";
                        else
                        {
                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                string userToDelete = table.Rows[i]["code"].ToString();
                                tasksList += $"<div class='task'><label>{table.Rows[i]["task"]} <br/> {table.Rows[i]["date"]}</label><br/><a href='deleteRecord.aspx?code={userToDelete}'>delete</a></div>";
                            }
                        }
                    }
                    else
                        msg = "There are no tasks";
                }
            }
            //הצגת כל המשימות לעובד
            if (Request.Form["viewTasks"] != null)
            {
                string selectTasks = $"select * from tasks where mail='{Session["mail"].ToString()}' order by tasks.date";
                if (Helper.IsExist("tasks.mdf", selectTasks))
                {
                    table = Helper.ExecuteDataTable("tasks.mdf", selectTasks);
                    if (table.Rows.Count == 0)
                        msg = "There are no tasks";
                    else
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            string userToDelete = table.Rows[i]["code"].ToString();
                            tasksList += $"<div class='task'><label>{table.Rows[i]["task"]} <br/> {table.Rows[i]["date"]}</label><br/><a href='deleteRecord.aspx?code={userToDelete}'>delete</a></div>";
                        }
                    }
                }
                else
                    msg = "לא קיימות מטלות";

            }
            //הצגת מטלות עובדים למנהל
            if (Session["admin"].ToString() == "yes")
            {
                if (Request.Form["viewWorkers"] != null)
                {

                    DataTable table = functions.ReturnTasksWorkers(int.Parse(Session["code"].ToString()));
                    if (table != null)
                    {
                        if (table.Rows.Count == 0)
                            msgAdmin = "There are no tasks";
                        else
                        {
                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                tasksList += $"<div class='task'><label><b>{table.Rows[i]["name"]}</b> <br/> {table.Rows[i]["task"]} <br/> {table.Rows[i]["date"]}</label><br/></div>";
                            }
                        }
                    }
                    else
                        msgAdmin = "There are no tasks";
                }
            }
            else
            {
                msg = "You are not a manager";
            }
        }

    }
}
