<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSharpCalculator.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style ="width:100%">
        <tr>
            <td>
                Number 1:
            </td>
            <td>
                <asp:TextBox runat="server" id ="textboxNumber1"/>
            </td>
        </tr>
        <tr>
            <td>
                Number 2:
            </td>
            <td>
                <asp:TextBox runat="server" id ="textboxNumber2"/>
            </td>
        </tr>
        <tr>
            <td>
                Number 2:
            </td>
            <td>
                <asp:DropDownList runat="server" ID ="dropdownlistOperator">
                    <asp:ListItem Text="+" />
                    <asp:ListItem Text="-" />
                    <asp:ListItem Text="*" />
                    <asp:ListItem Text="/" />
                    <asp:ListItem Text ="%" />
                    <asp:ListItem Text ="m" />
                    <asp:ListItem Text ="cm" />
                    <asp:ListItem Text ="FC" />
                    <asp:ListItem Text ="GL" />
                    <asp:ListItem Text ="PK" />
                    <asp:ListItem Text ="MI" />
                    <asp:ListItem Text ="SH" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:Button Text="Calculate" runat="server" ID ="buttonCalculate" OnClick="buttonCalculate_Click"/>
                <asp:Button Text="Reset" runat="server" ID ="buttonReset" OnClick="buttonReset_Click" />
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:Label Text="Result value is : " id ="labelResult" runat="server" />
            </td>
        </tr>
    </table>

</asp:Content>
