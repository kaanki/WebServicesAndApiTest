<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TweetPage.aspx.cs" Inherits="WebServisDevam.TweetPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
      <asp:Button ID="btnGetir" runat="server" Text="TwitGetir" OnClick="btnGetir_Click"/>
      <asp:Button ID="btnJsonGetir" runat="server" Text="Json Getir" OnClick="btnJsonGetir_Click"/>
      <asp:ListBox ID="Listbox1" runat="server">

      </asp:ListBox>
    </div>
    </form>
</body>
</html>
