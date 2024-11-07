<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="manageproduct.aspx.cs" Inherits="LocoBrands_Web.manageproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Title page -->
	<section class="bg-img1 txt-center p-lr-15 p-tb-92" style="background-image: url('images/bg-01.jpg');">
		<h2 class="ltext-105 cl0 txt-center">
			Manage Product
		</h2>
	</section>	

	<!-- Content page -->
	<section class="bg0 p-t-104 p-b-116">
		<div class="container">
			<div class="flex-w flex-tr">
				<div class="size-210 bor10 p-lr-70 p-t-55 p-b-70 p-lr-15-lg w-full-md">
                    <form>
                        <h4 class="mtext-105 cl2 txt-center p-b-30">Manage Product
                        </h4>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="name" placeholder="Enter Product Name" runat="server">
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="category" placeholder="Enter Product Category" runat="server">
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="brand" placeholder="Enter Product Brand" runat="server">
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="price" placeholder="Enter Product Price" runat="server">
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="quantity" placeholder="Enter Product quantity" runat="server">
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="image" placeholder="Enter Product Image" runat="server">
                        </div>

                        <div class="bor8 m-b-30">
                            <asp:TextBox class="stext-111 cl2 plh3 size-120 p-lr-28 p-tb-25" type="text" id="description" placeholder="Enter Product Description" runat="server"></asp:TextBox>
                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <asp:Button class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" ID="btnAdd" runat="server" Text="Add Product" OnClick="btnAdd_Click" />

                        </div>

                        <div class="bor8 m-b-20 how-pos4-parent">
                            <asp:Button class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" ID="btnUpdate" runat="server" Text="Update Product" OnClick="btnUpdate_Click" />

                        </div>


                    </form>
				</div>

				<div class="size-210 bor10 flex-w flex-col-m p-lr-93 p-tb-30 p-lr-15-lg w-full-md">
					<div class="bor8 m-b-20 how-pos4-parent">
							<input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" id="id" placeholder="Enter Product ID" runat="server">
					</div>

					<asp:Button class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" ID="btnDelete" runat="server" Text="Delete Product" OnClick="btnDelete_Click" />

				</div>

			</div>
		</div>
	</section>	

</asp:Content>
