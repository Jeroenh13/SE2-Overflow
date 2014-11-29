using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace Classes
{
    public class Database
    {
        #region DatabaseConnection
        static OleDbConnection connection = new OleDbConnection();
        private static string ConnectionString = "Provider=OraOLEDB.Oracle; Data Source=//fhictora01.fhict.local:1521/fhictora; User Id=dbi305445;Password=hru4ryA10f";
        /// <summary>
        /// Connects to the database
        /// </summary>       
        public static void Connect(string connectstring)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = new OleDbConnection();
                connection.ConnectionString = connectstring;
                try
                {
                    connection.Open();
                }
                catch
                {
                    connection.Dispose();
                }
            }
        }

        /// <summary>
        /// Close the connection with the database
        /// </summary>
        public static void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
        #endregion;    

        public static List<Persoon> GetLeden()
        {
            List<Persoon> LedenLijst = new List<Persoon>();
            try
            {
                Connect(ConnectionString);

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM DBS2_PERSOON WHERE ID IN( SELECT ID FROM DBS2_LID)";
                //cmd.Parameters.Add(new OleDbParameter("?", username));

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Persoon p = new Persoon();
                    p.Wijzig(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDateTime(dr[6]), dr[5].ToString(),
                        Convert.ToChar(dr[7]));
                    LedenLijst.Add(p);
                }
            }
            catch
            { }
            finally { Close(); }
            return LedenLijst;
        }
    }


}
