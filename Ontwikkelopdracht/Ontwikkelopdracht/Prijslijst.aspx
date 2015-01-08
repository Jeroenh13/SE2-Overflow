<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Prijslijst.aspx.cs" Inherits="Ontwikkelopdracht.Prijslijst" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Gridview ID ="GVprijslijstDrank" runat="server" AutoGenerateColumns ="False" style="float:left;">
        <Columns>
            <asp:BoundField DataField="Naam" HeaderText="Naam"/>
            <asp:BoundField DataField="Prijs" HeaderText="Prijs" />
        </Columns>
    </asp:Gridview>
    <asp:Gridview ID ="GVprijslijstSnacks" runat="server" AutoGenerateColumns ="False" style="float:left; margin-left:10%;">
        <Columns>
            <asp:BoundField DataField="Naam" HeaderText="Naam"/>
            <asp:BoundField DataField="Prijs" HeaderText="Prijs" />
        </Columns>
    </asp:Gridview>
</asp:Content>
