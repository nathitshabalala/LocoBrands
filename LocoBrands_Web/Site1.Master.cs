using LocoBrands_Web.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocoBrands_Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            int value = Convert.ToInt32(Request.QueryString["logoutid"]);

            if (value == -1)
            {
                Session["LoggedInUser"] = null;
            }
            
            if (Session["LoggedInUser"] != null)
            {
                logout.Visible = true;
                logout1.Visible = true;

                login.Visible = false;
                login1.Visible = false;

                register.Visible = false;
                register1.Visible = false;

                if (sr.IsManager(id).Equals(true))
                {
                    addman.Visible = true;
                    addman1.Visible = true;
                    manprod.Visible = true;
                    report_id.Visible = true;
                    
                }
                else
                {
                    addman.Visible = false;
                    addman1.Visible = false;
                }

                string display = $@"
                              <a href='invoices.aspx?UserID={id} 'class='flex-c-m trans-04 p-lr-25' id='invoices_id' visible='true'>Invoices</a>";

                Userinv.InnerHtml = display;
            }
            else
            {
                logout.Visible = false;
                logout1.Visible = false;
            }
        }
    }
}