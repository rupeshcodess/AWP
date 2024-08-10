<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 33px">
    <form id="form1" runat="server">
    Enter First Number
    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="111px"></asp:TextBox>
    &nbsp;<p>
        Enter Second Number<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
&nbsp;Enter Third Number<asp:TextBox ID="TextBox4" runat="server" 
        ontextchanged="TextBox4_TextChanged"></asp:TextBox>
    <p>
        Enter Fourth Number<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Onclick="submit_1" Text="Button" />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </form>
</body>
</html>
