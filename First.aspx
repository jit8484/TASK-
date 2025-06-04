<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="FirstWeb.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            server Date:
            <% Response.Write(DateTime.Now.ToLongDateString()); %>
            <br />
            server Time:
            <%Response.Write(DateTime.Now.ToShortDateString()); %>
            <br />

            server Date:
            <%Response.Write(DateTime.Now.ToShortDateString()); %>
            <br />
            Sever time:
            <%Response.Write(DateTime.Now.ToLongTimeString()); %>


            <h1> Hello jit</h1>
        </div>
    </form>
</body>
</html>
