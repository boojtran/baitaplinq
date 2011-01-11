<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExampLINQ._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <br/>
    <div align=center>
        <table style="width: 80%;" border='0' cellpadding='3' cellspacing='0'>
            <tr>
                <td align=right>
                    <b>From Date:
                </b>
                </td>
                <td>
                    <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                </td>
                <td align=left>
                    (yyyy/mm/dd)</td>
                <td align=right>
                    <b>Name :</b></td>
                <td>
                    &nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;</td>
                <td align=right>
                    &nbsp;<b>Account&nbsp; :</b></td>
                <td>
                    &nbsp;<asp:TextBox ID="txtAcount" runat="server"></asp:TextBox>
&nbsp;</td>
            </tr>
            <tr>
                <td align=right> 
                    <b>To Date
                    :</b></td>
                <td>
                    <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>
                </td>
                <td align=left>
                    (yyyy/mm/dd)</td>
                <td align=right>
                    <b>Group :</b></td>
                <td>
                    <asp:TextBox ID="txtGroup" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="7" align=right>
                    
                    <asp:Button ID="btnFilter" runat="server" Text="Clear Filter" 
                        onclick="btnFilter_Click" />
                    <asp:Button ID="btnLoadData" runat="server" Text="Load Data" 
                        onclick="btnLoadData_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                    <asp:Button ID="btnAddNews" runat="server" Text="Add New" />              
                    <asp:Button ID="btnEditItem" runat="server" Text="Edit Item" />                 
                </td>
            </tr>
        </table>
     
    
    </div>
    <br />
    <div align =center>
        <asp:GridView ID="gridNhanVien" runat="server"  Width="80%" BackColor="White" 
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
