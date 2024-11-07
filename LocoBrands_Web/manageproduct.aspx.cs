using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class manageproduct : System.Web.UI.Page
    {
        Service1Client SR = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bool added = SR.CreateProduct(name.Value, description.Text, category.Value, brand.Value, decimal.Parse(price.Value), int.Parse(quantity.Value), image.Value);

            if (added == true)
            {
                //product added
                Response.Redirect("catalog.aspx");
            }
            else
            {
                //product not added
                Response.Redirect("manageproduct.aspx");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = SR.GetProductById(int.Parse(id.Value));

            if (product != null)
            {
                bool updated = SR.UpdateProduct(int.Parse(id.Value), name.Value, description.Text, category.Value, brand.Value, decimal.Parse(price.Value), int.Parse(quantity.Value), image.Value);

                if (updated == true)
                {
                    //product updated
                    Response.Redirect("catalog.aspx");
                }
                else
                {
                    //product not updated
                    Response.Redirect("manageproduct.aspx");
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = SR.DeleteProduct(int.Parse(id.Value));

            if (deleted == true)
            {
                //product deleted
                Response.Redirect("catalog.aspx");
            }
            else
            {
                //product not deleted
                Response.Redirect("manageproduct.aspx");
            }
        }
    }
}