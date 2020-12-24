<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        dddd
        <div>
        </div>
        班级号:<asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
        <br />
        班级名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        学院编号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        班级人数：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" />
    </form>
</body>
</html>
