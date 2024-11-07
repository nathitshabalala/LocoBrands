<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="catalog.aspx.cs" Inherits="LocoBrands_Web.product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Product</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="images/icons/favicon.png" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/linearicons-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/slick/slick.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/MagnificPopup/magnific-popup.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/perfect-scrollbar/perfect-scrollbar.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="css/util.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <!--===============================================================================================-->


</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Product -->
    <section class="bg0 p-t-23 p-b-140">
        <div class="container">
            <div class="p-b-10">
                <h3 class="ltext-103 cl5">Catalog
                </h3>
            </div>

            <div class="flex-w flex-sb-m p-b-52">
                <div class="flex-w flex-l-m filter-tope-group m-tb-10">

                    <a class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5" data-filter="*">All Products
                    </a>

                    <a href="catalog.aspx?sortBy=category&category=Clothing" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Clothing
                    </a>

                    <a href="catalog.aspx?sortBy=category&category=Furniture" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Furniture
                    </a>

                    <a href="catalog.aspx?sortBy=category&category=Artwork" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Artwork
                    </a>

                    <a href="catalog.aspx?sortBy=category&category=Accessories" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Accessories
                    </a>
                </div>

                <div class="flex-w flex-c-m m-tb-10">
                    <div class="flex-c-m stext-106 cl6 size-104 bor4 pointer hov-btn3 trans-04 m-r-8 m-tb-4 js-show-filter">
                        <i class="icon-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-filter-list"></i>
                        <i class="icon-close-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none"></i>
                        Filter
                    </div>
                </div>



                <!-- Filter -->
                <div class="dis-none panel-filter w-full p-t-10">
                    <div class="wrap-filter flex-w bg6 w-full p-lr-40 p-t-27 p-lr-15-sm">
                        <div class="filter-col1 p-r-15 p-b-27">
                            <div class="mtext-102 cl2 p-b-15">
                                Sort By
                            </div>

                             <b>Brand</b>
                            <ul>
								<li class="p-b-6" runat="server" id="brands">
                                   
                                </li>
                                 <b>Price</b>
                                <li class="p-b-6">
                                   
                                    <a href="catalog.aspx?sortBy=priceLowToHgih" class="filter-link stext-106 trans-04">Price: Low to High
                                    </a>
                                </li>

                                <li class="p-b-6">
                                    <a href="catalog.aspx?sortBy=priceHighToLow" class="filter-link stext-106 trans-04">Price: High to Low
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Catalog-->
            <div class="row isotope-grid" id="catalog" runat="server">
            </div>


        </div>
    </section>

</asp:Content>
