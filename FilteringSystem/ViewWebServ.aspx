<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewWebServ.aspx.cs" Inherits="FilteringSystem.ViewWebServ" %>

<!DOCTYPE html>
<link rel="Stylesheet" href="StyleSheet1.css" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 118px;
        }
        .auto-style2
        {
            width: 118px;
            height: 39px;
        }
        .auto-style3
        {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Microsoft Tai Le" Font-Size="XX-Large" Text="Import Data from web service"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" style="text-align: right">
                    <asp:Label ID="Batch" runat="server" Font-Names="Microsoft Tai Le" Font-Size="X-Large" Text="Batch"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb1" runat="server" Height="35px" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">
                    <asp:Button ID="Button1" runat="server" BorderStyle="None" Font-Names="Microsoft Tai Le" Font-Size="Large" Height="40px" OnClick="Button1_Click" Text="View" Width="160px" CssClass="myHoverButton2" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                    <asp:Button ID="Button3" runat="server" BorderStyle="None" Font-Names="Microsoft Tai Le" Font-Size="Large" Height="40px" OnClick="Button3_Click" Text="Insert To Database" Width="160px" CssClass="myHoverButton2" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                    <asp:Button ID="Button4" runat="server" BorderStyle="None" CssClass="myHoverButton2" Font-Names="Microsoft Tai Le" Font-Size="Large" Height="40px" OnClick="Button4_Click" Text="Home" Width="160px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="msg" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Medium" Font-Overline="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                    <asp:Label ID="Batch0" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Medium" Text="# of Rows from webservice:  " Font-Overline="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="numRows" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                    <asp:Label ID="Batch1" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Medium" Text="# of rows (def. DataTable):" Font-Overline="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Names="Microsoft Tai Le" Font-Size="Large"></asp:Label>
                </td>
            </tr>
        </table>
        <div Style="Overflow:Auto;max-height: 375px; width: 350px;">
    
        <asp:GridView ID="stud" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Font-Names="Microsoft Tai Le">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    
        </div>
    </form>
</body>
</html>
