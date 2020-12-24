<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="insert.aspx">新增</a>
        <div>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="班级号" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:TemplateField>
                        <HeaderTemplate>
                            操作
                        </HeaderTemplate>
                        <ItemTemplate>
                             <a href="Update.aspx?id=<%#Eval("班级号") %>">修改</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
