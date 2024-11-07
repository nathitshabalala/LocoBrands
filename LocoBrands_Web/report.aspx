<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="LocoBrands_Web.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


		<!-- breadcrumb -->
	<div class="container">
		<div class="bread-crumb flex-w p-l-25 p-r-15 p-t-30 p-lr-0-lg">
			<a href="index.aspx" class="stext-109 cl8 hov-cl1 trans-04">
				Home
				<i class="fa fa-angle-right m-l-9 m-r-10" aria-hidden="true"></i>
			</a>

			<span class="stext-109 cl4">
				Report
			</span>
		</div>
	
		<div class="flex-w flex-sb-m p-b-52">
                <div class="flex-w flex-l-m filter-tope-group m-tb-10">

                   
                    <a href="report.aspx?Type=Products" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Product Report
                    </a>

                    <a href="report.aspx?Type=Users" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">User Report
                    </a>

                    <a href="report.aspx?Type=Sales" class="stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5">Sales Report
                    </a>
                </div>
	</div>
	
	</div>

	
	<div id="prodRep" runat="server">

<form class="bg0 p-t-75 p-b-85">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
                        <div class="wrap-table-shopping-cart" id="cartI_id" runat="server">

                            <hr>
                            <h3>Product Report</h3>
                            <table class="table-shopping-cart">
                                <tr class="table_head">
                                    <th class="column-1">Product</th>
                                    <th class="column-2">Name</th>
                                    <th class="column-3">At Hand</th>
                                </tr>
                                
                                <div id="product_id" runat="server">
                                </div>
                                </table>
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
                                    <div id="total_prods" runat="server">
                                        <p><strong>Total Products Sold: </strong>..</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
    </div>
    
    <div id="userRep" runat="server">

        <%-- report --%>
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
                    <div id="UserRep_id" runat="server">
                        <p><strong>Total Products Sold: </strong>..</p>
                        <p><strong>Total Products Sold: </strong>..</p>
                        <p><strong>Total Products Sold: </strong>..</p>
                        <p><strong>Total Products Sold: </strong>..</p>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div id="SalesRep" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
                    <div class="m-l-25 m-r--38 m-lr-0-xl">
                        <div class="wrap-table-shopping-cart" id="Div5" runat="server">

                            <hr>
                            <h3>Sales Report</h3>

                            <div id="salesRep_id" runat="server">
                                <div class="bar-graph">
                                    <div class="bar" style="width: 80%;">
                                        <span class="label">Sales</span>
                                    </div>
                                    <div class="bar" style="width: 15%;">
                                        <span class="label">Dicounts</span>
                                    </div>
                                    <div class="bar" style="width: 27%;">
                                        <span class="label">Shipping</span>
                                    </div>
                                    <div class="bar" style="width: 69%;">
                                        <span class="label">Revenue</span>
                                    </div>
                                    <div class="bar" style="width: 32%;">
                                        <span class="label">Order Value</span>
                                    </div>
                                </div>
                                <div class="x-axis">
                                    <span class="price">R0</span>
                                    <span class="price">R100</span>
                                    <span class="price">R1000</span>
                                    <span class="price">R10000</span>
                                    <span class="price">R100000</span>
                                    <span class="price">R1500000</span>
                                    <span class="price">R1000000+</span>
                                </div>
                            </div>
                            <style>
                            	.bar-graph {
                            		display: flex;
                            		flex-direction: column;
                            		align-items: flex-start;
                            		height: 200px;
                            		width: 100%;
                            		background-color: lightgray;
                            		padding: 10px;
                            	}

                            	.bar {
                            		height: 30px;
                            		background-color: #007bff;
                            		margin-bottom: 10px;
                            		position: relative;
                            	}

                            	.label {
                            		position: absolute;
                            		top: 50%;
                            		left: 5px;
                            		transform: translateY(-50%);
                            		color: white;
                            		font-size: 14px;
                            	}

                            	.x-axis {
                            		display: flex;
                            		justify-content: space-between;
                            		margin-top: 10px;
                            	}

                            	.price {
                            		font-size: 12px;
                            	}
                            </style>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
