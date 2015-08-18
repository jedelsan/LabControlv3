<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="LabControl.WebForm2" %>

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
    <link href="Content/bootstrap.css" rel="stylesheet"  type='text/css'  />
    <link href="css/styleWelcome.css" rel="stylesheet" type='text/css' />

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
                        <li><a class="active">Usuarios</a></li>
						<li><a runat="server" href="Welcome.aspx"  class="hvr-bounce-to-bottom">Inicio</a></li>
						
                           					
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
                <div class="bnr-right">
             
            	

         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate> 
	<div class="table-responsive">
              
         <asp:GridView ID="GridView1" DataKeyNames="id" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover table-highlight table-checkable" runat="server" OnRowDeleting="GridView1_RowDeleting"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="gvResults_RowCommand" PageSize="5" AllowPaging="True" OnPageIndexChanging="grdData_PageIndexChanging ">
              <Columns>
      <asp:BoundField DataField="id"  HeaderText="ID" SortExpression="id" />
      <asp:BoundField DataField="name" HeaderText="Nombre"  />
      <asp:BoundField DataField="mail" HeaderText="Correo" />
      <asp:BoundField DataField="license" HeaderText="Carnet" />
      <asp:BoundField DataField="password" HeaderText="Clave" />
      <asp:BoundField DataField="name1" HeaderText="Rol"  />
      <asp:ButtonField ButtonType="button" CommandName="Edit" Text="Edit" />
      <asp:CommandField ButtonType="Button" ShowDeleteButton="true" />
   </Columns>
         </asp:GridView>
    
        </div>
                    </ContentTemplate> 
                      </asp:UpdatePanel>
                    </div>
   
         
    <div class="n-left">
        <br/>
        <br/>
        <br/>
          <div class="btn-group">
					
			                 
       
        <h4>Crear Usuario</h4>
           <br/>
                                 
               
   
        <asp:Label ID="lblNombre" CssClass="bnr-left" runat="server" Text="Nombre:" Visible="true"></asp:Label>
        <asp:TextBox ID="txtName" CssClass="form-control" runat="server" Visible="true" ></asp:TextBox>
        <asp:Label ID="lblErrorNombre"  runat="server" ForeColor="Red" Text="*Nombre no puede estar vacido" Visible="False"></asp:Label>
   
        
               <br/>
             
       
        <asp:Label ID="lblEmail" CssClass="bnr-left"  runat="server" Text="Correo:" Visible="true"></asp:Label>
        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" Visible="true" ></asp:TextBox>
        <asp:Label ID="lblErrorCorreo"   runat="server" ForeColor="Red" Text="*Correo no puede estar vacido" Visible="False"></asp:Label>

       <br/>
        <asp:Label runat="server" CssClass="bnr-left"  Text="Carnet:" ID="lblStudentId" Visible="true"></asp:Label>
        <asp:TextBox ID="txtStudentId" CssClass="form-control" runat="server" Visible="true"></asp:TextBox>
        <asp:Label ID="lblErrorCarnet" CssClass="bnr-left"  runat="server" ForeColor="Red" Visible="False"></asp:Label>
       
            <br/>
      <asp:Label ID="lblRole" CssClass="bnr-left"  runat="server"  Text="Rol:" Visible="true"></asp:Label>
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate> 
      <asp:DropDownList id="RolList" CssClass="form-control"  AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" Visible="true" >

                  <asp:ListItem Selected="True" Value="1"> Administrador </asp:ListItem>
                  <asp:ListItem Value="2"> Logistica </asp:ListItem>
                  <asp:ListItem Value="3"> Estudiante </asp:ListItem>
                  <asp:ListItem Value="4"> Profesor </asp:ListItem>
            

      </asp:DropDownList>
      </ContentTemplate> 
      </asp:UpdatePanel>
                 
           

                                  
                             
              
   
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate> 
 
       
 <br/>
       
    <asp:Button ID="btnGuardarNewUser" CssClass="btn btn-success"  runat="server" Text="Guardar" OnClick="Button1_Click1" Visible="true" />
           <asp:LinkButton ID="btnCancelar" CssClass="btn btn-danger"  runat="server" OnClick="btnCancelar_Click" Visible="true">Cancelar</asp:LinkButton>

        <br/>
   </ContentTemplate> 

        </asp:UpdatePanel>
            
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
