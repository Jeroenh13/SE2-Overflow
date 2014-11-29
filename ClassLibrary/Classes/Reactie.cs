using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Reactie
    {
        private int ID;
        private Bestuur user;
        private string bericht;
        private int parentID;
    
        public Reactie(Bestuur user, string bericht)
        {
            this.user = user;
            this.bericht = bericht;
        }

        public int GetID
        {
            get { return ID; }
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

        public string Bericht
        {
            get { return bericht; }
            set
            {
            }
        }

        public int ParentID
        {
            get { return parentID; }
            set
            {
            }
        }
    }
}
