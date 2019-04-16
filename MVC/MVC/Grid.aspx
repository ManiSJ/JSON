<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grid.aspx.cs" Inherits="GridView.grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="BookID" DataSourceID="SqlDataSource2" ForeColor="#333333" 
                OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" 
                OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowDeleted="GridView1_RowDeleted"
                OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" 
                OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
                OnSelectedIndexChanging="GridView1_SelectedIndexChanging" HorizontalAlign="Justify" 
                OnDataBinding="GridView1_DataBinding" OnDataBound="GridView1_DataBound" 
                 OnRowDataBound="GridView1_RowDataBound" PageSize="2" OnRowCreated="GridView1_RowCreated" OnSorted="GridView1_Sorted" OnSorting="GridView1_Sorting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="BookID" HeaderText="BookID" InsertVisible="False" ReadOnly="True" SortExpression="BookID" />
                    <asp:BoundField DataField="BookName" HeaderText="BookName" SortExpression="BookName" />
                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Price_Range" HeaderText="Price_Range" SortExpression="Price_Range" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:employeesConnectionString %>" DeleteCommand="DELETE FROM [Books] WHERE [BookID] = @BookID" InsertCommand="INSERT INTO [Books] ([BookName], [Category], [Price], [Price_Range]) VALUES (@BookName, @Category, @Price, @Price_Range)" SelectCommand="SELECT * FROM [Books]" UpdateCommand="UPDATE [Books] SET [BookName] = @BookName, [Category] = @Category, [Price] = @Price, [Price_Range] = @Price_Range WHERE [BookID] = @BookID">
                <DeleteParameters>
                    <asp:Parameter Name="BookID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="BookName" Type="String" />
                    <asp:Parameter Name="Category" Type="String" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Price_Range" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="BookName" Type="String" />
                    <asp:Parameter Name="Category" Type="String" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="Price_Range" Type="String" />
                    <asp:Parameter Name="BookID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" DeleteCommand="DELETE FROM [Orders] WHERE [OrderID] = @OrderID" InsertCommand="INSERT INTO [Orders] ([CustomerID], [EmployeeID], [OrderDate], [RequiredDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipRegion], [ShipPostalCode], [ShipCountry]) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)" SelectCommand="SELECT * FROM [Orders]" UpdateCommand="UPDATE [Orders] SET [CustomerID] = @CustomerID, [EmployeeID] = @EmployeeID, [OrderDate] = @OrderDate, [RequiredDate] = @RequiredDate, [ShippedDate] = @ShippedDate, [ShipVia] = @ShipVia, [Freight] = @Freight, [ShipName] = @ShipName, [ShipAddress] = @ShipAddress, [ShipCity] = @ShipCity, [ShipRegion] = @ShipRegion, [ShipPostalCode] = @ShipPostalCode, [ShipCountry] = @ShipCountry WHERE [OrderID] = @OrderID" >
                <DeleteParameters>
                    <asp:Parameter Name="OrderID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                    <asp:Parameter Name="OrderDate" Type="DateTime" />
                    <asp:Parameter Name="RequiredDate" Type="DateTime" />
                    <asp:Parameter Name="ShippedDate" Type="DateTime" />
                    <asp:Parameter Name="ShipVia" Type="Int32" />
                    <asp:Parameter Name="Freight" Type="Decimal" />
                    <asp:Parameter Name="ShipName" Type="String" />
                    <asp:Parameter Name="ShipAddress" Type="String" />
                    <asp:Parameter Name="ShipCity" Type="String" />
                    <asp:Parameter Name="ShipRegion" Type="String" />
                    <asp:Parameter Name="ShipPostalCode" Type="String" />
                    <asp:Parameter Name="ShipCountry" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                    <asp:Parameter Name="OrderDate" Type="DateTime" />
                    <asp:Parameter Name="RequiredDate" Type="DateTime" />
                    <asp:Parameter Name="ShippedDate" Type="DateTime" />
                    <asp:Parameter Name="ShipVia" Type="Int32" />
                    <asp:Parameter Name="Freight" Type="Decimal" />
                    <asp:Parameter Name="ShipName" Type="String" />
                    <asp:Parameter Name="ShipAddress" Type="String" />
                    <asp:Parameter Name="ShipCity" Type="String" />
                    <asp:Parameter Name="ShipRegion" Type="String" />
                    <asp:Parameter Name="ShipPostalCode" Type="String" />
                    <asp:Parameter Name="ShipCountry" Type="String" />
                    <asp:Parameter Name="OrderID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
