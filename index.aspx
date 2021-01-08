<%@ Page Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wsSisapis.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Page Wrapper -->
			<div id="page-wrapper">

				<!-- Header -->
					<header id="header" class="alt">
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

				<!-- Banner -->
					<section id="banner" >
						<div class="inner" >
							<div class="logo" style="text-align:center;">
                                <img src="images/logosisapis.png" alt="Alternate Text" style="width:30%" /><br/>
                                <img src="images/sisapisautomotriz.png" alt="Alternate Text" style="width:48%" />
							</div>           
                            <strong><p>Predicciones para inversiones seguras y redituables</p></strong> 
						</div>
					</section>

				<!-- Wrapper -->
					<section id="wrapper">

						<!-- Que busca SISAPIS -->
							<section class="wrapper spotlight">
								<div class="inner">
									<div class="content mb-4">
										<h2 class="major">¿Qué busca SISAPIS AUTOMOTRIZ?</h2>
										<p>SISAPIS AUTOMOTRIZ® busca analizar datos proporcionados por el INEGI relacionados a la industria de vehículos ligeros en México dentro de una base de datos multidimensional que permita a las empresas automotrices comparar el comportamiento de la venta, producción y exportación de cada modelo de vehículos.</p>
                                        <a href="nosotros.aspx" class="special">Acerca de nosotros</a>
									</div>
								</div>
							</section>
                        <!-- Como se logra -->
							<section class="wrapper spotlight style2">
								<div class="inner">
									<div class="content">
										<h2 class="major" style="color:#000;text-align:center;">¿Cómo se logra?</h2>      
                                        <p  style="color:#000;">A pesar de que se cuenta con mucha información disponible en organismos como el INEGI, ésta por sí sola no le dice nada a las empresas en el sector automotriz acerca de cómo se podrían comportar sus ventas y sus exportaciones, sin embargo gracias al uso de minería se podría analizar todos estos datos para observar un comportamiento y a partir de eso presentar reportes de cómo podrían comportarse en un futuro, lo que le agrega mucha  más utilidad a la información existente.</p>

									</div>
								</div>
							</section>
                        </section>

			</div>
</asp:Content>
