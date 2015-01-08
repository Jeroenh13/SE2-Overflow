<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Ontwikkelopdracht.HomePage" %>
<%@ Import Namespace="Classes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="updatePanel">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate >
                <asp:Button runat="server" ID ="NieuweStickyNote" OnClick="NieuweStickyNote_Click" Text="Nieuwe Sticky Note"/>
                <div id="sn" runat="server">
                         <table style="float:left;">
                            <tr class ="inschrijfTable">
                                <td>
                                    Titel: 
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="tbTitel"></asp:TextBox>
                                </td>
                            </tr>
                             <tr class ="inschrijfTable">
                                <td>
                                    Bericht:
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="tbBericht" TextMode="MultiLine"></asp:TextBox>
                                    <asp:Button runat="server" ID="AddNewStickyNote" OnClick="AddNewStickyNote_Click" Text="Post"/>
                                </td>
                            </tr>
                        </table>
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                         <br />
                </div>

                <div style="overflow:scroll;height:50%;" runat="server">
                    <asp:ListView ID="lvStickynotes" runat="server" OnItemDataBound="lvStickynotes_OnItemDataBound" OnItemCommand="lvStickynotes_OnItemCommand">
                        <ItemTemplate>
                            <div runat="server" class="sticky" onclick ="GoTo_StickyNote">
                                <label id="ID" hidden="hidden">ID <%# Eval("GetID") %></label>
                                Titel: <%# Eval("Titel") %> <br/>
                                Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                                Naam: <%# Eval("Bestuur.Naam") %> <br/>
                                Bericht: <%# Eval("Bericht") %> <br/>
                                <asp:Button cssClass="snbutton" ID="btnToSticky_Note" runat="server" Text="Ga naar ->" CommandName="Select" CommandArgument='<%# Eval("GetID") %>' />
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <asp:Button ID="btnLedenInfo" runat="server" OnClick="btnLedenInfo_Click" Text="Leden Info" CssClass="homePageButtons"/>
    <asp:Button ID="btnNieuwLid" runat="server" OnClick="btnNieuwLid_Click" Text="Nieuw Lid" CssClass="homePageButtons"/>
    <br />
    <!--Pagina's nog niet geimplementeerd
    <asp:Button ID="btnPrijsLijst" runat="server" OnClick="btnPrijsLijst_Click" Text="Prijslijst" CssClass="homePageButtons"/>
    <asp:Button ID="btnEvent" runat="server" OnClick="btnEvent_Click" Text="Nieuw Event" CssClass="homePageButtons"/> -->

</asp:Content>
