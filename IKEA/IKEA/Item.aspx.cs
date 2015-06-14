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
    public partial class Item : System.Web.UI.Page
    {
        //Fields
        int aantal;
        int nieuwID;
        int itemid;
        Klassen.InsertClass insert;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Niewe instantie van de insertklas
            insert = new Klassen.InsertClass();

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
                com.CommandText = "SELECT naam, soort, prijs, itemID, productomschrijving, afbeelding FROM item WHERE itemID = 1";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Het inladen van de juiste itemgegevens
                    /// Als eerste laad ik de teksten, kosten omschrijvingen etc
                    /// en daarna laad ik de bijhorende afbeelding.
                    /// </summary>
                    /// 
                    reader.Read();
                    lblNaam.Text = reader.GetString(0); 
                    lblSoortOmschr.Text = reader.GetString(1); 
                    lblKosten.Text = "€" + reader.GetDouble(2); 
                    lblArtNr.Text = "Artikel Nr: " + reader.GetInt32(3);
                    itemid = reader.GetInt32(3);
                    lblOmschrijving.Text = reader.GetString(4) + "ja ik weet dat dit een lange zin is maar ik wil heel erg graag een of adere moeilijke test uitvoeren waardoor blijkt dat mijn div`s goed mee gaan schalen. Als dit niet het geval is zal ik mijn dynamiteit van de site aan moeten passen.";
                    reader.Close();
                    //Het invullen van de juiste afbeelding
                    contentItemAfbeelding.InnerHtml = "<div id=picture><img src =";
                    //Als de afbeelding niet wordt gevonden in de database
                    //(Dus als de afbeeldingcell de waarde 'null' bevat) zal de
                    //image_not_found image worden afgebeeld. Dit is om errors te voorkomen.
                    try
                    {
                        contentItemAfbeelding.InnerHtml += reader.GetString(5);
                    }
                    catch
                    {
                        contentItemAfbeelding.InnerHtml += "Images/image_not_found.png";
                    }
                    contentItemAfbeelding.InnerHtml += " width=450px height=450px/></div>";
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        protected void btnWinkelwagen_Click(object sender, EventArgs e)
        {
            lblAantalError.Visible = false;
            try
            {
                aantal = Convert.ToInt32(tbAantal.Text);
                //Het maximum ID opvragen zodat ik een unieke primary key krijg
                Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
                nieuwID = selectedMax.getMaXID("SELECT MAX(bestelnummer) FROM bestelopdracht");
                //Het toevoegen van de order
                string datum = DateTime.Now.ToString("dd-MMM-yyyy");
                insert.InsertData("INSERT INTO bestelopdracht VALUES ("+nieuwID+",1,"+itemid+",'"+datum+"',1,"+aantal+")");        
                Response.Redirect("Winkelwagen.aspx");
            }
            catch { lblAantalError.Visible = true; }
        }

        protected void btnVerlanglijst_Click(object sender, EventArgs e)
        {
            lblAantalError.Visible = false;
            try
            {
                aantal = Convert.ToInt32(tbAantal.Text);
                //Het maximum ID opvragen zodat ik een unieke primary key krijg
                Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
                nieuwID = selectedMax.getMaXID("SELECT MAX(bestelnummer) FROM bestelopdracht");
                //Het toevoegen van de order
                string datum = DateTime.Now.ToString("dd-MMM-yyyy");
                insert.InsertData("INSERT INTO bestelopdracht VALUES (" + nieuwID + ",1," + itemid + ",'" + datum + "',0," + aantal + ")");
                Response.Redirect("Verlanglijst.aspx");
            }
            catch { lblAantalError.Visible = true; }
        }
    }
}