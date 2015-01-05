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
        private int bestuursID;
        private Bestuur bestuur;
        private DateTime datum;
        private string titel;
        private string bericht;
        private List<Reactie> reacties; 

        public Sticky_Note(int ID, int user, string titel, string bericht, DateTime datum)
        {
            reacties = new List<Reactie>();
            this.ID = ID;
            this.bestuursID = user;
            this.datum = datum;
            this.titel = titel;
            this.bericht = bericht;
        }

        public int GetID{get { return ID; }set{}}

        public DateTime Datum{get { return datum; }set{}}

        public string Titel{get { return titel; }set{}}

        public string Bericht{get { return bericht; }set{}}

        public int BestuursID { get { return bestuursID; } set { } }

        public Bestuur Bestuur {get { return bestuur; }}

        public List<Reactie> Reacties{get { return reacties; }set{}}
        
        public void AddBestuur(Bestuur b)
        {
            bestuur = b;
        }

        public void AddReactie(Reactie r)
        {
            reacties.Add(r);
        }
    }
}
