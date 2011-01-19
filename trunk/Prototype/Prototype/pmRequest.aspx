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
            //tabbar.addTab("a7", "Xem Chi Ti&#7871;t Ph&#226;n L&#7899;p", "150px");

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
	</script>
</head>
<body onload="doOnLoad();">
    <form id="form1" runat="server">
    <div id="winVP" style="position: relative; height: 600px; border: #cecece 1px solid; margin: 0px;" align="center">
    </div>
    <div id='html_1'>abc</div>        
    <div id='html_2'>tab2</div>
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
