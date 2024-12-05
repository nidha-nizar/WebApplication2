<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="totalmark.aspx.cs" Inherits="WebApplication2.totalmark" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Name<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <p>
            totalmarks<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </form>
</body>
</html>
