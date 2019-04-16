<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagecycle.aspx.cs"  EnableEventValidation = "false" Inherits="GridView.pagecycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="theForm" runat="server">    
      <asp:ScriptManager runat="server">  
     </asp:ScriptManager>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoPostBack="true" AutoGenerateColumns="False"
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnDataBinding="GridView1_DataBinding" 
            OnDataBound="GridView1_DataBound" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging"
            OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowCreated="GridView1_RowCreated"
            OnRowDataBound="GridView1_RowDataBound" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting" 
            OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating" 
            OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnSorted="GridView1_Sorted" OnSorting="GridView1_Sorting"
            DataKeyNames="EmpID" > <%--DataSourceID="SqlDataSource1"--%> 
            <Columns>
                <asp:BoundField DataField="EmpID" HeaderText="EmpID" SortExpression="EmpID" />
                <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
               <%-- <asp:BoundField DataField="PresentAddress" HeaderText="PresentAddress" SortExpression="PresentAddress" />
                <asp:BoundField DataField="Area" HeaderText="Area" SortExpression="Area" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Qualification" HeaderText="Qualification" SortExpression="Qualification" />
                <asp:TemplateField HeaderText="Location">                     
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("City") + " " + Eval("Country") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
            </Columns>
            <HeaderStyle Font-Bold="True" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
        <%--<asp:SqlDataSource ID="SqlDataSource1"  runat="server" ConnectionString="<%$ ConnectionStrings:employeesConnectionString %>" SelectCommand="SELECT [EmpID], [EmpName], [Mobile], [PresentAddress], [Area], [City], [Country], [Qualification] FROM [EmployeeDetails]"></asp:SqlDataSource>--%>
        </ContentTemplate>
        </asp:UpdatePanel>
        </form>
</body>
</html>
