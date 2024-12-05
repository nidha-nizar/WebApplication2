<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication2.register" %>

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
        Class<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            ParentsName<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="UPDATE" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="r_id" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="age" HeaderText="Age" />
                <asp:BoundField DataField="class" HeaderText="Class" />
                <asp:BoundField DataField="parentname" HeaderText="ParentName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" CommandArgument='<%# Eval("r_id") %>' runat="server">EDIT</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click" CommandArgument='<%# Eval("r_id") %>' runat="server">DELETE</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
