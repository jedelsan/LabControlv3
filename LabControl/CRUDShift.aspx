<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDShift.aspx.cs" Inherits="LabControl.CRUDShift" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>LabControl</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Paix Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <script src="js/jquery.min.js"></script>
    <!---- start-smoth-scrolling---->
    <script type="text/javascript" src="js/move-top.js"></script>
    <script type="text/javascript" src="js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--start-header-->
            <div class="header" id="home">
                <div class="container">
                    <div class="head">
                        <div class="logo">
                            <a>
                                <img src="img/logoLabnew3.png" alt="" /></a>
                        </div>
                        <div class="navigation">
                            <span class="menu"></span>
                            <ul class="navig">
                                <li><a runat="server" href="index.html" class="hvr-bounce-to-bottom">Laboratorios</a></li>
                                <li><a runat="server" href="~/Admin" id="admin" class="hvr-bounce-to-bottom">Admin</a></li>
                                <li><a runat="server" href="~/User" class="hvr-bounce-to-bottom">Usuario</a></li>
                                <li><a runat="server" href="~/Account/Logout" class="hvr-bounce-to-bottom">Cerrar Sesion</a></li>

                            </ul>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
            <!-- script-for-menu -->
            <!-- script-for-menu -->
            <script>
                $("span.menu").click(function () {
                    $(" ul.navig").slideToggle("slow", function () {
                    });
                });
            </script>
            <!-- script-for-menu -->
            <!--start-banner-->
            <div class="out" style="height: auto; margin-top: 12px">
                <asp:GridView ID="GridView1" AutoGenerateColumns="False" class="table table-striped table-bordered table-hover table-highlight table-checkable" runat="server" OnRowCommand="gvResults_RowCommand" Width="952px" DataKeyNames="id" PageSize="5" AllowPaging="True" OnPageIndexChanging="grdData_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="start time" HeaderText="Hora de inicio" SortExpression="start time" />
                        <asp:BoundField DataField="end time" HeaderText="Hora de finalizacion" SortExpression="end time" />
                        <asp:BoundField DataField="date" HeaderText="Dia" SortExpression="date" />
                        <asp:CheckBoxField DataField="busy" HeaderText="Reservado" SortExpression="busy" />
                        <asp:ButtonField ButtonType="Button" CommandName="Edit" Text="RESERVADO" />
                    </Columns>
                </asp:GridView>
            </div>

            <div style="height: auto; margin-bottom: 0px;">
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Laboratorio: "></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="189px">
                    </asp:DropDownList>
&nbsp;&nbsp;
                    &nbsp;&nbsp;</p>
                <p>
                    &nbsp;&nbsp;&nbsp;
                    </p>
                <p>
                    <asp:Label ID="lblDia" runat="server" Text="Dia: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="188px">
                    </asp:DropDownList>
&nbsp;
                    </p>
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                <p>
                    &nbsp;
                <asp:Button ID="btnSelectLab" runat="server" OnClick="btnSelectLab_Click" Text="Seleccionar" />
                </p>
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
                    </p>
                <p>
                    &nbsp;</p>

                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </p>
            </div>
            <!--end-banner-->








            <!--start-footer-->
            <div class="footer">
                <div class="container">
                    <div class="touch-top heading">
                        <h3>LabControl</h3>
                    </div>
                    <div class="touch-bottom">
                        <p></p>
                        <h6></h6>
                        <p></p>
                        <ul>
                            <li><a href="#"><span class="fb"></span></a></li>
                            <li><a href="#"><span class="twit"></span></a></li>
                            <li><a href="#"><span class="google"></span></a></li>
                        </ul>
                    </div>
                    <div class="footer-top">
                        <p class="footer-class">© 2015 Paix All Rights Reserved | Design by  <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
                    </div>
                </div>
                <script type="text/javascript">
                    $(document).ready(function () {
                        /*
                        var defaults = {
                            containerID: 'toTop', // fading element id
                            containerHoverID: 'toTopHover', // fading element hover id
                            scrollSpeed: 1200,
                            easingType: 'linear' 
                        };
                        */

                        $().UItoTop({ easingType: 'easeOutQuart' });

                    });
                </script>
                <a href="#home" id="toTop" class="scroll" style="display: block;"><span id="toTopHover" style="opacity: 1;"></span></a>
            </div>
            <!--end-footer-->
        </div>
    </form>
</body>
</html>

