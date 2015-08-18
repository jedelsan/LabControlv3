<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="reservation.aspx.cs" Inherits="LabControl.reservation" %>

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
    <link href="css/bootstrap-multiselect.css" rel="stylesheet" type='text/css'/>

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
             <li><a runat="server" href="Welcome.aspx" class="hvr-bounce-to-bottom">Inicio</a></li>

						
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
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
			</div>
    
                    <div class="n-left">
                         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                       <div class="btn-group">
                        

                
                   <div class="form-group">
                       <p>Laboratorio: </p>
                       <div class="dropdown-menu-right">
                           <asp:DropDownList ID="ddlLab" CssClass="form-control" runat="server"  DataValueField="id" DataTextField="name" ></asp:DropDownList>
                           <asp:Label ID="LabelError" runat="server" BackColor="White" ForeColor="Red" Text="*Debe seleccionar un laboratorio" Visible="False"></asp:Label>
                           <br/>
                           </div>
                       </div>
                           
                           
                         
                    <script type="text/javascript" src="js/jquery.js"></script>
	                <script type="text/javascript" src="js/calendario.js"></script>
                    <script type="text/javascript">
                        $(function () {
                            $("#txbfecha").datepicker({minDate:0, maxDate:6, dateFormat: 'dd-mm-yy'}).val();
                        $Selection("")
                        });
                        </script>
                    <div class="form-group">
                        
                          <p> Fecha:</p>
                        <input type="text" name="fecha1" runat="server" id="txbfecha" class="form-control"/>
                       <asp:Label ID="lblErrorDate" runat="server" BackColor="White" ForeColor="Red" Text="*Debe seleccionar una fecha" Visible="False"></asp:Label>

                        <div class="dropdown-menu-right">
                            <div class="bnr-right">
                                <br />
                                <br/>
                            <br/>
                                </div>	
                        </div>
                        </div>
                     
                           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               <ContentTemplate>

                        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Seleccionar Turnos" CssClass="btn btn-primary" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                          
                        <br />
                        
                        <br />
                        <br />
                        <asp:Label ID="lblTurno" runat="server" Text="Turno:" Visible="False"></asp:Label>
                       
                        &nbsp;<div class="dropdown-menu-right">
                            
                                <asp:DropDownList ID="ddlTurnos" CssClass="form-control" runat="server"  DataValueField="id" DataTextField="name" Visible="False" >
                                </asp:DropDownList>
                                <br/>
                                <br />
                            
                        </div>
                        
                      <div class="form-group">

            <asp:Label ID="lbl" runat="server" Text="Descripción:" Visible="False"></asp:Label>
                         
        <div class="dropdown-menu-right">
            <asp:TextBox  rows="3" runat="server" TextMode="MultiLine" class="form-control" placeholder="Descripción del Laboratorio" CssClass="form-control" id="txtaDescripcion" Visible="False" ></asp:TextBox>
            <asp:Label ID="lblErrorDescription" runat="server" BackColor="White" ForeColor="Red" Text="*Debe llenar la descripción" Visible="False"></asp:Label>

        <br />
        </div>
    </div>
                        <div class="form-group">
       

          
           
                   <asp:Button  ID="btnsumit" runat="server" Text="Seleccionar"  CssClass="btn btn-primary" OnClick="btnsumit_Click"/>&nbsp;<input type="reset" id="btnreset" class="btn btn-default" value="Limpiar"/>
                    
                            
                              
                                </div> 
                                    </ContentTemplate>
                                   
                           </asp:UpdatePanel>      
                          
       </div>
                 
  
                       </div></div>
                        </div>      
			
		
	
	<!--end-contact-->	
	<!--start-footer-->
	<div class="footer">
		<div class="container">
		<div class="touch-top heading">
				<h3>LabControl</h3>
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
