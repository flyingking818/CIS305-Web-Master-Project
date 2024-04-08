<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WageCalculator.aspx.cs" Inherits="CIS305_Web_Master_Project.Demos.WageCalculator.WageCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="width:300px; font-size:x-large"> Consultant Name:  </td>
            <td style="width:700px">
                <asp:TextBox ID="Name" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter a valid name!" ControlToValidate="Name" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>        
        <tr>
             <td style="width:300px; font-size:x-large"> Job Title:  </td>
             <td style="width:700px">
                 <asp:DropDownList runat="server" ID="JobTitle">
                     <asp:ListItem>---Please Select---</asp:ListItem>
                     <asp:ListItem Value="JobCode1">Developer</asp:ListItem>
                 </asp:DropDownList>        

             </td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;Skills:</td>
            <td style="width: 700px">&nbsp;<asp:CheckBoxList runat="server" ID="SkillsList">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>ASP.NET</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>SQL</asp:ListItem>
                <asp:ListItem>HTML</asp:ListItem>
                <asp:ListItem>CSS</asp:ListItem>
                <asp:ListItem>Swift</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;MCSD Certificate?</td>
            <td style="width: 700px">&nbsp;<asp:RadioButtonList runat="server" ID="MSCDCertificate">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList><asp:RequiredFieldValidator runat="server" ErrorMessage="Please specify the MCSD status!" ForeColor="Red" ControlToValidate="MSCDCertificate"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">&nbsp;Work Hours/Week:</td>
            <td style="width: 700px">&nbsp;<asp:TextBox runat="server" ID="WorkHours"></asp:TextBox><asp:RangeValidator runat="server" ErrorMessage="Please enter a number between 0 and 100!" ControlToValidate="WorkHours" ForeColor="Red" MinimumValue="0" MaximumValue="100" SetFocusOnError="True" Type="Double"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 300px; font-size: x-large">
                <asp:Button runat="server" Text="Calculate and Save" ID="Submit" OnClick="Submit_Click"></asp:Button>&nbsp;</td>
            <td style="width: 700px">&nbsp;<asp:Label runat="server" Text="Label" ID="ResultHTML"></asp:Label></td>
        </tr>

    </table>



</asp:Content>
