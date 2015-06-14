using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Toegevoegde usings voor de connectie
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IKEA.Klassen
{
    public class SelectMaxID
    {
        public SelectMaxID()
        {

        }

        public int getMaXID(string querie)
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
                com.CommandText = querie;
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    /// <summary>
                    /// Ik return de maximum van het ID en tel daar 1 bij op.
                    /// Zo kan ik INSERT statements aanroepen zonder bang te zijn een dubbele primary key te krijgen
                    /// </summary>
                    /// 
                    reader.Read();
                    int maxid = reader.GetInt32(0) + 1;
                    reader.Close();
                    return maxid;
                }
                catch (NullReferenceException)
                {
                    return -1;
                }
            }
        }
    }
}