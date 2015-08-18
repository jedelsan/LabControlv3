<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LabControl.index" %>

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
<script src="js/jquery.min.js"></script>
 
    <link href="css/stylenew.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />

<!---- start-smoth-scrolling

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
				<a><img src="img/logoLabNew.png" alt="" /></a>
			</div>
				<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
						
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
		<div class="container">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate> 
			<div class="banner-top">
                
                <h1>Iniciar Sesión</h1>

                    
                    <div class="banner-bottom">
					
						
						
                          <div class="form-group">
                            
                       <asp:Label runat="server" ForeColor="Black" Text="Nombre de Usuario:  "/>
				       <asp:TextBox CssClass="form-control" id="UserName" runat="server" placeholder="Escriba su nombre de Usuario"/><br />
                             <asp:Label ID="lblErrorUsuario" runat="server" ForeColor="Red" Text="Escriba su email" Visible="False" />
						</div>
                            </div>
                       
						
					<div class="form-group">
                       
                          
						
						
                            
                      <asp:Label runat="server" ForeColor="Black" Text="Contraseña:  "/>
				      <asp:TextBox CssClass="form-control" id="Password" TextMode="Password" type="textbox" runat="server" placeholder="Escriba su contraseña"  /><br />
                             <asp:Label runat="server" ForeColor="Red" Text="Escriba su contraseña" ID="lblErrorContraseña" Visible="False" />
						
                        </div>
						
					
                        
					<div class="form-group">
                       
						<asp:Button runat="server" Text="Iniciar Sesión" CssClass="btn btn-success" OnClick="Unnamed1_Click" Width="143px" ID="Button1" />
				   
                              </div>
                        
                </div>
                </ContentTemplate> 
                        </asp:UpdatePanel>


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
		
	</div>
	<!--end-footer-->
            
    </form>
</body>
</html>