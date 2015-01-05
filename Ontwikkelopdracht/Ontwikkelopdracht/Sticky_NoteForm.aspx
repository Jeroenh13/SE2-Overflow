<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sticky_NoteForm.aspx.cs" Inherits="Ontwikkelopdracht.Sticky_NoteForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="stickynote" runat="server" >
        <ItemTemplate>
            <div runat="server" class="sticky">
                Titel: <%# Eval("Titel") %> <br/>
                Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                Naam: <%# Eval("Bestuur.Naam") %> <br/>
                Bericht: <%# Eval("Bericht") %>
            </div>
        </ItemTemplate>
    </asp:ListView>
    <h2>
        Reacties:
    </h2>
    <asp:ListView runat="server" ID="lvReacties" OnItemDataBound="lvReacties_OnItemDataBound">
        <ItemTemplate>
            <div runat="server" class="reactie">
                Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                Naam: <%# Eval("user.Naam") %> <br/>
                Bericht: <%# Eval("Bericht") %> <br/>
            </div>

               <asp:ListView ID="lvReactieChild" runat="server">
                    <ItemTemplate>
                        <div runat="server" class="child">
                            Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                            Naam: <%# Eval("user.Naam") %> <br/>
                            Bericht: <%# Eval("Bericht") %> <br/>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
