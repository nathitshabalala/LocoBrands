using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class product_details : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["productId"] != null)
            {
                int productId = Int32.Parse(Request.QueryString["productId"]);
                var product = sr.GetProductById(productId);

                if (product != null)
                {
                    category_link.InnerText = product.category + " >";
                    productname_link.InnerText = product.product_name;
                    string html = $@"
                                    <div class='item-slick3' data-thumb='{product.image}'>
                                        <div class='wrap-pic-w pos-relative'>
                                            <img src='{product.image}' alt='{product.product_name}'>

                                            <a class='flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04' href='{product.image}'>
                                                <i class='fa fa-expand'></i>
                                            </a>
                                        </div>
                                    </div>";

                    image_slider.InnerHtml = html;
                    prod_name.InnerText = product.product_name;
                    prod_price.InnerText = "R"+product.price.ToString();
                    prod_descrip.InnerText = product.description;
                    prod_descrip2.InnerText = product.description;
                    prodId.InnerText = "ID: " + product.product_id.ToString();
                    prod_cat.InnerText = "Category: " + product.category;
                }
            }
            else
            {
                Response.Redirect("product-details.aspx?productId=1");
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse(Request.QueryString["productId"]);

            if (Session["LoggedInUser"] != null)
            {
                int userID = (int)Session["LoggedInUser"];
                int num = Int32.Parse(qty.Value);
                bool success = sr.AddCartItem(sr.GetShoppingCartById(userID).cart_id, productId, num);

                if (success)
                {
                    Response.Redirect("shopping-cart.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }


        }
    }
}