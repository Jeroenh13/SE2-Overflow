<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InlogForm.aspx.cs" Inherits="Ontwikkelopdracht.InlogForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label id="lblError" runat="server"></asp:label>
    Username: <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox><br />
    Password: <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" Text="Button" OnClick="btnLogin_Click" />
</asp:Content>
