<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="markuplod.aspx.cs" Inherits="WebApplication2.markuplod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        NAME<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <p>
            PHY<asp:TextBox ID="TextPHY" runat="server"></asp:TextBox>
        </p>
        <p>
            CHEM<asp:TextBox ID="TextCHEM" runat="server"></asp:TextBox>
        </p>
        <p>
            BIO<asp:TextBox ID="TextBIO" runat="server" Height="16px"  style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="m_id" HeaderText="ID" />
                    <asp:BoundField DataField="phy" HeaderText="PHYSICS" />
                    <asp:BoundField DataField="chem" HeaderText="CHEMISTRY" />
                    <asp:BoundField DataField="bio" HeaderText="BIOLOGY" />
                    <asp:BoundField DataField="name" HeaderText="name" />
                </Columns>
            </asp:GridView>
        </p>
    </form>
</body>
</html>
