<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditWorkStation.aspx.cs" Inherits="LabControl.EditWorkStation" %>

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
    <link href="Content/bootstrap.css" rel="stylesheet" type='text/css'/>
    <link href="css/styleWelcome.css" rel="stylesheet" type='text/css'/>
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
                                <img src="img/logoLabnew.png" alt="" /></a>
                        </div>
                        <div class="navigation">
                            <span class="menu"></span>
                            <ul class="navig">
                                
                                <li><a class="active">Editar</a></li>
                                <li><a runat="server" href="~/CRUDWorkStation" class="hvr-bounce-to-bottom">Atrás</a></li>

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
            <!--start-contact-->
            <div class="contact">
                <div class="container">
                    <div class="contact-top heading">
                        <h3>Actualizar Estacion de Trabajo</h3>
                          <p>&nbsp;</p>
                          <p>&nbsp;</p>
                          <p>&nbsp;</p>
                          <p>&nbsp;</p>
                    </div>

                    <div class="n-left">
                        <div class="btn-group">

                       <p> ID: </p><asp:Label ID="lblIDEDIT" runat="server"></asp:Label>
                        <br />
                     <asp:TextBox ID="txtDescripcionEDIT" CssClass="form-control" runat="server"></asp:TextBox>
                                                <br />
                        
                     <asp:Label ID="lblErrorDescriptionEDIT" runat="server" ForeColor="Red" Text="*La descripcion no puede estar vacia" Visible="False"></asp:Label>
                        <br />
                       <p>Nombre del Lab:</p>
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" >
                            </asp:DropDownList>
                       
                       <p> Reservado:</p>
                        <asp:CheckBox ID="chbxRESERVADOEDIT" runat="server" />
                        <br />
                        <br />
                        <br />

                        <div>

                            <asp:Button type="button" ID="btnUpdate" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btnUpdate_Click1" />
                             
                                     
                            <asp:Button ID="btnCancelarEDIT" runat="server" CssClass="btn btn-danger" OnClick="btnCancelar_Click" Text="Cancelar" />



                        </div>
                    </div>
                        </div>
                </div>
                     </div>
            </div>
        
        <!--end-contact-->

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
                    <p class="footer-class"><a href="http://w3layouts.com/" target="_blank"></a> </p>
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


    </form>
</body>
</html>
