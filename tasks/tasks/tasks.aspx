<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tasks.aspx.cs" Inherits="tasks.tasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>tasks</title>
    <link rel="stylesheet" href="basic.css" />
    <style>
        body {
            direction: rtl;
            background-color: palevioletred;
            text-align: center;
            font-family: Calibri;
        }

        button {
            margin-top: 3%;
            width: 10%;
            height: 15%;
            background-color: brown;
            color: white;
            font-weight: 300;
        }

        ul {
            font-size: 16px;
            color: white;
            border: 2px black solid;
            width: 50%;
            margin-left: 25%;
            margin-right: 25%;
            text-align: right
        }

        input {
            width: 15%;
            margin: 2%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>רשימת מטלות</h1>
            <button name="viewTasks">הצגת כל המטלות</button><br />
            <label>הכנס מטלה</label>
            <input type="text" name="task" id="insert" width="100" />
            <br />
            <label>תאריך ביצוע מטלה</label>
            <input type="date" name="taskDate" />
            <br />
            <button id="btnAdd">הוספת המטלה</button>
            <ul class="list">            
                <%=tasksList%>

            </ul>
            <h2><%=msg%></h2>
        </div>
    </form>
</body>
</html>
