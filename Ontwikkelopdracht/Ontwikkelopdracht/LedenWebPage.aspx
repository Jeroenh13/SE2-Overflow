<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LedenWebPage.aspx.cs" Inherits="Ontwikkelopdracht.LedenWebPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:repeater id="rptAlphabet" runat="server" OnItemCommand="rptAlphabet_OnItemCommand">
        <ItemTemplate>
            <asp:LinkButton ID="lnkAlphabet" runat="server" CommandName ="Alphabet" Text="<%# Container.DataItem %>"/>
        </ItemTemplate>
    </asp:repeater>
    <asp:GridView CssClass="LedenGrid" ID="GVleden" runat="server" AutoGenerateColumns="False" RowStyle-BackColor="#CCD3FF" AlternatingRowStyle-BackColor="White"
        HeaderStyle-BackColor="#4358E6" HeaderStyle-ForeColor="white">
        <Columns>
            <asp:BoundField DataField="Naam" HeaderText="Naam"/>
            <asp:BoundField DataField="Achternaam" HeaderText="Achternaam"/>
            <asp:BoundField DataField="Emailadres" HeaderText="Emailadres"/>
            <asp:BoundField DataField="Geslacht" HeaderText="Geslacht"/>
            <asp:BoundField DataField="GeboorteDatum" HeaderText="GeboorteDatum" DataFormatString="{0:d/M/yyyy}"/>
            <asp:BoundField DataField="RegistratieDatum" HeaderText="RegistratieDatum" DataFormatString="{0:d/M/yyyy}"/>
            <asp:BoundField DataField="Betaalstatus" HeaderText="Betaalstatus"/>
        </Columns>
    </asp:GridView>
    <div>
    
        </div>   
</asp:Content>