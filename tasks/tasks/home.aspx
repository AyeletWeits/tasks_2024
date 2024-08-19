<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="tasks.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home</title>
    <link rel="stylesheet" href="basic.css" />
       <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
 
    <link rel="icon" href="taskblue.jpg" />
    <style>
        body {
            /*   background-image: url("images/1.jpg");*/
            background-size: 100%;
            background-repeat: no-repeat;
            background-color: white;
            text-align: center;
            font-family: Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            color: blue;
        }

        h1 {
            color:white;
            font-size: 65px;
            background-color:dodgerblue;
            margin:0;
            top:0;
            padding-bottom:4%;
            border-bottom:solid 12px crimson;

        }
        h2{
            margin-top:3%;
            font-size:42px;
            color:crimson;
        }
        .btn {
            margin: 3%;
            margin-top: 18%;
            width: 15%;
            height: 8vh;
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
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tasks</h1>
            <h2>Everything you need for <b>orderly</b> work</h2>
            <button href="signIn.aspx" class="btn btn2" name="signIn">signIn</button>
            <button href="signUp.aspx" class="btn btn2" name="signUp">signUp</button>
        </div>
    </form>
</body>
</html>
