<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LocoBrands_Web.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
		<!-- Title page -->
	<section class="bg-img1 txt-center p-lr-15 p-tb-92" style="background-image: url('images/bg-01.jpg');">
		<h2 class="ltext-105 cl0 txt-center">
			LogIn
		</h2>
	</section>	

	<!-- Content page -->
	<section class="bg0 p-t-104 p-b-116">
		<div class="container">
			<div class="flex-w flex-tr">
				<div class="size-210 bor10 p-lr-70 p-t-55 p-b-70 p-lr-15-lg w-full-md">
					<form>
						<h4 class="mtext-105 cl2 txt-center p-b-30">
							Log in
						</h4>

						<div class="bor8 m-b-20 how-pos4-parent">
							<input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="text" name="email" placeholder="Enter your Email Address" id="email_field" runat ="server">
						</div>

						<div class="bor8 m-b-20 how-pos4-parent">
							<input class="stext-111 cl2 plh3 size-116 p-l-62 p-r-30" type="password" name="Password" placeholder="Enter your Password" id ="password_field" runat ="server">
						</div>


						<asp:Button class="flex-c-m stext-101 cl0 size-121 bg3 bor1 hov-btn3 p-lr-15 trans-04 pointer" Text="Login" runat="server" id="login_btn" OnClick="login_btn_Click">
						</asp:Button>
					</form>
				</div>

				<div class="size-210 bor10 flex-w flex-col-m p-lr-93 p-tb-30 p-lr-15-lg w-full-md">
					<figure><img src="images/signin-image.jpg" alt="sing up image" style="height: 350px;"></figure>

				</div>

			</div>
		</div>
	</section>	

</asp:Content>
