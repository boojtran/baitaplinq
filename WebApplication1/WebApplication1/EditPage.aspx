<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="ExampLINQ.EditPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 119px;
        }
    </style>
    <script>
        function Exit() {
            window.close();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div align=center>
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Account :</td>
            <td align=left>
                <asp:TextBox ID="txtAc" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                BirthDate</td>
            <td align=left>
                <asp:TextBox ID="txtBirth" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                FullName</td>
            <td align=left>
                <asp:TextBox ID="txtFullname" runat="server" Width="171px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Group</td>
            <td align=left>
                <asp:TextBox ID="txtGroup" runat="server" Width="173px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                StartDate</td>
            <td align=left>
                <asp:TextBox ID="txtStartDate" runat="server" Width="171px"></asp:TextBox>
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
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
    
</body>
</html>
