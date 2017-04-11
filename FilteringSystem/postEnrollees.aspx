<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postEnrollees.aspx.cs" Inherits="FilteringSystem.postEnrollees" %>

<!DOCTYPE html>
<link href="StyleSheet1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .myHoverButton2
{
    background-color:#1A6F20;
    -webkit-border-radius: 7px;
    -webkit-transition-duration: 0.5s;
    margin-bottom: 0px;
    color:white;
}
        .auto-style1
        {
            width: 210px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Microsoft Tai Le'">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Enrollee Record(s)"></asp:Label>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" style="font-size: large">
                    <asp:Label ID="Label2" runat="server" Text="Total Number of Record(s)"></asp:Label>
                </td>
                <td style="font-size: large">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">
                    <asp:Label ID="Label3" runat="server" Text="Total Inserted Record"></asp:Label>
                </td>
                <td style="font-size: large">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">&nbsp;</td>
                <td style="font-size: large">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
                <td style="font-size: large">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" BorderStyle="None" CssClass="myHoverButton2" Font-Size="Large" OnClick="Button1_Click" Text="Go Back" Font-Names="Microsoft Tai Le" Height="40px" Width="160px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
