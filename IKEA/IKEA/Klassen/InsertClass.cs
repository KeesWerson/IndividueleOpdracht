using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Toegevoegde usings voor de connectie
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
//Voor de INSERT statements
using System.Data;

namespace IKEA.Klassen
{
    public class InsertClass
    {
        public InsertClass ()
	    {
                
	    }

        public void InsertData(string querie)
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
                OracleCommand cmd = (OracleCommand)con.CreateCommand();
                try
                {
                    OracleTransaction otn = (OracleTransaction)con.BeginTransaction(IsolationLevel.ReadCommitted);                  
                    cmd.CommandText = querie;
                    cmd.ExecuteNonQuery();
                    otn.Commit();
                }
                catch (NullReferenceException)
                {

                }
            }
        }
    }
}