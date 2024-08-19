using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace tasks
{
    public class functions
    {
        //הוספת משימה לטבלת משימות
        public static bool Add(string task,DateTime d,string mail)
        {
            string addTask = $"insert into tasks values(N'{mail}','{task}','{d}')";
                Helper.DoQuery("tasks.mdf", addTask);
                return true;

        }

        public static DataTable ReturnTasksWorkers(int codeAdmin)
        {
            string selectTasks = $"select w.name, t.task, t.date from tasks t join workers w on t.mail=w.mail where w.adminCode={codeAdmin} order by w.name";
            if (Helper.IsExist("tasks.mdf", selectTasks))
            {
                DataTable table = Helper.ExecuteDataTable("tasks.mdf", selectTasks);
                return table;
                
            }
            else
                return null;
        }
        
    }
}