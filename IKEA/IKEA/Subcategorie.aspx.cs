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
    public partial class Subcategorie : System.Web.UI.Page
    {
        //Fields
        int teller = 1;

        protected void Page_Load(object sender, EventArgs e)
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
                com.CommandText = "SELECT categorienaam, categorieomschrijving FROM categorie WHERE categorieID = 9";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Het inladen van de juiste item-afbeeldingen
                    /// </summary>
                    /// 
                    reader.Read();
                    lblCategorie.Text = reader.GetString(0);
                    try
                    {
                        lblCatOmschrijving.Text = reader.GetString(1);
                    }
                    catch { lblCatOmschrijving.Text = ""; }
                    reader.Close();
                    //Met deze querie haal ik alle afbeeldingen van de huidige categorie op.
                    //Vervolgens ga ik ze in rijen van 4 plaatsen.
                    com.CommandText = "SELECT utl_raw.cast_to_varchar2(dbms_lob.substr(afbeelding)) FROM item WHERE categorieID = 9";
                    reader = com.ExecuteReader();
                    contentCategorieLink.InnerHtml += "<div class=row>";
                    while (reader.Read())
                    {
                        contentCategorieLink.InnerHtml += "<a href=Item.aspx><div class=item" + teller + "><img src=";
                        //Als de afbeelding niet wordt gevonden in de database
                        //(Dus als de afbeeldingcell de waarde 'null' bevat) zal de
                        //image_not_found image worden afgebeeld. Dit is om errors te voorkomen.
                        try
                        {
                            contentCategorieLink.InnerHtml += reader.GetString(0);
                        }
                        catch
                        {
                            contentCategorieLink.InnerHtml += "Images/image_not_found.png";
                        }
                        contentCategorieLink.InnerHtml += " width=235px height=300px/></div></a>";
                        if (teller == 4)
                        {
                            contentCategorieLink.InnerHtml += "</div><br /><div class=row>";
                            teller = 0;
                        }             
                        teller++;
                    }
                    contentCategorieLink.InnerHtml += "</div><br />";
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("De connectie is verbroken.");
                }
            }
        }
    }
}