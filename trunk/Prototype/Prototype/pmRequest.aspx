<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pmRequest.aspx.cs" Inherits="Prototype.pmRequest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Pm Request - New Items </title>
	<link rel="stylesheet" type="text/css" href="dhtmlx/dhtmlxLayout/codebase/dhtmlxlayout.css">
	<link rel="stylesheet" type="text/css" href="dhtmlx/dhtmlxLayout/codebase/skins/dhtmlxlayout_dhx_skyblue.css">
    <link rel="stylesheet" type="text/css" href="dhtmlx/dhtmlxWindows/codebase/dhtmlxwindows.css">
    <link rel="stylesheet" type="text/css" href="dhtmlx/dhtmlxWindows/codebase/skins/dhtmlxwindows_dhx_skyblue.css">
    <link rel="STYLESHEET" type="text/css" href="dhtmlx/dhtmlxTabbar/codebase/dhtmlxtabbar.css">
    <link rel="STYLESHEET" type="text/css" href="css/common.css">
    <link rel="STYLESHEET" type="text/css" href="css/tableComment.css">
    <script src="dhtmlx/dhtmlxLayout/codebase/dhtmlxcommon.js"></script>
    <script src="dhtmlx/dhtmlxLayout/codebase/dhtmlxlayout.js"></script>
    <script src="dhtmlx/dhtmlxLayout/codebase/dhtmlxcontainer.js"></script>
    <script src="dhtmlx/dhtmlxWindows/codebase/dhtmlxwindows.js"></script>
    <script src="dhtmlx/dhtmlxTabbar/codebase/dhtmlxtabbar.js"></script>
    <script>
        var tabbar;

        function doOnLoad() {
            //author dqt
                  
            //start Layout
            var dhxLayout = new dhtmlXLayoutObject("winVP", "2E", "dhx_blue");         
            //dhxLayout.cells("a").attachURL("infor.html");
            dhxLayout.cells("a").setText("Test Thử");
            dhxLayout.cells("a").hideHeader();
            dhxLayout.cells("a").setHeight(15);
            dhxLayout.cells("a").attachObject("objDivButton");
            //////start Tabbar
            dhxLayout.cells("b").hideHeader();
            tabbar = dhxLayout.cells("b").attachTabbar();
            tabbar.setSkin('dark_blue');
            tabbar.setImagePath("dhtmlx/dhtmlxTabbar/codebase/imgs/");
            tabbar.enableAutoReSize(true);
            tabbar.enableAutoSize(false, false);
            tabbar.enableScroll(true);
            tabbar.addTab("a1", "PM Details", "100px");
            tabbar.addTab("a2", "Comments & Attachments", "190px");
            tabbar.addTab("a3", "Approval", "100px");
            tabbar.addTab("a4", "Audit Trails", "100px");
            //tabbar.addTab("a7", "Xem Chi Ti&#7871;t Ph&#226;n L&#7899;p", "80%");

            tabbar.setContent("a1", "html_1");
            tabbar.setContent("a2", "html_2");
            tabbar.setContent("a3", "html_3");
            tabbar.setContent("a4", "html_4");
            //////////Ways of Insert content to tab 2
            //var dhxLayout2 = tabbar.cells("a2").attachLayout("1C");
            //dhxLayout2.cells("a").attachURL("dangkyhoc.html");
            //dhxLayout2.cells("a").hideHeader();
            ///////////////////////////Insert Contend to tab 7
            //var dhxLayout7 = tabbar.cells("a7").attachLayout("1C");
            //dhxLayout7.cells("a").attachURL("xemchitietlop.html");
            //dhxLayout7.cells("a").hideHeader();
            //tabbar.setContentHTML("a3", "<br/>:X <b>HTML</b> ......");
            tabbar.setTabActive("a1");
        }
        function loadTable(page) {
            tabbar.setTabActive("a"+page);
        }
	</script>
    <style type="text/css">
        .style1
        {
            width: 132px;
        }
        .style2
        {
            width: 139px;
        }
        .style3
        {
        }
        .style4
        {
            width: 212px;
        }
        .style5
        {
            width: 117px;
        }
        .style6
        {
            width: 238px;
        }
        </style>
