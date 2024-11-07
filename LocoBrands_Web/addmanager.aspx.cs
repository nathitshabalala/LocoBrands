using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class addmanager : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addmanager_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);

            if (Session["LoggedInUser"] != null)
            {

                if (sr.IsManager(id).Equals(true))
                {
                    if (name.Value != null && surname.Value != null && email.Value != null && Password.Value != null)
                    {
                        bool isRegistered = sr.CreateUser(name.Value, surname.Value, Password.Value, email.Value, 2);
                        if (isRegistered.Equals(true))
                        {
                            Response.Redirect("login.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("addmanager.aspx");
                    }
                }
                else
                {
                    Response.Redirect("addmanager.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}