﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddLidWebPage.aspx.cs" Inherits="Ontwikkelopdracht.AddLidWebPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table style="float:left;">
        <tr class ="inschrijfTable">
            <td>
                <asp:Label ID="Label1" runat="server" Text="Voornaam: *"></asp:Label>
            </td>
            <td>
                <asp:TextBox CssClass="tbCenter" ID="tbVoornaam" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqVoornaam" runat="server" ErrorMessage="Vul een voornaam in" ControlToValidate="tbVoornaam"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class ="inschrijfTable">
            <td>
                <asp:Label ID="lblAchternaam" runat="server" Text="Achternaam:" ></asp:Label>
            </td>
            <td>
                <asp:TextBox CssClass="tbCenter" ID="tbAchternaam" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class ="inschrijfTable">
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email: *"></asp:Label>
            </td>
            <td>
                <asp:TextBox CssClass="tbCenter" ID="tbEmail" runat="server"></asp:TextBox> 
                <asp:RequiredFieldValidator ID="reqEmail" runat="server" ErrorMessage="Vul een email in" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rgExpressionEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Vul een geldig email in" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr class ="inschrijfTable">
            <td>
                <asp:Label ID="lblGeslacht" runat="server" Text="Geslacht: *"></asp:Label>
            </td>
            <td>
                <asp:DropDownList CssClass="tbCenter" ID="ddlGeslacht" runat="server">
                    <asp:ListItem Selected="True">M</asp:ListItem>
                    <asp:ListItem>V</asp:ListItem>
                </asp:DropDownList><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
            </td>
        </tr>
        <tr class ="inschrijfTable">
            <td class="inschrijfTable">
                <asp:Label ID="lblGeboortedatum" runat="server" Text="Geboortedatum:*"></asp:Label>
            </td>
            <td class="inschrijfTable">
                <asp:TextBox ID="tbGeboortedatum" runat="server" CssClass="tbCenter" ></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Vul een geldige datum in" ControlToValidate="tbGeboortedatum" ValidationExpression="^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vul een geboortedatum in" ControlToValidate="tbGeboortedatum"></asp:RequiredFieldValidator>
                <ajaxToolkit:CalendarExtender ID="CEGeboortedatum" runat="server" TargetControlID="tbGeboortedatum" Format="dd/MM/yyyy">
                </ajaxToolkit:CalendarExtender>
            </td>
        </tr>
        <tr class ="inschrijfTable">
            <td>
                <asp:Label ID="lblGeregistreerd" runat="server" Text="Geregistreerd: *"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbGeregistreerd" runat="server" CssClass="tbCenter" ></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Vul een geldige datum in" ControlToValidate="tbGeregistreerd" ValidationExpression="^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"></asp:RegularExpressionValidator>
                <ajaxToolkit:CalendarExtender ID="CEGeregistreerd" runat="server" TargetControlID="tbGeregistreerd" Format="dd/MM/yyyy">
                </ajaxToolkit:CalendarExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Vul een registratie datum in" ControlToValidate="tbGeregistreerd"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <div class ="opslaan">
        <asp:Button ID="btnOpslaan" runat="server" Text="Sla Op" CssClass="SlaOpKnop" OnClick="btnOpslaan_Click"/>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
</asp:Content>


