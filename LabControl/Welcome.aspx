<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LabControl.Welcome" %>

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
<link href="css/bootstrapWelcome.css" rel="stylesheet"  type='text/css'/>
<link href="css/styleWelcome.css" rel="stylesheet"  type='text/css'/>
<link href="css/index_style.css" rel="stylesheet" type='text/css' />
<script src="js/jquery.min.js"></script>
<!---- start-smoth-scrolling---->
<script type="text/javascript" src="js/move-top.js"></script>
<script type="text/javascript" src="js/easing.js"></script>
<script type="text/javascript">
			jQuery(document).ready(function($) {
				$(".scroll").click(function(event){		
					event.preventDefault();
					$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
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
				<a><img src="img/logoLabnew.png" alt="" /></a>
			</div>
			<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
                        <li><a runat="server" href="~/CRUDWorkStation" id="workstations" class="hvr-bounce-to-bottom">Estaciones de trabajo</a></li>
						<li><a runat="server" href="~/CrudLab"  id= "lab" class="hvr-bounce-to-bottom">Laboratorios</a></li>
						<li><a runat="server" href="~/Admin" id="admin" class="hvr-bounce-to-bottom">Usuarios</a></li>
                        <li><a runat="server" href="~/AdminCareer" id="a1" class="hvr-bounce-to-bottom">Carrera</a></li>
						<li><a runat="server" href="profile.aspx" class="hvr-bounce-to-bottom">Perfil</a></li>
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
	<div class="banner">

         

	
			
<div class="header">
		
		
		<div class="contenedor" id="tres">
			<a id="Registro reservaciones" href="UserReservations.aspx"><img class="icon" src="pictures/icon6.png" alt=""/></a>
			<p class="texto">Registro Reservaciones</p>
		</div> 

		<div class="contenedor" runat="server"   id="cuatro">
			<a id="reservation" runat="server" href="reservation.aspx"><img   class="icon" src="pictures/icon6.png" alt=""/></a>
			<p class="texto">Reservación</p>
		</div>

		<div class="contenedor" id="cinco">
			<a id="reportes" runat="server" href="ReportAndRequest.aspx"><img class="icon" src="pictures/icon6.png"/></a>
			<p class="texto">Reportes y Solicitudes</p>
		</div>

		

	</div>

		
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
    </div>
    </form>
</body>
</html>
