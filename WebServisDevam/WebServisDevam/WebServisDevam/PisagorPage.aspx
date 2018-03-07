<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PisagorPage.aspx.cs" Inherits="WebServisDevam.PisagorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtSayi1" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtSayi2" runat="server"></asp:TextBox>
    <asp:Label ID="lblSonuc" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
