using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Sticky_Note_Muur
    {
        private string naam;
        private List<Sticky_Note> sticky_notes;

        public Sticky_Note_Muur(string naam)
        {
            sticky_notes = new List<Sticky_Note>();
            this.naam = naam;
        }

        public string Naam
        {
            get { return naam; }
            set
            {
            }
        }

        public List<Sticky_Note> Sticky_Notes
        {
            get { return sticky_notes; }
            set
            {
            }
        }

        public void AddSticky_Note(Sticky_Note sn)
        {
            throw new System.NotImplementedException();
        }

        public void VerwijderSticky_Note(Sticky_Note sn)
        {
            throw new System.NotImplementedException();
        }
    }
}
