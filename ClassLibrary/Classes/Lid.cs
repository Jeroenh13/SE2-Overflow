using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Lid : Persoon
    {
        public Lid(int ID, string naam, DateTime geboortedatum, string emailadres, char geslacht, bool betaalstatus) : base(ID, naam, geboortedatum, emailadres, geslacht, betaalstatus)
        {
            
        }
    }
}
