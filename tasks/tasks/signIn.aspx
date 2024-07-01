<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="tasks.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>signIn</title>
    <link rel="stylesheet" href="basic.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>התחברות</h1>
            <label>סיסמה</label>
            <input type="password" name="userPass" /><br />
            <label>מייל</label>
            <input type="email" name="userMail" /><br />
            <input type="submit" name="sub" /><br />
            <%=msg%>
        </div>
    </form>
</body>
</html>
