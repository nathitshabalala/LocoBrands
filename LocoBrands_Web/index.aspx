﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LocoBrands_Web.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Slider -->
	<section class="section-slide">
		<div class="wrap-slick1">
			<div class="slick1">
				<div class="item-slick1" style="background-image: url(images/slide-01.jpg);">
					<div class="container h-full">
						<div class="flex-col-l-m h-full p-t-100 p-b-30 respon5">
							<div class="layer-slick1 animated visible-false" data-appear="fadeInDown" data-delay="0">
								<span class="ltext-101 cl2 respon2">
									Women Collection 2018
								</span>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="fadeInUp" data-delay="800">
								<h2 class="ltext-201 cl2 p-t-19 p-b-43 respon1">
									NEW SEASON
								</h2>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="zoomIn" data-delay="1600">
								<a href="catalog.aspx" class="flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04">
									Shop Now
								</a>
							</div>
						</div>
					</div>
				</div>

				<div class="item-slick1" style="background-image: url(images/slide-02.jpg);">
					<div class="container h-full">
						<div class="flex-col-l-m h-full p-t-100 p-b-30 respon5">
							<div class="layer-slick1 animated visible-false" data-appear="rollIn" data-delay="0">
								<span class="ltext-101 cl2 respon2">
									Men New-Season
								</span>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="lightSpeedIn" data-delay="800">
								<h2 class="ltext-201 cl2 p-t-19 p-b-43 respon1">
									Jackets & Coats
								</h2>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="slideInUp" data-delay="1600">
								<a href="catalog.aspx" class="flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04">
									Shop Now
								</a>
							</div>
						</div>
					</div>
				</div>

				<div class="item-slick1" style="background-image: url(images/slide-03.jpg);">
					<div class="container h-full">
						<div class="flex-col-l-m h-full p-t-100 p-b-30 respon5">
							<div class="layer-slick1 animated visible-false" data-appear="rotateInDownLeft" data-delay="0">
								<span class="ltext-101 cl2 respon2">
									Men Collection 2018
								</span>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="rotateInUpRight" data-delay="800">
								<h2 class="ltext-201 cl2 p-t-19 p-b-43 respon1">
									New arrivals
								</h2>
							</div>
								
							<div class="layer-slick1 animated visible-false" data-appear="rotateIn" data-delay="1600">
								<a href="catalog.aspx" class="flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04">
									Shop Now
								</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

	

	<!-- Product -->
	<section class="bg0 p-t-23 p-b-140">
		<div class="container">
			<div class="p-b-10">
				<h3 class="ltext-103 cl5">
					Product Overview
				</h3>
			</div>

			<div class="flex-w flex-sb-m p-b-52">
				<div class="flex-w flex-l-m filter-tope-group m-tb-10">
					<button class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1" data-filter="*">
						All Products
					</button>
				</div>
				</div>
				
			

				<!-- Filter -->
				<div class="dis-none panel-filter w-full p-t-10">
					<div class="wrap-filter flex-w bg6 w-full p-lr-40 p-t-27 p-lr-15-sm">
						<div class="filter-col1 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Sort By
							</div>

							<ul>
								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										Default
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										Popularity
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										Average rating
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04 filter-link-active">
										Newness
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										Price: Low to High
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										Price: High to Low
									</a>
								</li>
							</ul>
						</div>

						<div class="filter-col2 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Price
							</div>

							<ul>
								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04 filter-link-active">
										All
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										R0.00 - R50.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										R50.00 - R100.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										R100.00 - R150.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										R150.00 - R200.00
									</a>
								</li>

								<li class="p-b-6">
									<a href="#" class="filter-link stext-106 trans-04">
										R200.00+
									</a>
								</li>
							</ul>
						</div>

						<div class="filter-col3 p-r-15 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Color
							</div>

							<ul>
								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #222;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Black
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #4272d7;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04 filter-link-active">
										Blue
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #b3b3b3;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Grey
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #00ad5f;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Green
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #fa4251;">
										<i class="zmdi zmdi-circle"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										Red
									</a>
								</li>

								<li class="p-b-6">
									<span class="fs-15 lh-12 m-r-6" style="color: #aaa;">
										<i class="zmdi zmdi-circle-o"></i>
									</span>

									<a href="#" class="filter-link stext-106 trans-04">
										White
									</a>
								</li>
							</ul>
						</div>

						<div class="filter-col4 p-b-27">
							<div class="mtext-102 cl2 p-b-15">
								Tags
							</div>

							<div class="flex-w p-t-4 m-r--5">
								<a href="#" class="flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5">
									Fashion
								</a>

								<a href="#" class="flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5">
									Lifestyle
								</a>

								<a href="#" class="flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5">
									Denim
								</a>

								<a href="#" class="flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5">
									Streetstyle
								</a>

								<a href="#" class="flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5">
									Crafts
								</a>
							</div>
						</div>
					</div>
				</div>
			</div>

			<div class="row isotope-grid" id="catalog" runat="server">

					
			</div>

			
		</div>
	</section>




</asp:Content>
