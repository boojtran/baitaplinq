<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SmsSend.aspx.cs" Inherits="AppSms.SmsSend" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="CSS/common.css" rel="stylesheet" type="text/css" />
    <link href="CSS/Gridview.css" rel="stylesheet" type="text/css" />
    <link href="CSS/tableComment.css" rel="stylesheet" type="text/css" />
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">

            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align=right>
                    Gửi tới :</td>
                <td >
                    <asp:TextBox ID="txtTo1" runat="server" Width=80%></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align=right>
                    Nội Dung :</td>
                <td>
                    <asp:TextBox ID="txtNoiDung" runat="server" Height="71px" TextMode="MultiLine" 
                        Width="80%"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Send Sms" 
                        onclick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Thoát" onclick="Button2_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

