<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="minhan2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="帳號"/>
            <asp:TextBox id="account" runat="server" />
            <asp:Label runat="server" Text="密碼"/>
            <asp:TextBox id="password" runat="server" />
            <asp:Button  runat="server" Text="login" OnClick="Unnamed_Click"/>
        </div>
    </form>
</body>
</html>
