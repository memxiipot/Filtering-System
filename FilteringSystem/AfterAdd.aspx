<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfterAdd.aspx.cs" Inherits="FilteringSystem.AfterAdd" %>

<!DOCTYPE html>
<link href="StyleSheet1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 199px;
        }
        .auto-style2
        {
            width: 199px;
            height: 25px;
        }
        .auto-style3
        {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'microsoft Tai Le'">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Student Record(s) Added"></asp:Label>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" style="font-size: large">
                    <asp:Label ID="Label2" runat="server" Text="Total Number of Record(s)"></asp:Label>
                </td>
                <td class="auto-style3" style="font-size: large">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1" style="font-size: large">
                    <asp:Label ID="Label3" runat="server" Text="Total Inserted Record(s)"></asp:Label>
                </td>
                <td style="font-size: large">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size: large"></td>
                <td class="auto-style3" style="font-size: large"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size: large">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
                <td class="auto-style3" style="font-size: large">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Go Back" BorderStyle="None" CssClass="myHoverButton2" Font-Names="Microsoft Tai Le" Font-Size="Large" OnClick="Button1_Click" Height="40px" Width="160px" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
