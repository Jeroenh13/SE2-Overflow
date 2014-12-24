using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Lid : Persoon
    {
        public Lid(int ID, string naam, string achternaam, DateTime geboortedatum, DateTime registratiedatum, string emailadres, char geslacht, bool betaalstatus) : base(ID, naam, achternaam, geboortedatum,registratiedatum, emailadres, geslacht, betaalstatus)
        {
            
        }
    }
}
