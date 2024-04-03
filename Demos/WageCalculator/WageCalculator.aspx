﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WageCalculator.aspx.cs" Inherits="CIS305_Web_Master_Project.Demos.WageCalculator.WageCalculator" %>
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
                 <asp:DropDownList runat="server" ID="JobTitle">
                     <asp:ListItem>---Please Select---</asp:ListItem>
                     <asp:ListItem Value="JobCode1">Developer</asp:ListItem>
                     <asp:ListItem Value="JobCode2">Analyst</asp:ListItem>
                     <asp:ListItem Value="JobCode3">Architect</asp:ListItem>
                     <asp:ListItem Value="JobCode4">Project Lead</asp:ListItem>
                 </asp:DropDownList>        

             </td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;Consultant Skills:</td>
            <td style="width: 700px">
                <asp:CheckBoxList runat="server" ID="SkillsList">
                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>ASP.NET</asp:ListItem>
                    <asp:ListItem>HTML</asp:ListItem>
                    <asp:ListItem>CSS</asp:ListItem>
                    <asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>Swift</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:CheckBoxList>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;MCSD Certificate?</td>
            <td style="width: 700px">
                <asp:RadioButtonList runat="server" ID="MCSDCertificate" RepeatDirection="Horizontal">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;Work Hours/Week:</td>
            <td style="width: 700px">
                <asp:TextBox runat="server" ID="WorkHours"></asp:TextBox>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">
                <asp:Button runat="server" Text="Calculate and Save" ID="Submit" OnClick="Submit_Click"></asp:Button>&nbsp;</td>
            <td style="width: 700px">
                <asp:Label runat="server" Text="" ID="ResultHTML"></asp:Label>&nbsp;</td>
        </tr>

    </table>



</asp:Content>
