using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Classes
{
    public class Sticky_Note
    {
        private int ID;
        private Bestuur user;
        private DateTime datum;
        private string titel;
        private string bericht;
        private List<Reactie> reacties; 

        public Sticky_Note(int ID, Bestuur user, string titel, string bericht, DateTime datum)
        {
            reacties = new List<Reactie>();
            this.ID = ID;
            this.user = user;
            this.datum = datum;
            this.titel = titel;
            this.bericht = bericht;
        }

        public int GetID
        {
            get { return ID; }
            set
            {
            }
        }

        public DateTime Datum
        {
            get { return datum; }
            set
            {
            }
        }

        public string Titel
        {
            get { return titel; }
            set
            {
            }
        }

        public string Bericht
        {
            get { return bericht; }
            set
            {
            }
        }

        public Bestuur User
        {
            get { return user; }
            set
            {
            }
        }

        public List<Reactie> Reacties
        {
            get { return reacties; }
            set
            {
            }
        }

        public void AddReactie(Reactie r)
        {
            reacties.Add(r);
        }
    }
}
