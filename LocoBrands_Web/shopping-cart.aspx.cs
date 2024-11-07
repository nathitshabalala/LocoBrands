using iTextSharp.text;
using iTextSharp.text.pdf;
using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LocoBrands_Web
{
	public partial class shopping_cart : System.Web.UI.Page
	{
		Service1Client SR = new Service1Client();

		protected void Page_Load(object sender, EventArgs e)
		{

			decimal subtotal = 0;
			decimal total = 0;

			if (Session["LoggedInUser"] != null)
			{
				string userID = Session["LoggedInUser"].ToString();
				var cart = SR.GetShoppingCartById(int.Parse(userID));

				int cartID = cart.cart_id;




				dynamic cartItems = SR.GetCartItemsByCartId(cartID);

				string cart_display = "";

				foreach (CartItem c in cartItems)
				{
					int prodID = c.product_id;

					var product = SR.GetProductById(prodID);

					cart_display += "<tr class='table_row'>";
					cart_display += "<td class='column-1'>";
					cart_display += "<div class='how-itemcart1'>";
					cart_display += "<img src = " + product.image + " alt='IMG'>";
					cart_display += "</div>";
					cart_display += "</td>";
					cart_display += "<td class='column-2'>" + product.product_name + "</td>";
					cart_display += "<td class'column-3'>R" + product.price + " </td>";
					cart_display += "<td class='column-4'>";
					cart_display += "<div class='wrap-num-product flex-w m-l-auto m-r-0'>";
					cart_display += "<div class='btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m'>";
					cart_display += "<i class='fs-16 zmdi zmdi-minus'></i>";
					cart_display += "</div>";

					cart_display += "<input class='mtext-104 cl3 txt-center num-product' type='number' name='num-product1' value='1'>";
					cart_display += "<div class='btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m'>";
					cart_display += "<i class='fs-16 zmdi zmdi-plus'></i>";
					cart_display += "</div>";
					cart_display += "</div>";
					cart_display += "</td>";
					cart_display += "<td class='column-5'>R " + product.price * c.quantity + "</td>";
					cart_display += "</tr>";
					subtotal += product.price;
					total += product.price * c.quantity;
					product_id.InnerHtml = cart_display;
				}

				string subtotal_display = $@"
							<div class='size-208'>
								<span class='stext-110 cl2'>
									Subtotal:
								</span>
							</div>

							<div class='size-209'>
								<span class='mtext-110 cl2'>
									R{subtotal}
								</span>
							</div>";

				subtotal_id.InnerHtml = subtotal_display;

				string total_display = $@"
			<div class='size-208'>
								<span class='mtext-101 cl2'>
									Total:
								</span>
							</div>

							<div class='size-209 p-t-1'>
								<span class='mtext-110 cl2'>
									R{total}
								</span>
							</div>";

				total_id.InnerHtml = total_display;
            }
            else
            {
				Response.Redirect("login.aspx");
            }


		}


		protected void OnbtnCheckout(object sender, EventArgs e)
		{
			int userId;

			if (Session["LoggedInUser"] !=null)
            {
				userId = Convert.ToInt32(Session["LoggedInUser"]);
				var cart = SR.GetShoppingCartById(userId);
				List<CartItem> cartItems = SR.GetCartItemsByCartId(cart.cart_id).ToList();

				if (cartItems != null)
				{
					decimal total = 0;
					decimal vat = 0;


                    // Create a new document
                    Document doc = new Document();

					// Create a memory stream to store the PDF data
					MemoryStream memoryStream = new MemoryStream();

                    // Create a PDF writer
                    PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

					// Open the document for writing
					doc.Open();

					// Create and add the invoice content (replace with your actual invoice content)
					Paragraph header = new Paragraph("Invoice");
					Paragraph line1 = new Paragraph("-----------------------------------------------------------------------------------------------");
					Paragraph invID = new Paragraph($"Invoice ID: {"INV-"+ DateTime.Now +"-"+ SR.GetUserById(userId).usertype + "-" + userId}");
					Paragraph invDate = new Paragraph($"Date: {DateTime.Now}");
					Paragraph customerInfo = new Paragraph($"Customer: {SR.GetUserById(userId).name} {SR.GetUserById(userId).surname}");
					Paragraph line2 = new Paragraph("-----------------------------------------------------------------------------------------------");

					doc.Add(header);
					doc.Add(line1);
					doc.Add(invID);
					doc.Add(invDate);
					doc.Add(customerInfo);
					doc.Add(line2);

					Paragraph ProdHeader = new Paragraph($"{"Name"}" + $"                         {"Price"}" + $"         {"QNT"}" + $"             {"Line Total"}");

					doc.Add(ProdHeader);
					int i = 0;
					foreach (CartItem c in cartItems)
                    {
						i += 1;
						var product = SR.GetProductById(c.product_id);

						Paragraph ProdDetails = new Paragraph($" { +i+ ". "+ product.product_name}"+ $"                  R { product.price}" + $"         {c.quantity}" + $"            R {product.price * c.quantity}");
						
						Paragraph ProdLine = new Paragraph("__________________________________________________________");

						total += product.price * c.quantity;
						vat += total * (15m / 115m); // 15% VAT;

						
						doc.Add(ProdDetails);
						doc.Add(ProdLine);
						
					}
					Paragraph line3 = new Paragraph("-----------------------------------------------------------------------------------------------");

					Paragraph VAT = new Paragraph($"VAT: R{vat.ToString("0.00")}");
					Paragraph totalAmount = new Paragraph($"Total Amount: R {total}");


					SR.CreateInvoice(userId, DateTime.Now, total, vat);

					doc.Add(VAT);
					doc.Add(totalAmount);
					//foreach (CartItem item in cartItems)
					//{
					//	SR.DeleteShoppingCart(item.cartitem_id);
					//}
					// Close the document
					doc.Close();

					// Get the PDF data from the memory stream
					byte[] pdfData = memoryStream.ToArray();

					// Save the PDF data or send it to the user as a downloadable file
					// In this example, we'll send it as a download
					Response.ContentType = "application/pdf";
					Response.AddHeader("content-disposition", "attachment;filename=invoice.pdf");
					Response.Cache.SetCacheability(HttpCacheability.NoCache);
					Response.BinaryWrite(pdfData);
					Response.Flush();
					Response.End();
				}

			}
			
			
		}
	}
}