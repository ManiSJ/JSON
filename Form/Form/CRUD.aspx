<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="Form.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Create_Click" Text="Create" />
        <asp:Button ID="Button2" runat="server" OnClick="Insert_Click" Text="Insert" />
        <asp:Button ID="Button3" runat="server" OnClick="Update_Click" Text="Update" />
        <asp:Button ID="Button4" runat="server" OnClick="Delete_Click" Text="Delete" />
    </form>
</body>
</html>
