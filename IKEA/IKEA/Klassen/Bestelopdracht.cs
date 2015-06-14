using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Toegevoegde usings voor de connectie
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
//Voor het comitten van data
using System.Data;

namespace IKEA.Klassen
{
    public class BestelOpdracht
    {
        public int BestelNummer { get; set; }
        public int AccountID { get; set; }
        public int ItemID { get; set; }
        public DateTime BestelDatum { get; set; }
        public int WagenOfLijst { get; set; }
        public int Aantal { get; set; }

        public BestelOpdracht(int bestelNummer, int accountID, int itemID, DateTime datum, int wagenOfLijst, int aantal)
        {
            this.BestelNummer = bestelNummer;
            this.AccountID = accountID;
            this.ItemID = itemID;
            this.BestelDatum = datum;
            this.WagenOfLijst = wagenOfLijst;
            this.Aantal = aantal;
        }

        public void AddBestelling(BestelOpdracht b)
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
                OracleTransaction otn = (OracleTransaction)con.BeginTransaction(IsolationLevel.ReadCommitted);
                if (com == null)
                {
                    //return "Error! No Command";
                }
                com.Connection = con;
                com.CommandText = "INSERT INTO bestelopdracht VALUES ("+b.BestelNummer+","+b.AccountID+","+b.ItemID+","+b.BestelDatum+","+b.WagenOfLijst+","+b.Aantal+")";
                try
                {
                    com.ExecuteNonQuery();
                    otn.Commit();
                }
                catch (NullReferenceException)
                {
                    
                }
            }
        }
    }
}