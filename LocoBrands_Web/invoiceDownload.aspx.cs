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

namespace LocoBrands_Web
{
	public partial class invoiceDownload : System.Web.UI.Page
	{
		Service1Client SR = new Service1Client();

		protected void Page_Load(object sender, EventArgs e)
		{

			if (Request.QueryString["InvID"] != null && Session["LoggedInUser"] != null)
			{
				string invoiceID = Request.QueryString["InvID"].ToString();
				string userId = Session["LoggedInUser"].ToString();
				var invoice = SR.GetInvoiceById(int.Parse(invoiceID));


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
				Paragraph invDate = new Paragraph($"Date: {DateTime.Now}");
				Paragraph customerInfo = new Paragraph($"Customer: {SR.GetUserById(int.Parse(userId)).name} {SR.GetUserById(int.Parse(userId)).surname}");
				Paragraph line2 = new Paragraph("-----------------------------------------------------------------------------------------------");

				doc.Add(header);
				doc.Add(line1);
				doc.Add(invDate);
				doc.Add(customerInfo);
				doc.Add(line2);

				Paragraph ProdHeader = new Paragraph($"{"ID"}" + $"                         {"Date"}" + $"         {"Total"}" + $"             {"Tax"}");

				doc.Add(ProdHeader);

				Paragraph line3 = new Paragraph("-----------------------------------------------------------------------------------------------");

				Paragraph VAT = new Paragraph($"VAT: R{invoice.tax_amount.ToString("0.00")}");
				Paragraph totalAmount = new Paragraph($"Total Amount: R {invoice.total_amount}");

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
            else
            {
				Response.Redirect("index.aspx");
            }
		}
	}
}
