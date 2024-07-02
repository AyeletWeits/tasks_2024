<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="tasks.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="basic.css" />
    <title>signUp</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>הרשמה</h1>
            <label>סיסמה</label>
            <input type="password" name="userPass" /><br />
            <label>שם</label>
            <input type="text" name="userName" /><br />
            <label>מייל</label>
            <input type="email" name="userMail" /><br />
            <label>מס' מנהל</label>
            <input type="number" name="userAdmin" /><br />
            <input type="submit" name="sub" />
        </div>
    </form>
</body>
</html>