</head>
<body onload="doOnLoad();">
    <form id="form1" runat="server">
    <div id="winVP" style="position: relative; height: 650px; border: #cecece 1px solid; margin: 0px;" align="center">
    </div>
    <div id='html_1'>
       <table style="width: 100%;">
        <tr>
            <td class="style2" align=right>
                <b> FETCH# :</b></td>
            <td class="style4">
                To Be General</td>
            <td class="style1" align=right>
            <b>Level : </b>
            </td>
            <td>
                &nbsp;
                Initial</td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;
                &nbsp;
                &nbsp;
                * Denote mandatory field</td>
        </tr>
        <tr>
            <td class="style2">
                Requester Name:
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style1">
                Phone Number :</td>
            <td>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width=150></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Entity/Location :</td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="80%">
                    <asp:ListItem>Viet Nam</asp:ListItem>
                    <asp:ListItem>My</asp:ListItem>
                    <asp:ListItem>ThaiLand</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                Date/Time Posted :
            </td>
            <td>
                12/12/2010&nbsp; 03:14PM</td>
        </tr>
        <tr>
            <td class="style2">
                Bussiness Unit :
            </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="80%">
                    <asp:ListItem>DCS Client Services</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                Age(days):</td>
            <td>
                0</td>
        </tr>
        <tr>
            <td class="style2">
                Application :</td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList3" runat="server" Width="80%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                Dept/Section :</td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" Width="70%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Problem Type :
            </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList4" runat="server" Width="80%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                Category :</td>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server" Width="70%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Priority :</td>
            <td class="style3" colspan="3">
                <asp:DropDownList ID="DropDownList7" runat="server" Width="25%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Risk Category/Cost : </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList8" runat="server" Width="80%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                EUR :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width=150></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Description : </td>
            <td class="style3" colspan="3">
                <asp:TextBox ID="TextBox3" runat="server" Rows="3" TextMode="MultiLine" Width=85%></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Risk : </td>
            <td class="style3" colspan="3">
                <asp:TextBox ID="TextBox4" runat="server" Rows="3" TextMode="MultiLine" 
                    Width=85%></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Impact :</td>
            <td class="style3" colspan="3">
                <asp:TextBox ID="TextBox5" runat="server" Rows="3" TextMode="MultiLine" 
                    Width=85%></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Workaround :</td>
            <td class="style3" colspan="3">
                <asp:TextBox ID="TextBox6" runat="server" Rows="3" TextMode="MultiLine" 
                    Width=85%></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td align=right><a href="#" onclick="loadTable(2);">Next Page</a>
                &nbsp;</td>
        </tr>
    </table> 
    </div>        
    
    <div id='html_2'>
    <table style="width: 100%;">
            <tr>
                <td class="style5" align=right>
                <b> FETCH# :</b></td>
                <td class="style6">
                To Be General</td>
                <td align=right>
                    &nbsp;
                <b>Level : </b>
                </td>
                <td>
                    &nbsp;
                    Initial</td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp;
                    &nbsp;
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style5" align=right>
                                        Attachments : </td>
                   <td colspan="3">
                
                &nbsp;<asp:Image ID="Image1" runat="server" Height="28px" ImageUrl="~/images/attachment.png" 
                           Width="27px" />
&nbsp;&nbsp; (Click icon to add/delete attachments)
                </td>                      
            </tr>
            <tr>
                <td class="style5" align=right>
                    Action :</td>
                <td colspan="3">
                <asp:DropDownList ID="DropDownList9" runat="server" Width="60%">
                    <asp:ListItem>-------Select---------</asp:ListItem>
                </asp:DropDownList>
               
                </td>
            </tr>
            <tr>
                <td class="style5" align=right>
                    Comment :
                </td>
                <td colspan="3">
                <asp:TextBox ID="TextBox7" runat="server" Rows="3" TextMode="MultiLine" 
                    Width=85%></asp:TextBox>
                </td>
            </tr>
        </table>
        </br></br>
        
        
        <table style="width: 99%;" cellspacing=0 class="contacts" border=0 align=center>
            <tr>
                <td  class="contactDept">
                    &nbsp;
                    STT</td>
                <td  align=center class="contactDept">
                    Date</td>
                <td  align=center class="contactDept">
                    Posted by</td>
                <td  align=center class="contactDept">
                    &nbsp;
                    Action</td>
                <td align=center class="contactDept">
                    &nbsp;
                    Comment</td>
            </tr>
            <tr>
                <td class="contact" >
                    &nbsp;
                    1</td>
                <td class="contact">
                    15/10/2010</td>
                <td class="contact">
                    tuandq</td>
                <td class="contact">
                    &nbsp;
                    test</td>
                <td class="contact">
                    &nbsp;
                    test</td>
            </tr>
            <tr>
                <td class="contact">
                    &nbsp;
                    2</td>
                <td class="contact">
                    &nbsp;</td>
                <td class="contact">
                    &nbsp;</td>
                <td class="contact">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
        </br>
        </br>
        <div align =right><a href="#" onclick="loadTable(1);">Prev Page</a> | <a href="#" onclick="loadTable(3);">Next Page</a></div>
    </div>
    <div id='html_3'>tab3</div>
    <div id='html_4'>tab4</div>
    <div id='objDivButton'>
    <table style="width: 30%;" align =right>
    <tr >
        <td>
            <img src="images/button_submit_blueOnWhite.gif" />&nbsp;
        </td>
        <td>
            <img src="images/save_icon.gif" />&nbsp;
        </td>
        <td>
            <img src="images/exit.gif" />&nbsp;
        </td>
    </tr>
    </table>

    </div>
    </form>
</body>

</html>
