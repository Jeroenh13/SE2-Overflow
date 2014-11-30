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
        private DateTime geboortedatum;
        private DateTime registratiedatum;
        private string emailadres;
        private char geslacht;
        private bool betaalstatus;

        public Persoon(int ID, string naam, DateTime geboortedatum, string emailadres, char geslacht, bool betaalstatus)
        {
            this.ID = ID;
            this.naam = naam;
            this.geboortedatum = geboortedatum;
            this.emailadres = emailadres;
            this.geslacht = geslacht;
            this.betaalstatus = betaalstatus;
        }

        public Persoon()
        {
            
        }

        public int GetID
        {
            get { return ID; }
            set
            {
            }
        }

        public string Naam
        {
            get { return naam; }
            set
            {
            }
        }

        public string Emailadres
        {
            get { return emailadres; }
            set
            {
            }
        }

        public DateTime GeboorteDatum
        {
            get { return geboortedatum; }
            set
            {
            }
        }

        public char Geslacht
        {
            get { return geslacht; }
            set
            {
            }
        }

        public DateTime RegistratieDatum
        {
            get { return registratiedatum; }
            set
            {
            }
        }

        public bool Betaalstatus
        {
            get { return betaalstatus; }
            set
            {
            }
        }

        public int CompareTo(Persoon other)
        {
            throw new NotImplementedException();
        }

        public void Wijzig(int ID, string naam, DateTime gebdatum, string email, char geslacht)
        {
            this.ID = ID;
            this.naam = naam;
            this.geboortedatum = gebdatum;
            this.emailadres = email;
            this.geslacht = geslacht;
        }
    }
}
