<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="tasks.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>signIn</title>
   <!-- <link rel="stylesheet" href="basic.css" />-->
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
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
            color: white;
            font-size: 65px;
            background-color: dodgerblue;
            margin: 0;
            top: 0;
            padding-bottom: 4%;
            margin-bottom:2%;
            border-bottom:solid 12px crimson;
        }
               .btn {
            margin: 1%;
            margin-top: 1.5%;
            width: 15%;
            height: 8vh;
            font-size: 20px;
            color: crimson;
            background-color: white;
            -webkit-transition: none;
            -moz-transition: none;
            transition: none;
            border: 4px solid crimson;
            text-align: center;
        }

        .btn2 {
            border-radius: 600px;
        }

            .btn2:hover {
                background-color: crimson;
                color: white !important;
            }
            input{
                margin:0.5% 40%;
                width:20% !important;
                color:crimson !important;
            }
            #sub{
                margin-top:2%;
                color:white
            }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>signIn</h1>
            <input type="password" name="userPass" class="form-control" placeholder="enter password" /><br />
            <input type="email" name="userMail" class="form-control" placeholder="enter email"/><br />
            <input type="submit" name="sub" class="btn btn2" value="submit" id="sub"/><br />
            <%=msg%>

        </div>
    </form>
</body>
</html>
