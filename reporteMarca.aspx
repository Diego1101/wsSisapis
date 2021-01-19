<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/mpPrincipal.Master" CodeBehind="reporteMarca.aspx.cs" Inherits="wsSisapis.reporteMarca" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

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
							    <li><a href="reportep-auto.aspx">Reporte 1</a></li>
                                <li><a href="reporteMarca.aspx">Reporte 2</a></li>
                                <li><a href="reporteModelo.aspx">Reporte 3</a></li>
								<li><a href="index.aspx">Cerrar Sesión</a></li>
							</ul>
							<a href="#" class="close">Close</a>
						</div>
					</nav>
				<!-- Wrapper -->
					<section id="bannercontenido" >
						<div class="inner" >
                            <h2>Reporte de predición de ventas por marca</h2> 
						</div>
					</section>
        <div class="container-fluid">
            <div class="row">
                <div class="col-12"style="margin-top: 5%;" >	
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" Height="50px" OnInit="CrystalReportViewer1_Init" Width="350px" EnableDrillDown="False" />
        </div>
            </div>
        </div>
        </div>
</asp:Content>
