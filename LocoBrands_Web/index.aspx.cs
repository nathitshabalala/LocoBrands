using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class index : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = sr.GetAllProducts().ToList();
            string prodHtml = "";

            foreach (var product in products)
            {
                prodHtml += GenerateProductBlock(product);
            }

            catalog.InnerHtml = prodHtml;
        }
        public string GenerateProductBlock(Product prod)
        {
            // Build the HTML content as a single string
            string html = $@"
            <div class='col-sm-6 col-md-4 col-lg-3 p-b-35 isotope-item'>
                <div class='block2'>
                <a href='product-details.aspx?productId={prod.product_id}' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>
                     <div class='block2-pic hov-img0'>
                         <img src='{prod.image}' alt='IMG-PRODUCT'>
                         </div>
                </a>
                    
                    <div class='block2-txt flex-w flex-t p-t-14'>
                        <div class='block2-txt-child1 flex-col-l'>
                            <a href='product-details.aspx?productId={prod.product_id}' class='stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6'>{prod.product_name}</a>
                            <span class='stext-105 cl3'>R{prod.price}</span>
                        </div>
                      
                    </div>
                </div>
            </div>";

            return html;
        }
    }
}