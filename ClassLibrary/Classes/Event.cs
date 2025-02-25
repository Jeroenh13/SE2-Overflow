﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Event
    {
        private Bestuur user;
        private string naam;
        private DateTime datum_tijd;
        private string locatie;
        private int ID;

        public Event(int ID, Bestuur user, string naam, DateTime datum_tijd, string locatie)
        {
            this.user = user;
            this.ID = ID;
            this.naam = naam;
            this.datum_tijd = datum_tijd;
            this.locatie = locatie;
        }


        public Bestuur User { get { return user; } }

        public string Naam { get { return naam; } }

        public DateTime Datum_Tijd { get { return datum_tijd; } }

        public string Locatie { get { return locatie; } }

        public int GetID { get { return ID; } }
    }
}
