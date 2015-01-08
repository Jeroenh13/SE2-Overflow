using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Persoon : IComparable<Persoon>
    {
        private int ID;
        private string naam;
        private string achternaam;
        private DateTime geboortedatum;
        private DateTime registratiedatum;
        private string emailadres;
        private char geslacht;
        private bool betaalstatus;

        public Persoon(int ID, string naam, string achternaam, DateTime geboortedatum, DateTime registratiedatum, string emailadres, char geslacht, bool betaalstatus)
        {
            this.ID = ID;
            this.naam = naam;
            this.achternaam = achternaam;
            this.geboortedatum = geboortedatum;
            this.registratiedatum = registratiedatum;
            this.emailadres = emailadres;
            this.geslacht = geslacht;
            this.betaalstatus = betaalstatus;
        }

        public int GetID { get { return ID; } }

        public string Naam { get { return naam; } }

        public string Achternaam { get { return achternaam; } }

        public string Emailadres { get { return emailadres; } }

        public DateTime GeboorteDatum { get { return geboortedatum; } }

        public char Geslacht { get { return geslacht; } }

        public DateTime RegistratieDatum { get { return registratiedatum; } }

        public bool Betaalstatus { get { return betaalstatus; } }

        public int CompareTo(Persoon other)
        { throw new NotImplementedException(); }

        public override string ToString()
        {
            return Convert.ToString(ID) + naam + achternaam + emailadres + Convert.ToString(geboortedatum) + Convert.ToString(geslacht) +
                   Convert.ToString(registratiedatum) + Convert.ToString(betaalstatus);
        }
    }
}
