using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class product : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = null;
            if (Request.QueryString["sortBy"] != null)
            {
                string param = Request.QueryString["sortBy"];
                switch (param)
                {
                    case "priceHighToLow":
                        products = sr.GetProductsByPriceHighToLow().ToList();
                        break;
                    case "priceLowToHgih":
                        products = sr.GetProductsByPriceLowToHigh().ToList();
                        break;
                    case "category":
                        string category = Request.QueryString["category"];
                        products = sr.GetProductByCategory(category).ToList();
                        break;
                    case "brand":
                        string brand = Request.QueryString["brand"];
                        products = sr.GetProductByBrand(brand).ToList();
                        break;
                    default:
                        products = sr.GetAllProducts().ToList();
                        break;
                }
            }
            else
            {
                products = sr.GetAllProducts().ToList();
            }

            string prodHtml = "";

            foreach (var product in products)
            {
                prodHtml += GenerateProductBlock(product);
            }

            catalog.InnerHtml = prodHtml;

            // Call GetAllProducts to get a list of all products
            List<Product> prods = sr.GetAllProducts().ToList();

            // Use LINQ to extract unique brand names
            var brandNames = prods.Select(p => p.brand).Distinct().ToList();

            // Initialize an empty string to store the generated HTML
            string dynamicLinks = "";

            // Loop through the brand names to generate the links
            foreach (string brandName in brandNames)
            {
                // Create the link for each brand
                string link = $"<a href='catalog.aspx?sortBy=brand&brand={brandName}' class='filter-link stext-106 trans-04'>{brandName}</a><br>";

                // Append the link to the dynamicLinks string
                dynamicLinks += link;
            }

            // Set the InnerHtml property of the <li> element to display the links
            brands.InnerHtml = dynamicLinks;

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