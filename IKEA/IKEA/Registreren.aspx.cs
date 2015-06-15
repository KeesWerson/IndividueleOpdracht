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
    public partial class Registreren : System.Web.UI.Page
    {
        //Fields
        int nieuwID;
        Klassen.InsertClass insert;

        protected void Page_Load(object sender, EventArgs e)
        {
            insert = new Klassen.InsertClass();
            lblValidatie.Text = "";
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inloggen.aspx");
        }

        //Functie die zorgt voor de button validatie
        //Dit is deel van een costum-fieldvalidator die ik heb gemaakt
        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = cbVoorwaarden.Checked;
        }

        protected void btnOpslaan_Click(object sender, EventArgs e)
        {
            lblGebruikersnaamError.Visible = false;
            lblValidatie.Text = "";
            //Met Page.Validate kijk ik of er geen ongeldige waarden
            //meer zijn ingevuld, no niet, dan is Page.Validate true
            Page.Validate("AllValidators");
            if (Page.IsValid)
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
                    com.CommandText = "SELECT gebruikersnaam FROM ikeaaccount";
                    DbDataReader reader = com.ExecuteReader();
                    try
                    {
                        /// <summary>
                        /// Ik zoek alle gebruikersnamen op en als ik een
                        /// duplicatie vind dan geef ik een error.
                        /// </summary>
                        ///
                        while (reader.Read())
                        {
                            if (tbGebruikersnaam.Text == reader.GetString(0))
                            {
                                lblGebruikersnaamError.Text = "Niet uniek";
                                lblGebruikersnaamError.Visible = true;
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
                //Als er nu dus geen Error-velden zichtbaar zijn wil dat zeggen
                //Dat de gebruikergegevens kloppen. Daarna wordt er een INSERT statement
                //aangeroepen die de nieuwe gebruiker toevoegt aan de database.
                if (lblGebruikersnaamError.Visible == false)
                {
                    //Het maximum ID opvragen zodat ik een unieke primary key krijg
                    Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
                    nieuwID = selectedMax.getMaXID("SELECT MAX(accountID) FROM ikeaaccount");
                    //Het toevoegen van het account aan de database
                    string telefoornnr;
                    try { telefoornnr = tbTelnrMobiel.Text; }
                    catch { telefoornnr = ""; }
                    insert.InsertData("INSERT INTO ikeaaccount VALUES ("+nieuwID+",'"+tbGebruikersnaam.Text+"','"+tbVoornaam.Text+"','"+tbAchternaam.Text+"','"+telefoornnr+"','"+tbEmail.Text+"','"+tbWachtwoord.Text+"')");        
                    Response.Redirect("Inloggen.aspx");
                }
            }
            else
            {
                lblValidatie.Text = "Uw gegevens zijn ongeldig.";
            }
        }
    }
}