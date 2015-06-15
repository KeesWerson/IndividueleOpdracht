using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IKEA
{
    public partial class Sitebeheer : System.Web.UI.Page
    {
        //Fields
        int aantal;
        int nieuwID;
        Klassen.InsertClass insert;

        protected void Page_Load(object sender, EventArgs e)
        {
            insert = new Klassen.InsertClass();
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            //Het maximum ID opvragen zodat ik een unieke primary key krijg
            Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
            nieuwID = selectedMax.getMaXID("SELECT MAX(itemID) FROM item");
            //Het toevoegen van het item
            insert.InsertData("INSERT INTO item VALUES (" + nieuwID + "," + tbCategorie.Text + ",'" + tbSoort.Text + "','" + tbNaam.Text + "','" + tbProductomschr.Text + "'," + tbPrijs.Text + ",null)");
        }

        protected void btnAddCategorie_Click(object sender, EventArgs e)
        {
            //Het maximum ID opvragen zodat ik een unieke primary key krijg
            Klassen.SelectMaxID selectedMax = new Klassen.SelectMaxID();
            nieuwID = selectedMax.getMaXID("SELECT MAX(categorieID) FROM categorie");
            //Het toevoegen van de categorie
            insert.InsertData("INSERT INTO categorie VALUES (" + nieuwID + "," + tbSubCat.Text + ",'" + tbCatNaam.Text + "','" + tbOmschrijving.Text + "')");
        }
    }
}