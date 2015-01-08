using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Reactie
    {
        private int ID;
        private int bestuursID;
        private int sticky_noteID;
        private Bestuur user;
        private DateTime datum;
        private string bericht;
        private int parentID;
    
        public Reactie(int ID, int bestuursid, int sticky_noteID, DateTime datum, string bericht)
        {
            this.ID = ID;
            this.bestuursID = bestuursid;
            this.sticky_noteID = sticky_noteID;
            this.bericht = bericht;
            this.datum = datum;
        }
        public Reactie(int ID, int bestuursid, int sticky_noteID, int parentID, DateTime datum, string bericht)
        {
            this.ID = ID;
            this.parentID = parentID;
            this.sticky_noteID = sticky_noteID;
            this.bestuursID = bestuursid;
            this.bericht = bericht;
            this.datum = datum;
        }

        public int GetID { get { return ID; } }

        public int BestuursID { get { return bestuursID; } }

        public int Sticky_NoteID { get { return sticky_noteID; } }

        public Bestuur User { get { return user; } }

        public DateTime Datum { get { return datum; } }

        public string Bericht { get { return bericht; } }

        public int ParentID { get { return parentID; } }

        public void AddBestuur(Bestuur b)
        {
            user = b;
        }
    }
}
