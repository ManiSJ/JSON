﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Form.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfContactID" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Mobile"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtaddress" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                      <td></td>
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                    </td>
                      </tr>
                      <tr>
                      <td></td>
                    <td colspan="2">
                        <asp:Label ID="lblSuccessMessage" runat="server" ForeColor="Green" Text=""></asp:Label>
                    </td>
                     </tr>
                <tr>
                      <td></td>
                    <td colspan="2">
                        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderTExt="Name" />
                     <asp:BoundField DataField="Mobile" HeaderTExt="Mobile" />
                     <asp:BoundField DataField="Address" HeaderTExt="Address"/>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkview" CommandArgument='<%# Eval("ContactID")  %>' OnClick="lnk_OnClick" runat="server">View</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
