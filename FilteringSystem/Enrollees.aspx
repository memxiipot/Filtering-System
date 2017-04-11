<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enrollees.aspx.cs" Inherits="FilteringSystem.Enrollees" %>

<!DOCTYPE html>
<link href="StyleSheet1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4
        {
            width: 100%;
            height: 111px;
        }
        .auto-style6
        {
            height: 37px;
        }
        .auto-style7
        {
            width: 71px;
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Microsoft Tai Le" Font-Size="XX-Large" Text="Enrollee Records"></asp:Label>
    
        <br />
        <br />
    
    </div>
        <div>
        </div>
        <table class="auto-style4" style="font-family: 'Microsoft Tai Le'; font-size: medium;">
            <tr>
                <td class="auto-style7" style="text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="SchoolYear" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="sy" runat="server" Height="30px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="text-align: right">
                    <asp:Label ID="Label3" runat="server" Text="Term" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="term" runat="server" Font-Names="Microsoft Tai Le" Height="30px" Width="200px">
                        <asp:ListItem>FIRST</asp:ListItem>
                        <asp:ListItem>SECOND</asp:ListItem>
                        <asp:ListItem>THIRD</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="text-align: right">
                    <asp:Button ID="Button1" runat="server" BorderStyle="None" Height="40px" OnClick="Button1_Click" Text="Search " Width="160px" CssClass="myHoverButton2" Font-Size="Large" />
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" style="text-align: right">
                    <asp:Button ID="Button2" runat="server" BorderStyle="None" CssClass="myHoverButton2" Font-Names="Microsoft Tai Le" Height="40px" OnClick="Button2_Click" Text="Insert Rec" Width="160px" Font-Size="Large" />
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style7" style="text-align: right">
                    <asp:Button ID="Button3" runat="server" BorderStyle="None" CssClass="myHoverButton2" Font-Names="Microsoft Tai Le" Font-Size="Large" Height="40px" OnClick="Button3_Click" Text="Home" Width="160px" />
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
        <div Style="Overflow:Auto ;max-height: 375px;">
            <asp:GridView ID="gv" runat="server" CellPadding="4" Font-Names="Microsoft Tai Le" ForeColor="#333333" GridLines="None">
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
