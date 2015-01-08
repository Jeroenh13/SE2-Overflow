using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Item
    {
        private int ID;
        private string naam;
        private double prijs;
        private bool highlighted;

        public Item(int ID, string naam, double prijs)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
            highlighted = false;
        }

        public int GetID { get { return ID; } }

        public string Naam { get { return naam; } }

        public double Prijs { get { return prijs; } }

        public bool HighLighted { get { return highlighted; } }

        public void UpdatePrijs(double prijs)
        {
            this.prijs = prijs;
        }
    }
}
