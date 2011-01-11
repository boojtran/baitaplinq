<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNew.aspx.cs" Inherits="ExampLINQ.AddNew" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        Add new employee<br />
        <br />
        
        <table style="width:73%" align="center">
            <tr>
                <td class="style1">
                    Start Date</td>
                <td class="style2">
                    <asp:TextBox ID="txtStartDate" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Full Name</td>
                <td class="style2">
                    <asp:TextBox ID="txtFullName" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Account</td>
                <td class="style2">
                    <asp:TextBox ID="txtAccount" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    BirthDate</td>
                <td class="style2">
                    <asp:TextBox ID="txtBirthDate" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Group</td>
                <td class="style2">
                    <asp:TextBox ID="txtGroup" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add New" onclick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
