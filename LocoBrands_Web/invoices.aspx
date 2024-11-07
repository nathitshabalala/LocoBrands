<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="invoices.aspx.cs" Inherits="LocoBrands_Web.invoices" %>
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
				Invoices
			</span>
		</div>
	
		
	
	</div>

	
	<div id="Uinvoices" runat="server">

<form class="bg0 p-t-75 p-b-85">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 col-xl-7 m-lr-auto m-b-50">
					<div class="m-l-25 m-r--38 m-lr-0-xl">
                        <div class="wrap-table-shopping-cart" id="cartI_id" runat="server">

                            <hr>
                            <h3>Invoice History</h3>
                            <table class="table-shopping-cart">
                                <tr class="table_head">
                                    <th class="column-1">Invoice ID</th>
                                    <th class="column-1">Download</th>
                                    <th class="column-2">Date</th>
                                </tr>
                                
                                <div id="invoices_id" runat="server">
                                
                                </div>
                                </table>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
    </div>


</asp:Content>
