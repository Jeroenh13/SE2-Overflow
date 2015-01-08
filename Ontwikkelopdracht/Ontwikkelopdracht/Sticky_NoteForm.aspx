﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sticky_NoteForm.aspx.cs" Inherits="Ontwikkelopdracht.Sticky_NoteForm1" %>
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
                ParentID: <%# Eval("ParentID") %><br />
                Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                Naam: <%# Eval("user.Naam") %> <br/>
                Bericht: <%# Eval("Bericht") %> <br/>
                <asp:Button runat="server" ID="btnnew" CommandName="Reageer" CommandArgument='<%# Eval("GetID") %>' Text="Reageer" /> 
                <asp:table runat="server" ID="reactietabel">
                    <asp:tablerow class ="inschrijfTable" runat="server">
                        <asp:TableCell runat="server">
                            Bericht:
                        </asp:TableCell>
                        <asp:TableCell runat="server">
                            <asp:TextBox runat="server" ID="tbBericht" TextMode="MultiLine" Height="94px" Width="298px" />
                            <asp:Button runat="server" ID="AddReactie" Text="Post" CommandName="Post" CommandArgument='<%# Eval("GetID") %>'/>
                        </asp:TableCell>
                    </asp:tablerow>
                </asp:table>
            </div>
               <asp:ListView ID="lvReactieChild" runat="server">
                    <ItemTemplate>
                        <div runat="server" class="child">
                            Datum: <%# Eval("Datum","{0:d/M/yyyy}") %> <br />
                            Naam: <%# Eval("user.Naam") %> <br/>
                            Bericht: <%# Eval("Bericht") %> <br/>
                            
<%--                            <asp:Button runat="server" ID="btnnewChild" OnClick ="btnnew_OnClick" Text="Reageer"/>
                                <asp:table runat="server" ID="reactietabelChild">
                                    <asp:tablerow class ="inschrijfTable" runat="server">
                                        <asp:TableCell runat="server">
                                            Bericht:
                                        </asp:TableCell>
                                        <asp:TableCell runat="server">
                                            <asp:TextBox runat="server" ID="tbBericht" TextMode="MultiLine" Height="94px" Width="298px"/>
                                            <asp:Button runat="server" ID="AddReactie" OnClick="AddReactie_Click" Text="Post"/>
                                        </asp:TableCell>
                                    </asp:tablerow>
                                </asp:table>--%>
                                
                            </div>
                    </ItemTemplate>
                </asp:ListView>
        </ItemTemplate>
    </asp:ListView>
    <table style="float:left;">
         <tr class ="inschrijfTable">
            <td>
                Bericht:
            </td>
            <td>
                <asp:TextBox runat="server" ID="tbBericht" TextMode="MultiLine" Height="94px" Width="298px"></asp:TextBox>
                <asp:Button runat="server" ID="AddReactie" OnClick="AddReactie_Click" Text="Post"/>
             </td>
          </tr>
    </table>
</asp:Content>
