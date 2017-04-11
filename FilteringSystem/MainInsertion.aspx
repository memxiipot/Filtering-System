<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainInsertion.aspx.cs" Inherits="FilteringSystem.MainInsertion" %>

<!DOCTYPE html>
<link href="StyleSheet1.css" rel="stylesheet" />
<link href="StyleSheet2.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Microsoft Tai Le'">
    <div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Filtering System Database Population"></asp:Label>
        <br />
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table style="width:100%;">
            <tr>
                <td style="text-align: right">
                    <asp:Button ID="Button1" runat="server" CssClass="main" Text="Add Student Batch Records" Font-Names="Microsoft Tai Le" Font-Size="Medium" Height="210px" OnClick="Button1_Click" Width="210px" />
                    <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Label"></asp:Label>
                    <asp:Button ID="Button2" runat="server" Text="Add Enrollees Records" CssClass="main" Font-Names="Microsoft Tai Le" Font-Size="Medium" Height="210px" OnClick="Button2_Click" Width="210px" />
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
