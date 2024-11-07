using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class invoices : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUser"] != null)
            {
                string userID = Session["LoggedInUser"].ToString();


                dynamic invoices = sr.GetAllInvoices(userID).ToList();

                string display = "";
                foreach (Invoice i in invoices)
                {
                    display = $@"<tr class='table_row'>
                                <td class='column-2'>{i.invoice_id}</td>
                                <td class='column-2'><a href='invoiceDownload.aspx?InvID={i.invoice_id}'>Click to Download</a></td>
							    <td class='column-3'>{i.invoice_date}</td>
                                </tr>";
                    invoices_id.InnerHtml += display;
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}