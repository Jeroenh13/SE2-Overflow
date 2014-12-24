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
        OleDbConnection connection = new OleDbConnection();
        private string ConnectionString = "Provider=OraOLEDB.Oracle; Data Source=//fhictora01.fhict.local:1521/fhictora; User Id=dbi305445;Password=PTVNpoHu6L";
        /// <summary>
        /// Connects to the database
        /// </summary>       
        public void Connect(string connectstring)
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
        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
        #endregion;    

        public List<Persoon> GetLeden(string alph)
        {
            List<Persoon> LedenLijst = new List<Persoon>();
            try
            {
                Connect(ConnectionString);

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                if (alph == "ALL")
                {
                    cmd.CommandText =
                           "SELECT * FROM DBS2_PERSOON WHERE ID IN(SELECT ID FROM DBS2_LID)";

                }
                else
                {
                    cmd.CommandText =
                        "SELECT * FROM DBS2_PERSOON WHERE ID IN(SELECT ID FROM DBS2_LID) AND UPPER(NAAM) LIKE '" + alph + "%'";
                }

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[5] == DBNull.Value)
                    {
                        LedenLijst.Add(new Persoon(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(),
                            Convert.ToDateTime(null), Convert.ToDateTime(dr[3]), dr[4].ToString(), Convert.ToChar(dr[6]),
                            getBetaald(Convert.ToInt32(dr[0]))));
                    }
                    else
                    {
                        LedenLijst.Add(new Persoon(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(),
                            Convert.ToDateTime(dr[5]), Convert.ToDateTime(dr[3]), dr[4].ToString(),
                            Convert.ToChar(dr[6]), getBetaald(Convert.ToInt32(dr[0]))));
                    }
                }
            }
            catch
            { }
            finally { Close(); }
            return LedenLijst;
        }

        /// <summary>
        /// Vraagt de betaalstatus op van een bepaalde persoon
        /// NIET AANROEPEN!!
        /// </summary>
        /// <param name="pid">Persoons ID </param>
        /// <returns>Bool betaald</returns>
        public bool getBetaald(int pid)
        {
            bool isbetaald = false;
            try
            {
                Connect(ConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT ISBETAALD FROM DBS2_BETALING WHERE PERSOON_ID = " + pid;
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    isbetaald = Convert.ToBoolean(dr[0]);
                }
            }
            catch
            {
            }
            return isbetaald;   
        }

        public bool nieuwLid()
        {
            bool done;
            try
            {
                done = true;
            }
            catch
            {
                done = false;
            }
            finally
            {Close();}

            return done;
        }
    }


}
