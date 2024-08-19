<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tasks.aspx.cs" Inherits="tasks.tasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>tasks</title>
    <link rel="stylesheet" href="basic.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

    <style>
        body {
            /*   background-image: url("images/1.jpg");*/
            direction: ltr;
            background-size: 100%;
            background-repeat: no-repeat;
            background-color: white;
            text-align: center;
            font-family: Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            color: blue;
        }

        h1 {
            color: white;
            font-size: 65px;
            background-color: dodgerblue;
            margin: 0;
            top: 0;
            padding-bottom: 4%;
            border-bottom: solid 12px crimson;
        }

        label {
            direction:ltr;
            font-size: 16px;
            color: crimson;
            width:80% !important;
        }

        .btn {
            margin: 1%;
            margin-top: 1.5%;
            width: 15%;
            height: 8vh;s
            font-size: 20px;
            color: dodgerblue;
            background-color: white;
            -webkit-transition: none;
            -moz-transition: none;
            transition: none;
            border: 4px solid dodgerblue;
            text-align: center;
        }

        .btn2 {
            border-radius: 600px;
        }

            .btn2:hover {
                background-color: dodgerblue;
                color: white;
            }

        #bot {
            background-color: crimson;
            bottom: 0;
            color: white;
            margin-bottom: 0;
            height: 5vh;
        }

        .task {
            font-size: 16px;
            color: white;
            border: 2px black solid;
            width: 50%;
            margin-left: 25%;
            margin-right: 25%;
        }

        input {
            margin: 0.01% 40%;
            width: 20% !important;
            color: crimson !important;
        }

        #sub {
            margin-top: 2%;
            color: white
        }
        .task{
            color:crimson;
            font-size:15px;
            margin-top:1%;
            /*display:flex;
            flex-direction:row;*/

        }
        a{
            color:crimson
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Task list</h1>
            <button name="viewTasks" class="btn btn2">my tasks</button>
            <%=menuManager%><br />
            <input type="text" name="task" id="insert" width="100" class="form-control" placeholder="enter a task" />
            <br />
            <input type="date" name="taskDate" class="form-control" />
            <br />
            <button id="btnAdd" name="btnAdd" class="btn btn2">Adding a task</button>
            <ul class="list">
                <%=tasksList%>
            </ul>
            <h2><%=msg%></h2>
        </div>
    </form>
</body>
</html>
