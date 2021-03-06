﻿using System;
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
    public partial class Winkelwagen : System.Web.UI.Page
    {
        //fields
        bool lineChecker = false;

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
                //Het ophalen van het id van de ingelogde gebruiker.
                //Is er niemand ingelog, dan wordt gebruikerid -1.
                string gebruikerid;
                try { gebruikerid = (String)Session["accountid"].ToString(); }
                catch { gebruikerid = "-1"; }
                lblGebruikerError.Visible = false;
                com.Connection = con;
                com.CommandText = "SELECT i.afbeelding, i.prijs, b.aantal, i.productomschrijving FROM item i, bestelopdracht b WHERE i.itemID = b.itemID AND wagenoflijst = 1 AND b.accountID = " + gebruikerid;
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Het inladen van de juiste item-afbeeldingen
                    /// </summary>
                    ///
                    while (reader.Read())
                    {
                        //De eerste keer moet er geen lijn getekend worden
                        if (!lineChecker)
                        {
                            lineChecker = true;
                        }
                        else
                        {
                            contentWinkelwagen.InnerHtml += "<br /><hr /><br />";
                        }
                        //Voor iedere bestelregel voeg ik de waardes toe aan de winkelwagen.
                        contentWinkelwagen.InnerHtml += "<div class=rowcontainer><div class=productomschrijving><div class=afbeelding><img src=";
                        try { contentWinkelwagen.InnerHtml += reader.GetString(0); } //De afbeelding
                        catch { contentWinkelwagen.InnerHtml += "Images/image_not_found.png"; } //De afbeelding als deze niet gevonden is in de database
                        contentWinkelwagen.InnerHtml += " width=40px height=40px/></div></div><div class=prijs>";
                        contentWinkelwagen.InnerHtml += reader.GetDouble(1); //Prijs per stuk
                        contentWinkelwagen.InnerHtml += "</div><div class=aantal>";
                        contentWinkelwagen.InnerHtml += reader.GetInt32(2); //Aantal items
                        contentWinkelwagen.InnerHtml += "</div><div class=totaal>";
                        contentWinkelwagen.InnerHtml += (reader.GetDouble(1) * reader.GetInt32(2)); //Totale prijs
                        contentWinkelwagen.InnerHtml += "</div><div class=verwijder><a href=NotImplemented.aspx>Verwijder</a></div></div>";
                    }
                    if (gebruikerid == "-1")
                    {
                        lblGebruikerError.Visible = true;
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("De connectie is verbroken.");
                }
            }
        }
    }
}