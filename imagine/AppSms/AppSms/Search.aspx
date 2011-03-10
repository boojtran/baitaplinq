<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AppSms.Search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="CSS/tableComment.css" rel="stylesheet" type="text/css" />
    <link href="CSS/Gridview.css" rel="stylesheet" type="text/css" />
    <link href="CSS/common.css" rel="stylesheet" type="text/css" />
    <script>
         function floatingWindows(name) {
             var width=650;
             var height=300;
             var left   = (screen.width  - width)/2;
             var top    = (screen.height - height)/2;
             window.open(name,'AddNew','width='+width+', height='+height+',top='+top+', left='+left+',menubar=no,toolbar=no,location=no,status=yes,scrollbars=yes,resizable=no');
         }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div id='html_2' align="center">
     <table border="0" cellpadding="5px" width=80%>
                    <tr>
                        <td align=right>&nbsp;</td>
                        <td align=left>
                            &nbsp;</td>
                        
                    </tr>

                    <tr>
                        <td align=right>Nhập Họ tên Tìm Kiếm :</td>
                        <td align=left>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Tìm Kiếm" 
                                onclick="btnSearch_Click" />
                        </td>
                        
                    </tr>

                    <tr>
                        <td align=right>&nbsp;</td>
                        <td align=left>
                            <asp:Label ID="lablMessSearch" runat="server" Text=""></asp:Label>
                        </td>
                        
                    </tr>

                    <tr>
                    <td colspan="2" align=center>
                        <asp:GridView ID="GridView2" runat="server" DataKeyNames="IDTeacher"
                        AutoGenerateColumns="False"  
                        GridLines="None"  
                        AllowPaging="false" Width="100%"
                        CssClass="mGrid"  
                        PagerStyle-CssClass="pgr"  
                        AlternatingRowStyle-CssClass="alt" onrowcommand="GridView2_RowCommand">
                        <Columns>
                        <asp:BoundField DataField="IDTeacher" HeaderText="IDTeacher"
                        Visible=false/>
                        <asp:BoundField DataField="Phone" HeaderText="Phone" />            
                        <asp:BoundField DataField="Account" HeaderText="Account" />  
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="FullName" HeaderText="FullName" />                                                                 
                                                                                      
                        <asp:buttonfield ButtonType="Image" ImageUrl="Images/edit.gif" commandname="ibtnEdit" HeaderText="Action" />                                                                           
                        </Columns>                    

<PagerStyle CssClass="pgr"></PagerStyle>

<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        </asp:GridView>
                    </td>
                    </tr>
            </table>
    </div>
    </div>
    </form>
</body>
</html>
