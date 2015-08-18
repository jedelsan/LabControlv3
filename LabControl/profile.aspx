<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="LabControl.profile" %>

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
<link href="css/styleWelcome.css" rel="stylesheet"  type='text/css'/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css"/>
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


<!--start-smoth-scrolling-->
</head>
<body>
    <form id="form1" runat="server">
	<!--start-header-->
	<div class="header" id="home">
		<div class="container">
			<div class="head">
			<div class="logo">
				<a href="index.html"><img src="img/logoLabnew.png" alt="" /></a>
			</div>
			<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
                        <li><a  class="active ">Perfil</a></li>
						<li><a href="Welcome.aspx"  class="hvr-bounce-to-bottom">Inicio</a></li>					
						
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
            <div class="navbar">
			<div class="contact-top heading">
				<h3>Perfil</h3>
			</div>
			<div class="container">
                <div class="form-group">
       <asp:Label ID="LblNombre" runat="server" Text="Nombre:"></asp:Label>
       <asp:Label ID="LblNombreUsuario" runat="server"></asp:Label>
		
                    </div>
                <div class="form-group">
       <asp:Label ID="Label1" runat="server" Text="Carnet:"></asp:Label>
       <asp:Label ID="LblCarnetUsuario" runat="server"></asp:Label>

                    </div>
                 <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Tipo:"></asp:Label>
                      <asp:Label ID="LblRolUsuario" runat="server"></asp:Label>

                     </div>
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                <div class="container">
                
                    <div class="form-group">
                             <asp:LinkButton ID="btnCambiarContraseña" runat="server" OnClick="LinkButton1_Click">Cambiar Contreseña</asp:LinkButton>
                        </div>
                 
                          <asp:Label ID="lblConVieja" runat="server" Text="Contraseña Antigua:" Visible="False"></asp:Label>
                    <asp:TextBox ID="txtConVieja" CssClass="form-control" TextMode="Password" runat="server" Visible="False" Width="313px" ></asp:TextBox>
                        
                        
                    
                    <asp:Label ID="lblConNueva" runat="server" Text="Contraseña Nueva:" Visible="False"></asp:Label>
                    <asp:TextBox ID="txtConNueva" CssClass="form-control" TextMode="Password" runat="server"  Visible="False" AutoCompleteType="Disabled" Width="313px"></asp:TextBox>
                        
                     <asp:Button ID="btnGuardarCon" runat="server" Text="Guardar" Visible="False" OnClick="Button1_Click"/>
                     <asp:LinkButton ID="btnCancelar" runat="server" Visible="False" OnClick="btnCancelar_Click">Cancelar</asp:LinkButton>
                    
                     <asp:Label ID="lblErrorCon" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="Red" Text="Error: Contraseña incorrecta" Visible="False"></asp:Label>
                     <asp:Label ID="lblErrorCamposVacios" runat="server" Font-Bold="True" ForeColor="Red" Text="*Favor llenar todos los campos" Visible="False"></asp:Label>
                                      


                       
                           </ContentTemplate>
                    </asp:UpdatePanel>
                

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
