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

        public List<Bestuur> GetBestuursLeden()
        {
            List<Bestuur> bestuur = new List<Bestuur>();
            try
            {
                Connect(ConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    "SELECT * FROM DBS2_PERSOON p, DBS2_BESTUURSLID b WHERE p.ID IN(SELECT ID FROM DBS2_BESTUURSLID) AND p.ID = b.ID";
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bestuur.Add(new Bestuur(Convert.ToInt32(dr[0]), dr[9].ToString(), dr[10].ToString(),
                        dr[1].ToString(), dr[2].ToString(), Convert.ToDateTime(dr[5]), Convert.ToDateTime(dr[3]),
                        dr[4].ToString(), Convert.ToChar(dr[6]), getBetaald(Convert.ToInt32(dr[0]))));
                }
            }
            catch
            {
            }
            finally
            {Close();}
            return bestuur;
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

        public List<Sticky_Note> GetStickyNotes()
        {
            List<Sticky_Note> stickynotes = new List<Sticky_Note>();
            try
            {
                Connect(ConnectionString);

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM DBS2_STICKY_NOTE";

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stickynotes.Add(new Sticky_Note(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), dr[3].ToString(),
                        dr[4].ToString(), Convert.ToDateTime(dr[2])));
                }
            }
            catch
            { }
            finally { Close(); }
            return stickynotes;
        }

        public List<Reactie> GetReacties()
        {
            List<Reactie> reacties = new List<Reactie>();
            try
            {
                Connect(ConnectionString);

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM DBS2_REACTIE";

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[1] == DBNull.Value)
                    {
                        reacties.Add(new Reactie(Convert.ToInt32(dr[0]),Convert.ToInt32(dr[3]), Convert.ToInt32(dr[2]),Convert.ToDateTime(dr[4]),dr[5].ToString()));
                        
                    }
                    else
                    {
                        reacties.Add(new Reactie(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[1]), Convert.ToDateTime(dr[4]), dr[5].ToString()));
                    }
                }
            }
            catch
            { }
            finally { Close(); }
            return reacties;
        }
    }
}
