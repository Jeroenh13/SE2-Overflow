<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameGridForm.aspx.cs" Inherits="GridViewDemo.GameGridForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:darkslategray">
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gameGrid" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="gameGrid_PageIndexChanging" OnSelectedIndexChanged="gameGrid_SelectedIndexChanged" OnSorting="gameGrid_Sorting" PageSize="6">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
                <asp:BoundField DataField="Prijs" HeaderText="Prijs" SortExpression="Prijs" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    
        <br />
    
    </div>
        <asp:ListView ID="gameList" runat="server" GroupItemCount="3">
            <ItemTemplate>
                    <div style="float:left;width:300px;border:solid;border-radius:5px;margin:10px;background-color:navy;border-color:gold;color:gold;font-family:Arial;padding:5px;">
                        <b>Titel: </b> <%# Eval("Titel") %> <br />
                        <b>Genre: </b> <%# Eval("Genre") %> <br />
                        <b>Prijs: </b> <%# Eval("Prijs") %> <br />
                    </div>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <div runat="server">
                    <div id="groupPlaceHolder" runat="server"></div>
                </div>
            </LayoutTemplate>
            <GroupTemplate>
                <div runat="server">
                    <div id="itemPlaceHolder" runat="server"></div>
                </div>
            </GroupTemplate>
            <GroupSeparatorTemplate>
                <div runat="server">
                    <div style="clear:both" />
                </div>
            </GroupSeparatorTemplate>
        </asp:ListView>
    </form>
</body>
</html>
