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
                com.CommandText = "SELECT categorieID, subcategorieID, categorienaam FROM categorie WHERE subcategorieID = 2";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    contentCategorieLink.InnerHtml = "<div id=" + "sublijsttekst" + "><ul class=" + "catlist" + ">";
                    //Eerst haal ik alle Subcategorieen op
                    while (reader.Read())
                    {
                        SubCategorieClass scat = new SubCategorieClass(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));
                        Subcategorieen.Add(scat);
                    }
                    //Vervolgens ga ik voor iedere categorie de subcategorieen ophalen
                    //Ook voeg ik deze toe aan de div
                    foreach (SubCategorieClass categorie in Subcategorieen)
                    {
                        contentCategorieLink.InnerHtml += "<li><b>" + categorie.CatName + "</b><ul class=" + "catlist" + ">";
                        com.CommandText = "SELECT categorienaam FROM categorie WHERE subcategorieID = " + categorie.SubCatID;
                        reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            //Iedere sub-subcategorie toevoegen aan de subcategorie
                            contentCategorieLink.InnerHtml += "<li><a class=" + "catlink" + " href=" + "Subcategorie.aspx" + ">" + reader.GetString(0) + "</a></li>";
                        }
                        contentCategorieLink.InnerHtml += "</ul></li>";
                    }
                    contentCategorieLink.InnerHtml += "</ul></div>";
                }
                catch (NullReferenceException)
                {

                }
            }
        }
    }
}