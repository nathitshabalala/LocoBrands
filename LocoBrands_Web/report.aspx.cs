using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class report : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["Type"] != null)
            {
                string type = Request.QueryString["Type"].ToString();

                if (type.Equals("Products"))
                {
                    prodRep.Visible = true;
                    userRep.Visible = false;
                    SalesRep.Visible = false;
                    var products = sr.GetAllProducts();

                    string display = "";
                    int total = 0;
                    foreach(Product p in products)
                    {
                        display = $@"<tr class='table_row'>
                                    <td class='column-1'>
										<div class='how-itemcart1'>
											<img src = {p.image} alt='IMG'>
										</div>
									</td>
									<td class='column-2'>{p.product_name}</td>
									<td class='column-3'>{p.stock_quantity}</td>
                                    </tr>";
                        product_id.InnerHtml += display;
                        total += 1;
                    }

                    string prosSold = "<hr> <p><strong>Total Products Sold: </strong> "+total+"</p>";
                    total_prods.InnerHtml = prosSold;
                }
                if (type.Equals("Users"))
                {
                    prodRep.Visible = false;
                    userRep.Visible = true;
                    SalesRep.Visible = false;

                    List<User> users = sr.GetAllUsers().ToList();
                    int totalUsers = users.Count();
                    string display = $@"
                        <p><strong>Total Customers </strong>{totalUsers}</p>
                        <p><strong>Customer Conversion Rate: </strong>{82}%</p>
                        <p><strong>Customer Retention Rate: </strong>{27}%</p>";
                    
                    UserRep_id.InnerHtml = display;

                }
                if (type.Equals("Sales"))
                {
                    prodRep.Visible = false;
                    userRep.Visible = false;
                    SalesRep.Visible = true;


                    string display = $@"<div class='bar-graph'>
                                      < div class='bar' style='width: 80%;'>
                                        <span class='label'>Sales</span>
                                    </div>
                                    <div class='bar' style='width: 15%;'>
                                        <span class='label'>Dicounts</span>
                                    </div>
                                    <div class='bar' style='width: 27%;'>
                                        <span class='label'>Shipping</span>
                                    </div>
                                    <div class='bar' style='width: 69%;'>
                                        <span class='label'>Revenue</span>
                                    </div>
                                    <div class='bar' style='width: 32%;'>
                                        <span class='label'>Order Value</span>
                                    </div>
                                </div>";

                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }


        }
    }
}