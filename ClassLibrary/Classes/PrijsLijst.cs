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
        public int GetID { get { return ID; } }

        public string Naam { get { return naam; } }

        public List<Item> GetItems { get { return items; } }

        public Bestuur User { get { return user; } }

        public bool AddItem(Item item)
        {
            bool done = false;
            try
            {
                items.Add(item);
                done = true;
            }
            catch
            {
                done = false;
            }
            return done;
        }

        public void VerwijderItem(Item item)
        {
            foreach (Item i in items)
            {
                if (i.GetID == item.GetID)
                {
                    items.Remove(i);
                }
            }
        }
    }
}
