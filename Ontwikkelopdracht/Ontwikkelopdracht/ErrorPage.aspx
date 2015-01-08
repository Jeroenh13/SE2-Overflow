<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Ontwikkelopdracht.ErrorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server">Log eerst in</asp:Label><br />
    <asp:Button ID="btnlogin" runat="server" Text="Log In" OnClick="btnlogin_Click" />
</asp:Content>
