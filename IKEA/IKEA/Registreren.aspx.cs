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
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inloggen.aspx");
        }

        protected void btnOpslaan_Click(object sender, EventArgs e)
        {
            //Het resetten van de Error-velden
            lblGebruikersnaamError.Visible = false;
            lblGebruikersnaamError.Text = "Verplicht veld";
            lblVoornaamError.Visible = false;
            lblAchternaamError.Visible = false;
            lblEmailError.Visible = false;
            lblEmailOpnieuwError.Visible = false;
            lblEmailOpnieuwError.Text = "Verlpicht veld";
            lblWachtwoordError.Visible = false;
            lblWachtwoordOpnieuwError.Visible = false;
            lblWachtwoordOpnieuwError.Text = "Verlpicht veld";
            lblVoorwaardenError.Visible = false;
            //Eerst kijk ik of de velden niet gelijk zijn aan null
            //Zo ja, dan komt er een errormassage
            if (tbGebruikersnaam.Text == "") { lblGebruikersnaamError.Visible = true; }
            if (tbVoornaam.Text == "") { lblVoornaamError.Visible = true; }
            if (tbAchternaam.Text == "") { lblAchternaamError.Visible = true; }
            if (tbEmail.Text == "") { lblEmailError.Visible = true; }
            if (tbEmailOpnieuw.Text == "") { lblEmailOpnieuwError.Visible = true; }
            if (tbWachtwoord.Text == "") { lblWachtwoordError.Visible = true; }
            if (tbWachtwoordOpnieuw.Text == "") { lblWachtwoordOpnieuwError.Visible = true; }
            if (cbVoorwaarden.Checked == false) { lblVoorwaardenError.Visible = true; }
            //Daarna kijk ik of de bevestigingen van het email
            //en wachtwoord overeen komen.
            if (lblEmailOpnieuwError.Visible == false && tbEmail.Text != tbEmailOpnieuw.Text)
            { lblEmailOpnieuwError.Text = "Komt niet overeen"; lblEmailOpnieuwError.Visible = true; }
            if (lblWachtwoordOpnieuwError.Visible == false && tbWachtwoord.Text != tbWachtwoordOpnieuw.Text)
            { lblWachtwoordOpnieuwError.Text = "Komt niet overeen"; lblWachtwoordOpnieuwError.Visible = true; }
            //Als die gegevens kloppen kijk ik als laatste of de
            //gebruikersnaam uniek is.
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
                    /// Het inladen van de juiste itemgegevens
                    /// Als eerste laad ik de teksten, kosten omschrijvingen etc
                    /// en daarna laad ik de bijhorende afbeelding.
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
            {
                //Het maximum ID opvragen zodat ik een unieke primary key krijg
                Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
                nieuwID = selectedMax.getMaXID("SELECT MAX(accountID) FROM ikeaaccount");
                //Het toevoegen van het account aan de database
            }
        }
    }
}