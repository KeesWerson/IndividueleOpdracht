using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IKEA
{
    public partial class IKEA : System.Web.UI.MasterPage
    {
        //Als er een gebruiker is ingelogd zal de gebruikersnaam
        //Boven aan de pagine worden gedisplayd.
        protected void Page_Load(object sender, EventArgs e)
        {
            string gebruikersnaam = (String)Session["gebruikersnaam"];
            if (gebruikersnaam != null)
            {
                lblUser.Text = "User: " + gebruikersnaam;
            }
            else
            {
                lblUser.Text = "";
            }
        }

        //Het eindigen van de inlog sessie.
        protected void Uitloggen_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = (String)Session["gebruikersnaam"];
            if (gebruikersnaam != null)
            {
                string script = "alert(\"U bent succesvol uitgelogd.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                Session["gebruikersnaam"] = null;
                Session["accountid"] = null;
                lblUser.Text = "";
                Response.Redirect("Hoofdpagina.aspx");
            }
            else
            {
                string script = "alert(\"U bent niet ingelogd.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                lblUser.Text = "";
            }            
        }
    }
}