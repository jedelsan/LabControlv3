<%@ Page Language="C#" MaintainScrollPositionOnPostBack = "true" AutoEventWireup="true"   CodeBehind="SelectReservation.aspx.cs" Inherits="LabControl.SelectReservation" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LabControl</title>
<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Paix Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="Content/bootstrap.css" rel="stylesheet" type='text/css' />
<link href="css/styleWelcome.css" rel="stylesheet" type='text/css' />
<link href="css/calendario.css" rel='stylesheet' type='text/css'/>

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
				<a href="Welcome.aspx"><img src="img/logoLabnew.png" alt =""  /></a>
			</div>
			<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
	         <li><a class="active">Reservaciones</a></li>
             <li><a runat="server" id="inicio" href="Welcome.aspx" class="hvr-bounce-to-bottom">Inicio</a></li>

						
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
       
       <script>

           $("#myTable ").click(function () {
               $(this).addClass('selected').siblings().removeClass('selected');
               var value = $(this).find('td:first').html();
               alert('toco');
           });
           $('.ok').on('click', function (e) {
               alert($("#myTable .selected td:first").html());
           });
           </script>

               
	<!--script-for-menu-->
	<!--start-contact-->
	<div class="contact">
		<div class="container">
			<div class="contact-top heading">
				<h3>Resevacion de Laboratorios</h3>

                    <div class="nav-justified">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" >
                    <ContentTemplate>
                    <div class="nav-tabs-justified">
                    <div class="table-responsive"> 
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                               
                                <img id="screen" src="./img/SeatScreen2.png" runat="server" width="600" visible="true" />
                                
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                &nbsp;<asp:Table ID="myTable" runat="server" Width="1000px" visible="true" CssClass="nav-justified"  ></asp:Table>  
                            </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
                        
                        
                            <div class="nav-justified">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                           <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="btn btn-primary" visible="true" OnClick="Button2_Click1"/>
                              </ContentTemplate>
                            </asp:UpdatePanel>
                                </div>
                             
                        </div>
                         </ContentTemplate>
                        
                     </asp:UpdatePanel>
                    
                </div>
                    </div>
            </div>
        </div>
                 
                
                   
                    <%--<div class="dropdown">--%>
                     

                    
                   

                
                 
	<!--end-contact-->	
	<!--start-footer-->
	<div class="footer">
		<div class="container">
		<div class="touch-top heading">
				<h3>LabControl
                </h3>
			</div>
			<div class="touch-bottom">
				<p>
                    &nbsp;</p>
				<h6 ></h6>
				<p></p>
				<ul>
					<li><a href="#"><span class="fb"> </span></a></li>
					<li><a href="#"><span class="twit"> </span></a></li>
					<li><a href="#"><span class="google"> </span></a></li>
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
		<a href="#home" id="toTop" class="scroll" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
	</div>
	<!--end-footer-->
       
   
    
        
                     
                    

        </form>

</body>
</html>
    