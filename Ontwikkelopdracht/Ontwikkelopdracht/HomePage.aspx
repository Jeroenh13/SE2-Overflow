<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Ontwikkelopdracht.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="updatePanel">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="Sticky-Note-LB"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <asp:Button ID="btnLedenInfo" runat="server" OnClick="btnLedenInfo_Click" Text="Leden Info" CssClass="homePageButtons"/>
    <asp:Button ID="btnNieuwLid" runat="server" OnClick="btnNieuwLid_Click" Text="Nieuw Lid" CssClass="homePageButtons"/>
    <br />
    <asp:Button ID="btnPrijsLijst" runat="server" OnClick="btnPrijsLijst_Click" Text="Prijslijst" CssClass="homePageButtons"/>
    <asp:Button ID="btnEvent" runat="server" OnClick="btnEvent_Click" Text="Nieuw Event" CssClass="homePageButtons"/>

</asp:Content>
