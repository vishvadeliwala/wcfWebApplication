<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="LibraryManagementClient.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Management System</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:320px">
        <asp:Label ID="Label1" runat="server" Text="LIBRARY MANAGEMENT SYSTEM"></asp:Label>
    </div>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="To Add,Remove or Update Books Login here:"></asp:Label>
        <br />
        <br />
        Username: <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="150px"></asp:TextBox>
        <br />
        Password: <asp:TextBox ID="TextBox5" TextMode="Password" runat="server" Height="16px" Width="150px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Login" Width="100px" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="To Search Books Click here:"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Search Books" Width="100px" />
    </form>
</body>
</html>
