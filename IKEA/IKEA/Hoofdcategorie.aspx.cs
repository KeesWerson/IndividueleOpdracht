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
    public partial class Hoofdcategorie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
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
                com.CommandText = "SELECT naam, soort, prijs, itemID, productomschrijving FROM item WHERE itemID = 1";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    reader.Read();
                    lblNaam.Text = reader[0].ToString();
                    lblSoortOmschr.Text = reader[1].ToString();
                    lblKosten.Text = "€" + reader[2].ToString();
                    lblArtNr.Text = "Artikel Nr: " + reader[3].ToString();
                    lblOmschrijving.Text = reader[4].ToString() + "ja ik weet dat dit een lange zin is maar ik wil heel erg graag een of adere moeilijke test uitvoeren waardoor blijkt dat mijn div`s goed mee gaan schalen. Als dit niet het geval is zal ik mijn dynamiteit van de site aan moeten passen.";
                    reader.Close();
                }
                catch (NullReferenceException)
                {

                }
            }*/
        }
    }
}