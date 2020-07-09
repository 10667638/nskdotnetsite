<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                  <img alt="logo" src="1.jpg" style="width: 126px" /></div>
        <asp:Label ID="Label6" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Italic="False" ForeColor="#0033CC" Text="NSK GROUP OF COMPANIES"></asp:Label>
        <br />
        <marquee><h3>Welcome to NSK group of companies</h3></marquee>
        <br />
        <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="131px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="login" />
        <br />
        <br />
        </div>
    </form>
</body>
</html>
