<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportAndRequest.aspx.cs" Inherits="LabControl.WebForm50" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LabControl</title>
   <meta name="viewport" content="width=device-width, initial-scale=1"/>
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
  
        <!--start-header-->
	<div class="header" id="home">
		<div class="container">
			<div class="head">
			<div class="logo">
				<a href="Welcome.aspx"><img src="img/logoLabnew.png" alt="" /></a>
			</div>
			<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
						<li><a href="index.aspx"  class="hvr-bounce-to-bottom">Iniciar Sesión</a></li>
						
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
	<!--script-for-menu-->
	<!--start-contact-->
	<div class="contact">
		<div class="container">
			<div class="contact-top heading">
				<h3>Reportes y Solicitudes Extraordinarias</h3>
			</div>
			<div class="form-horizontal">
				&nbsp;
                <div class=" form-group">
				<asp:Label ID="Label1" runat="server" Text="Asunto:" style="text-align: left"></asp:Label>
                <br />
                    </div>
                <div class="dropdown-menu-right">
                <br />
                <asp:DropDownList ID="ddlSubject" runat="server" Width="710px" CssClass="form-control">
                    <asp:ListItem>Reportes</asp:ListItem>
                    <asp:ListItem>Solicitudes</asp:ListItem>
                </asp:DropDownList>
                <br />
                    </div>
                <br />
                <div class="form-group">
                Laboratorio:<br />
                <br />
                    <div class="dropdown-menu-right">
                <asp:DropDownList ID="ddlLab" runat="server"  Width="710px" CssClass="form-control" >
                </asp:DropDownList>
                        <br />
                        </div>
                </div>
                <div class="form-group">
                     Maquina de trabajo:<br />
                <br />
                    <div class="dropdown-menu-right">
                        <asp:TextBox ID="TextBox1" runat="server" Width="699px"></asp:TextBox>
                <br />
                        </div>
                </div>
                <br />
                <br />
                <div class="form-group">
                Descripción<br />
                    <div class="dropdown-menu-right">
                     
                <textarea id="txtDescription" cols="20" name="S1" rows="2" class="form-control" runat="server" ></textarea><br />
                        </div>
                    </div>
                <br />
                <div>

                    <asp:Button ID="btnSend" runat="server" Text="Enviar" OnClick="btnSend_Click" />
                   

                    
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
				<h6 ></h6>
				<p></p>
				<ul>
					<li><a href="#"><span class="fb"> </span></a></li>
					<li><a href="#"><span class="twit"> </span></a></li>
					<li><a href="#"><span class="google"> </span></a></li>
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
		<a href="#home" id="toTop" class="scroll" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
	</div>
	<!--end-footer-->
    
    
    </form>
</body>
</html>

