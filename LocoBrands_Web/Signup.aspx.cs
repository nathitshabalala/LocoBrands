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
    public partial class Signup : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);

            if (Session["LoggedInUser"] == null)
            {
                if (name.Value != null && surname.Value != null && email.Value != null && password.Value != null)
                {
                    bool isRegistered = sr.CreateUser(name.Value, surname.Value, Secrecy.HashPassword(password.Value), email.Value, 1);
                    if (isRegistered.Equals(true))
                    {
                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        Response.Redirect("Signup.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Signup.aspx");
                }
            }
            else
            {
                Response.Redirect("Signup.aspx");
            }
        }
    }
}