<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilterMain.aspx.cs" Inherits="FilteringSystem.FilterMain" %>

<!DOCTYPE html>
<link rel="Stylesheet" href="StyleSheet1.css" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 37px;
        }
        .auto-style2
        {
            width: 285px;
        }
        .auto-style3
        {
            height: 25px;
        }
        .auto-style4
        {
            height: 25px;
            width: 176px;
        }
        .auto-style5
        {
            height: 27px;
        }
        .auto-style6
        {
            height: 27px;
            width: 387px;
        }
        .auto-style7
        {
            width: 387px;
        }
        .auto-style8
        {
            width: 37px;
            height: 23px;
        }
        .auto-style9
        {
            width: 285px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #006600">
    
        <asp:Label ID="Label1" runat="server" Font-Names="Microsoft Tai Le" Font-Overline="False" Font-Size="X-Large" Text="Welcome to Filtering System" ForeColor="White"></asp:Label>
        <br />
        <br />
    
    </div>
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
            <asp:Label ID="Label3" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large" Text="Select Batch:   "></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="batch" runat="server" Height="30px" Width="250px" style="margin-top: 6px">
                <asp:ListItem>2008</asp:ListItem>
                <asp:ListItem>2009</asp:ListItem>
                <asp:ListItem>2010</asp:ListItem>
                <asp:ListItem>2011</asp:ListItem>
                <asp:ListItem>2012</asp:ListItem>
                <asp:ListItem>2013</asp:ListItem>
                <asp:ListItem>2014</asp:ListItem>
            </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large" Text="Filter Students by:   "></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="250px">
                <asp:ListItem>School</asp:ListItem>
                <asp:ListItem>Degree Program</asp:ListItem>
            </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
            </tr>
        </table>
        <div>
            <div>
                <asp:Panel ID="Panel1" runat="server">
                    <asp:Label ID="Label6" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large" Text="Filter Students by:   "></asp:Label>
                </asp:Panel>
                <asp:Panel ID="Panel2" runat="server">
                </asp:Panel>
                <br />
                <br />
                <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Height="35px" Text="Go" Width="115px" BorderStyle="None" CssClass="myHoverButton2" Font-Names="Microsoft Tai Le" Font-Size="Medium" />
                </td>
                <td class="auto-style3"></td>
            </tr>
        </table>
            </div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Names="Microsoft Tai Le" Font-Size="Large" Text="Total Number of Student(s) on Filtered Category:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
