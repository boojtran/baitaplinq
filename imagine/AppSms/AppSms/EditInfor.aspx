<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditInfor.aspx.cs" Inherits="AppSms.EditInfor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit Page</title>
    <link href="CSS/common.css" rel="stylesheet" type="text/css" />
    <link href="CSS/tableComment.css" rel="stylesheet" type="text/css" />
    <script src="jscalendar/lang/calendar-vn.js" type="text/javascript"></script>
    <script src="jscalendar/calendar.js" type="text/javascript"></script>
    <script src="jscalendar/calendar-setup.js" type="text/javascript"></script>
     <script>
        function Exit() {
            window.close();
        }
    </script>
    <style type="text/css">
        .style2
        {
            width: 30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align=center>
    <table style="width:100%;">
        <tr>
            <td align="right" class="contact" colspan="2" 
                style="color: #FFFFFF; font-weight: bold; font-size: small">
                Sửa Thông Tin Giảng Viên</td>
        </tr>
        <tr>
            <td align="right" class="style2">
                FullName :</td>
            <td align=left>
                <asp:TextBox ID="txtFullName" runat="server" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                BirthDate :</td>
            <td align=left>
                <asp:TextBox ID="txtCalendar" runat="server" Width="80%"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                Email :</td>
            <td align=left>
                <asp:TextBox ID="txtEmail" runat="server" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                Degree : </td>
            <td align=left>
                <asp:DropDownList ID="drDegree" runat="server" DataTextField="DegreeName" 
                    DataValueField="ID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                Phone</td>
            <td align=left>
                <asp:TextBox ID="txtPhone" runat="server" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                Permission :</td>
            <td align=left>
                <asp:DropDownList ID="drPermission" runat="server" DataTextField="PermissionName" 
                    DataValueField="IDPermission">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                Account :</td>
            <td align=left>
                <asp:TextBox ID="txtAccount" runat="server" ReadOnly="true" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr align=center>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                    onclick="btnCancel_Click" OnClientClick="Exit()" />
            </td>
        </tr>
        <tr align=center>
            <td colspan="2">
                <asp:Label ID="sqlLabelError" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
    
</body>
</html>
