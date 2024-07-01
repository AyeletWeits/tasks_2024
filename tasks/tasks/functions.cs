using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tasks
{
    public class functions
    {
        //הוספת משימה לטבלת משימות
        public static void Add(string task,DateTime d,string mail)
        {
            string addTask = $"insert into tasks(mail,task,date) values(N'{mail}','{task}','{d}')";
            Helper.DoQuery("tasks.mdf", addTask);
        }
        
    }
}