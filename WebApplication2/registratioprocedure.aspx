<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registratioprocedure.aspx.cs" Inherits="WebApplication2.registratioprocedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            Age<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        Email<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Password<asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="r_id" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="NAME" />
                <asp:BoundField DataField="age" HeaderText="AGE" />
                <asp:BoundField DataField="email" HeaderText="EMAIL" />
                <asp:BoundField DataField="password" HeaderText="PASSWORD" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click"  CommandArgument='<%# Eval("r_id") %>' runat="server">EDIT</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click"  CommandArgument='<%# Eval("r_id") %>' runat="server">DELETE</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
