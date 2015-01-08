<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="InlogForm.aspx.cs" Inherits="Ontwikkelopdracht.InlogForm" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="bootstrap.css">
    <link rel="stylesheet" type="text/css" href="overflow.css">
    <title>Overflow</title>
</head>
<body>
    <form id="MasterPage" runat="server">
        <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="server">
            </ajaxToolkit:ToolkitScriptManager>
    <div class="wrapper">
        <a href="HomePage.aspx">
            <img class="img" src="Images/vector.png" />
        </a>
        <div class="header">
            Overflow
        </div>
        <div class="content">
            <asp:label id="lblError" runat="server"></asp:label>
                Username: <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox><br />
                Password: <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br />
                <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
        </div>
        <div class="footer">
            Overflow - Jeroen Hendriks
        </div>
    </div>
    </form>
</body>
</html>
