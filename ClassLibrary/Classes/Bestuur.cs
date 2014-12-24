using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Bestuur : Persoon
    {
        private string functie;
        private string wachtwoord;

        public Bestuur(int ID, string functie, string wachtwoord, string naam, string achternaam, DateTime geboortedatum, DateTime registratiedatum, string emailadres, char geslacht, bool betaalstatus)
            : base(ID, naam, achternaam, geboortedatum, registratiedatum,emailadres, geslacht, betaalstatus)
        {
            this.functie = functie;
            this.wachtwoord = wachtwoord;
        }

        public string Functie
        {
            get { return functie; }
            set
            {
            }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set
            {
            }
        }

        public void VeranderFunctie()
        {
            throw new System.NotImplementedException();
        }
    }
}
