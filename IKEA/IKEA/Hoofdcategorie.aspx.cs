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
//Zorgt ervoor dat ik HTML code kan genereren
using System.Web.UI.HtmlControls;

namespace IKEA
{
    public partial class Hoofdcategorie : System.Web.UI.Page
    {
        //De Subcategorieen de geselecteerde hoofdcategorie worden in deze
        //list opgeslagen zodat ik voor iedere gevonden categorie de bijhorende
        //sub-subcategorieen kan zoeken.
        List<SubCategorieClass> Subcategorieen = new List<SubCategorieClass>();
        //fields
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
                string hoofdcategorieID = (String)Session["hoofdcategorie"];
                com.CommandText = "SELECT categorieID, subcategorieID, categorienaam FROM categorie WHERE subcategorieID = " + hoofdcategorieID;
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Het maken van de menu-structuur
                    /// </summary>
                    /// 
                    contentCategorieLink.InnerHtml = "<div id=sublijsttekst><ul class=catlist>";
                    //Eerst haal ik alle Subcategorieen op
                    while (reader.Read())
                    {
                        SubCategorieClass scat = new SubCategorieClass(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));
                        Subcategorieen.Add(scat);
                    }
                    //Vervolgens ga ik voor iedere categorie de sub-subcategorieen ophalen
                    //Ook voeg ik deze toe aan de div
                    foreach (SubCategorieClass categorie in Subcategorieen)
                    {
                        contentCategorieLink.InnerHtml += "<li><b>" + categorie.CatName + "</b><ul class=catlist>";
                        com.CommandText = "SELECT categorieID, categorienaam FROM categorie WHERE subcategorieID = " + categorie.SubCatID;
                        reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            //Iedere sub-subcategorie toevoegen aan de subcategorie
                            //contentCategorieLink.InnerHtml += @"<li><a class=""catlink"" id=""" + reader.GetInt32(0) + @""" OnServerClick=""SubSubcategorie_Click"" runat=""server"">" + reader.GetString(1) + "</a></li></li>";
                            contentCategorieLink.InnerHtml += "<li><a class=catlink href=Subcategorie.aspx>" + reader.GetString(1) + "</a></li></li>";
                        }
                        contentCategorieLink.InnerHtml += "</ul></li>";
                    }
                    contentCategorieLink.InnerHtml += "</ul></div>";

                    /// <summary>
                    /// Het inladen van de juiste afbeeldingen
                    /// </summary>
                    /// 
                    contentCategorieAfbeelding.InnerHtml = "<div id=" + "sublijstafb" + "><div class=" + "largeimg" + "><img src =";
                    //De grote afbeelding
                    com.CommandText = "SELECT utl_raw.cast_to_varchar2(dbms_lob.substr(afbeelding)) FROM catafbeelding WHERE formaat = 'groot' AND categorieID = 3";
                    reader = com.ExecuteReader();
                    reader.Read();
                    contentCategorieAfbeelding.InnerHtml += reader.GetString(0); 
                    reader.Close();
                    contentCategorieAfbeelding.InnerHtml += " width=780px height=400px/></div><br /><div id=mediumcontainer><div class=mediumimg><img src =";
                    //De middel afbeelding
                    com.CommandText = "SELECT utl_raw.cast_to_varchar2(dbms_lob.substr(afbeelding)) FROM catafbeelding WHERE formaat = 'middel' AND categorieID = 3";
                    reader = com.ExecuteReader();
                    reader.Read();
                    contentCategorieAfbeelding.InnerHtml += reader.GetString(0);
                    reader.Close();
                    contentCategorieAfbeelding.InnerHtml += " width=500px height=539px/></div>";
                    //De kleine afbeeldingen
                    com.CommandText = "SELECT utl_raw.cast_to_varchar2(dbms_lob.substr(afbeelding)) FROM catafbeelding WHERE formaat = 'klein' AND categorieID = 3";
                    reader = com.ExecuteReader();
                    while (reader.Read() && teller < 3)
                    {
                        contentCategorieAfbeelding.InnerHtml += "<div class=cubeimg"+teller+"><img src =";
                        contentCategorieAfbeelding.InnerHtml += reader.GetString(0);
                        contentCategorieAfbeelding.InnerHtml += " width=260px height=260px/></div>";
                        teller++;
                    }         
                    contentCategorieAfbeelding.InnerHtml += "</div></div>";
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        /// <summary>
        /// SubSubcategorie_click wordt aangeroepen als er op een van de Sub-
        /// categorieen in de menu-balk word geklikt. Het id van de <a> tag wordt
        /// opgehaald en vervolgend opgeslagen in een sessie. Hiermee wordt bijgehouden
        /// bij welke subcategorie je bevind.
        /// </summary>
        protected void SubSubcategorie_Click(object sender, EventArgs e)
        {
            string id = ((Control)sender).ID;
            Session["hoofdcategorie"] = id.Substring(2);
            Response.Redirect("Subcategorie.aspx");
        }
    }
}