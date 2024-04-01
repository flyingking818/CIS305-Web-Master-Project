<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WageCalculator.aspx.cs" Inherits="CIS305_Web_Master_Project.Demos.WageCalculator.WageCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="width:300px; font-size:x-large"> Consultant Name:  </td>
            <td style="width:700px">
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
             <td style="width:300px; font-size:x-large"> Job Title:  </td>
             <td style="width:700px">
                 <asp:DropDownList runat="server" ID="JotTitle">
                     <asp:ListItem>---Please Select---</asp:ListItem>
                     <asp:ListItem Value="JobCode1">Developer</asp:ListItem>
                 </asp:DropDownList>        

             </td>
        </tr>

    </table>



</asp:Content>
