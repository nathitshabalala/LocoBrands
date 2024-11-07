using LocoBrands_Web.ServiceReference1;
using SecrecySpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class login : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            int ID = sr.LoginUser(email_field.Value, Secrecy.HashPassword(password_field.Value));

            if (ID != 0)
            {
                Session["LoggedInUser"] = ID;
                Response.Redirect("index.aspx");
            }
        }
    }
}