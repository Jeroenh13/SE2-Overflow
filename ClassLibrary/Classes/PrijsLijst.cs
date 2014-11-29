using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class PrijsLijst
    {
        private int ID;
        private string naam;
        private List<Item> items;
        private Bestuur user;

        public PrijsLijst(int ID, string naam, Bestuur user)
        {
            this.ID = ID;
            this.naam = naam;
            this.user = user;
            items = new List<Item>();
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

        public List<Item> GetItems
        {
            get { return items; }
        }

        public Bestuur User
        {
            get { return user; }
            set
            {
            }
        }

        public bool AddItem(Item i)
        {
            throw new System.NotImplementedException();
        }

        public void VerwijderItem(Item i)
        {
            throw new System.NotImplementedException();
        }
    }
}
