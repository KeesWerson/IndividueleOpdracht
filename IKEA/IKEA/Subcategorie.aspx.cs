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
                com.CommandText = "SELECT categorienaam, categorieomschrijving FROM categorie WHERE categorieID = 1";
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    reader.Read();
                    lblCategorie.Text = reader[0].ToString();
                    lblCatOmschrijving.Text = reader[1].ToString();
                    reader.Close();
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("De connectie is verbroken.");
                }
            }
        }
    }
}