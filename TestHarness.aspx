<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestHarness.aspx.cs" Inherits="WebClient.TestHarness" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmMain" runat="server">
        <table width="400px" border="0">
            <tr>
                <td width="150px">Full Name
                </td>
                <td>
                    <asp:TextBox ID="txtFullName" runat="server" Width="100%" />
                </td>
            </tr>
            <tr>
                <td>Age
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server" Width="100%" />
                </td>
            </tr>
        </table>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br /><br />
        <asp:TextBox ID="txtResult" runat="server" TextMode="MultiLine" ReadOnly="true" Rows="10" Width="400px" />
    </form>
</body>
</html>
