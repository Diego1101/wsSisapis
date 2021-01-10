<%@ Page Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="acceso.aspx.cs" Inherits="wsSisapis.Formulario_web11" %>
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
                            <h2>Acceso</h2> 
						</div>
					</section>
        <div class="container ">
            <div class="row my-3" style="justify-content:center;">
                <div class="col-6 "style="margin-top: 5%;" >
                    
                	<div class="input-group" >
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fas fa-user-tie"></i>
                                    
                                    </span>
								</div>
								<asp:TextBox runat="server" type="text" name="txt_usu" class="form-control" placeholder="Usuario" ID="txtUsuario"></asp:TextBox>
							</div><br />
         
                	<div class="input-group">
								<div class="input-group-prepend">
									<span class="input-group-text"><i class="fa fa-key"></i></span>
								</div>
								<asp:TextBox runat="server" type="Password" name="txt_pass" class="form-control" placeholder="Contraseña" ID="txtPass"></asp:TextBox>
							</div><br />
                <ul class="actions">
                                    <li>
                                       <!--BOTON ACCESO --><asp:Button ID="btnAcceder" runat="server" Text="Acceder" OnClick="Button1_Click" /> 
                                    </li>
								</ul>
                    <p class="text-center">¿No tienes cuenta? Registrate <a href="registro.aspx">aquí</a></p>

                </div>
        </div>
            </div>
        </div>
</asp:Content>
