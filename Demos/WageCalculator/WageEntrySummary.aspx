<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WageEntrySummary.aspx.cs" Inherits="CIS305_Web_Master_Project.Demos.WageCalculator.WageEntrySummary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1247px">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
       
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"  />
        <asp:BoundField DataField="WorkHours" HeaderText="WorkHours" SortExpression="WorkHours"  />
        <asp:BoundField DataField="WeeklyWage" HeaderText="WeeklyWage" SortExpression="WeeklyWage" />
    </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Height="20px" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Height="20" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
</asp:Content>
