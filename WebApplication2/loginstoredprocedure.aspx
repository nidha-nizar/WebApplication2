<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginstoredprocedure.aspx.cs" Inherits="WebApplication2.loginstoredprocedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        EMAIL<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            PASSWORD<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
    </form>
</body>
</html>
