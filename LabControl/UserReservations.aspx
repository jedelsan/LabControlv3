<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserReservations.aspx.cs" Inherits="LabControl.UserReservations" %>

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
    <link href="Content/bootstrap.css" rel="stylesheet" type='text/css'  />  
     <link href="css/styleWelcome.css" rel="stylesheet" type='text/css'  />
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
				<a><img src="img/logoLabNew.png" alt="" /></a>
			</div>
			<div class="navigation">
				 <span class="menu"></span> 
					<ul class="navig">
						<li><a class="active">Reservaciones de Usuarios</a></li>
						<li><a runat="server" href="Welcome.aspx" id="admin" class="hvr-bounce-to-bottom">Inicio</a></li>
                            
					
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
        <div class="contact">
            <div class="container">
              <div class="contact-bottom">
                  		

         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate> 
	<div class="table-responsive" style="height: auto; margin-top: 12px">
        
         <asp:GridView ID="GridView1" DataKeyNames="id" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover table-highlight table-checkable" runat="server"   PageSize="5" AllowPaging="True" OnPageIndexChanging="grdData_PageIndexChanging ">
              <Columns>


      <asp:BoundField DataField="id" HeaderText="ID reservación"  />

     <asp:BoundField DataField="name" HeaderText="Laboratorio" />

     <asp:BoundField DataField="Day" HeaderText="Día" />

      <asp:BoundField DataField="Shift" HeaderText="Turnos" />

        <asp:BoundField DataField="description" HeaderText="Descripción"  />
                 

                         
   </Columns>
         </asp:GridView>
       
        </div>
                    </ContentTemplate> 
                      </asp:UpdatePanel>
                  <asp:Label ID="Label1" runat="server" Text="Este Usuario no posee reservaciones realizadas" Visible="false"></asp:Label>
         
    <div class="form-horizontal">
          <div class="bnr-right">
					
			
						
                     
                    </div>
                </div>                 
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
    
    </form>
</body>
</html>

