<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppSms._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Quản Lý Giáo Viên</title>
    <link href="Control/dhtmlx/dhtmlxLayout/codebase/dhtmlxlayout.css" rel="stylesheet"
        type="text/css" />
    <link href="Control/dhtmlx/dhtmlxLayout/codebase/skins/dhtmlxlayout_dhx_skyblue.css"
        rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="Control/dhtmlx/dhtmlxWindows/codebase/dhtmlxwindows.css">
    <link rel="stylesheet" type="text/css" href="Control/dhtmlx/dhtmlxWindows/codebase/skins/dhtmlxwindows_dhx_skyblue.css">
    <link rel="STYLESHEET" type="text/css" href="Control/dhtmlx/dhtmlxTabbar/codebase/dhtmlxtabbar.css">
    <link href="CSS/tableComment.css" rel="stylesheet" type="text/css" />
    <link href="CSS/Gridview.css" rel="stylesheet" type="text/css" />
    <link href="CSS/common.css" rel="stylesheet" type="text/css" />
    <script src="Control/dhtmlx/dhtmlxLayout/codebase/dhtmlxcommon.js"></script>
    <script src="Control/dhtmlx/dhtmlxLayout/codebase/dhtmlxlayout.js"></script>
    <script src="Control/dhtmlx/dhtmlxLayout/codebase/dhtmlxcontainer.js"></script>
    <script src="Control/dhtmlx/dhtmlxWindows/codebase/dhtmlxwindows.js"></script>
    <script src="Control/dhtmlx/dhtmlxTabbar/codebase/dhtmlxtabbar.js"></script>
    <script>
        var tabbar;      
        function doOnLoad() {

            var dhxLayout = new dhtmlXLayoutObject("winVP", "2E", "dhx_black");
            dhxLayout.cells("a").hideHeader();
            dhxLayout.cells("a").setHeight(80);
            dhxLayout.cells("a").attachObject("objDivButton");
            //////start Tabbar
            dhxLayout.cells("b").hideHeader();
            tabbar = dhxLayout.cells("b").attachTabbar();
            tabbar.setSkin('dhx_blue');
            tabbar.setImagePath("Control/dhtmlx/dhtmlxTabbar/codebase/imgs/");
            tabbar.enableAutoReSize(true);
            tabbar.enableAutoSize(false, false);
            tabbar.enableScroll(true);
            tabbar.addTab("a1", "Import Danh Sách", "150px");
            tabbar.addTab("a2", "Thông Tin Giảng Viên", "120px");
            tabbar.addTab("a3", " Sms", "100px");
            tabbar.setContent("a1", "import");
            //set content Tab2
            var dhxLayout2 = tabbar.cells("a2").attachLayout("1C");
	        dhxLayout2.cells("a").attachURL("Search.aspx");
	        dhxLayout2.cells("a").hideHeader();
            //set contend Tab3
            var dhxLayout3 = tabbar.cells("a3").attachLayout("1C");
	        dhxLayout3.cells("a").attachURL("SmsSend.aspx");
	        dhxLayout3.cells("a").hideHeader();
            //set active tab current
            tabbar.setTabActive("a1");
        }        

        ///Function nextTab and PrevTab
        function loadTable(page) {
            tabbar.setTabActive("a" + page);
        }
        ///Function Close Windows
          function Exit() {
            window.close();
        }
	</script>

      

</head>
<body onload="doOnLoad();">
    <form id="form1" runat="server">
    <div id="winVP" style="position: relative; height: 650px; border: #cecece 1px solid; margin: 0px;" align="center">
    </div>
    <div id='import' align=center>
         <table align="center" width=80%>
            <tr>
                <td align="right" class="style2">
                    Choose File :</td>
                <td align="left" colspan="2">
                    <input id="filMyFile" type="file" runat="server" 
                        style="width: 67%"> 
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style2">
                    <asp:LinkButton ID="insertdata" runat="server" onclick="insertdata_Click">Insert Data</asp:LinkButton>
                </td>
                <td align="center">
                    <asp:LinkButton ID="viewdata" runat="server" onclick="viewdata_Click">View Data</asp:LinkButton>
                </td>
                <td align="center"> 
                    <asp:LinkButton ID="deletedata" runat="server" onclick="deletedata_Click">Delete Data</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td align="center" class="style2">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td align="center"> 
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:GridView ID="GridView1" runat="server"
                    AutoGenerateColumns="False"  
                    GridLines="None"  
                    AllowPaging="false" Width="100%"
                    CssClass="mGrid"  
                    PagerStyle-CssClass="pgr"  
                    AlternatingRowStyle-CssClass="alt">
                    <Columns>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />            
                    <asp:BoundField DataField="Account" HeaderText="Account" />  
                     <asp:BoundField DataField="Email" HeaderText="Email" />
                      <asp:BoundField DataField="FullName" HeaderText="FullName" />
 
                    </Columns>
                    
                    </asp:GridView>
                
                </td>
                
            </tr>
             <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="lblmsg" runat="server" Width="500px"></asp:Label>
                 </td>
                
            </tr>
        </table>
    </div> 
                   
   

    <div id="objDivButton">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo copy.jpg" />
    </div>
    </form>
</body>

</html>
