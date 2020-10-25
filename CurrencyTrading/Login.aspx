<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CurrencyTrading.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <%-- Header --%>
            <tr>
                <td>
                    Account Login
                </td>
                <td align="right">
                     <asp:LinkButton id="lbLogin" runat="server"  PostBackUrl="~/Registration.aspx" >Sign Up</asp:LinkButton>
                </td>
            </tr>
            <%-- Login UserName & Password --%>
            <tr>
                <td>
                    <asp:Label runat="server" Text ="User Name: " Width="120"/></td>
                <td>
                    <asp:TextBox runat="server" ID="txtUserName" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text ="Password: " Width="120"/></td>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode ="Password" />
                </td>
            </tr>
            <%-- Button Login --%>
            <tr>
                <td colspan="2">
                    <asp:Button runat="server" ID="btnLogin" Text="Sign In" OnClick="btnLogin_Click" />
                </td>               
            </tr>
            <%-- Error Message Prompt --%>
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="lblErrorMsg"  ForeColor="Red"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
