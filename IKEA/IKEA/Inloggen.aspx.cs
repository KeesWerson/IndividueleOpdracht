using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Toegevoegde usings voor de connectie
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IKEA
{
    public partial class Inloggen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                if (con == null)
                {
                    //return "Error! No Connection";
                }
                con.ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                if (com == null)
                {
                    //return "Error! No Command";
                }
                com.Connection = con;
                com.CommandText = "SELECT gebruikersnaam, wachtwoord, accountID FROM ikeaaccount";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Kijken of er een juiste combinatie van gebruikersnaam en
                    /// wachtwoord is ingevoerd.
                    /// </summary>
                    /// 
                    lblInlogError.Visible = false;
                    while (reader.Read())
                    {
                        if (tbGebruikersnaam.Text == reader.GetString(0) && tbWachtwoord.Text == reader.GetString(1))
                        {
                            Session["gebruikersnaam"] = tbGebruikersnaam.Text;
                            Session["accountid"] = reader.GetInt32(2);
                            Response.Redirect("Hoofdpagina.aspx");
                        }
                    }
                    if (tbGebruikersnaam.Text != "INGELOGD")
                    {
                        lblInlogError.Visible = true;
                    }
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        protected void Registreer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registreren.aspx");
        }
    }
}