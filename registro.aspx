<%@ Page Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="wsSisapis.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-wrapper">

				<!-- Header -->
					<header id="header">
						<h1><a href="index.aspx">SISAPIS AUTOMOTRIZ</a></h1>
						<nav>
							<a href="#menu">Menu</a>
						</nav>
					</header>

				<!-- Menu -->
					<nav id="menu">
						<div class="inner">
							<h2>Menu</h2>
							<ul class="links">
								<li><a href="acceso.aspx">Acceder</a></li>
								<li><a href="nosotros.aspx">Acerca de nosotros</a></li>
							</ul>
							<a href="#" class="close">Close</a>
						</div>
					</nav>

				<!-- Wrapper -->
					<section id="bannercontenido" >
						<div class="inner" >
                            <h2>Registro</h2> 
						</div>
					</section>
        <div class="container ">
            <div class="row my-3" style="justify-content:center;">
                <div class="col-6 "style="margin-top: 5%;" >
                    
                	<div class="input-group" >
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fas fa-user"></i></span>
								</div>
								<input type="text" name="txt_nombre" class="form-control" placeholder="Nombre"/>
							</div><br />
         <div class="input-group" >
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fas fa-users"></i></span>
								</div>
								<input type="text" name="txt_usu" class="form-control" placeholder="Nombre de usuario"/>
							</div><br />
                	<div class="input-group">
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fa fa-key"></i></span>
								</div>
									<input type="Password" name="txt_pass" class="form-control" placeholder="Contraseña"/>
							</div><br />
                    	<div class="input-group">
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fa fa-key"></i></span>
								</div>
									<input type="Password" name="txt_confpass" class="form-control" placeholder="Confirmar Contraseña"/>
							</div><br />
                    <div class="text-center" >
                        <ul class="actions" style="display:inherit;">
                                    <li >
                                       <!--BOTON REGISTRO --><asp:Button ID="Button1" runat="server" Text="Registrarme" /> 
                                    </li>
								</ul>
                    </div>
                    <p class="text-center">¿Ya tienes cuenta? <a href="acceso.aspx">Accede</a></p>

                </div>
        </div>
            </div>
        </div>
</asp:Content>
