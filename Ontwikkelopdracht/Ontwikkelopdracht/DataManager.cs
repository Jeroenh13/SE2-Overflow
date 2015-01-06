using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes;

namespace Ontwikkelopdracht
{
    public class DataManager
    {
        private Database db = new Database();

        public Bestuur Login(string U, string P)
        {
            Bestuur b;
            b = db.login(U, P);
            return b;
        }

        public void NieuweStickyNote(string titel, string bericht, Bestuur b, DateTime datum)
        {
            db.AddStickyNote(titel, bericht, b.GetID, datum);
        }

        public void NieuweReactie(int parent, Sticky_Note sn, string bericht, Bestuur b, DateTime datum)
        {
            db.AddReactie(parent, sn.GetID, bericht, b.GetID, datum);
        }

        public List<Persoon> GetLeden(string alph)
        {
            return db.GetLeden(alph);
        }

        public List<Bestuur> GetBestuursLeden()
        {
            return db.GetBestuursLeden();
        }

        public List<Reactie> GetReacties()
        {
            return db.GetReacties();
        }

        public List<Sticky_Note> GetSticky_Notes()
        {
            List<Sticky_Note> stickies = new List<Sticky_Note>();
            List<Reactie> reacties = new List<Reactie>();

            stickies = db.GetStickyNotes();
            reacties = GetReacties();
            KoppelBestuurAanSticky_Note(stickies, GetBestuursLeden());
            KoppelBestuurAanReactie(reacties, GetBestuursLeden());
            KoppelReactiesAanSticky_Note(stickies, reacties);
            return stickies;
        }

        public List<Reactie> KoppelBestuurAanReactie(List<Reactie> reactie, List<Bestuur> bestuur)
        {
            List<Reactie> reacties = new List<Reactie>();
            foreach (Reactie r in reactie)
            {
                foreach (Bestuur b in bestuur)
                {
                    if (r.BestuursID == b.GetID)
                    {
                        r.AddBestuur(b);
                        reacties.Add(r);
                    }
                }
            }
            return reacties;
        }

        public List<Sticky_Note> KoppelReactiesAanSticky_Note(List<Sticky_Note> sn, List<Reactie> reacties)
        {
            List<Sticky_Note> stickynotes = new List<Sticky_Note>();
            foreach (Sticky_Note s in sn)
            {
                foreach (Reactie r in reacties)
                {
                    if (s.GetID==r.Sticky_NoteID)
                    {
                        s.AddReactie(r);
                        stickynotes.Add(s);
                    }
                }
            }
            return stickynotes;
        }

        public List<Sticky_Note> KoppelBestuurAanSticky_Note(List<Sticky_Note> sn, List<Bestuur> bestuur)
        {
            List<Sticky_Note> stickynotes = new List<Sticky_Note>();
            foreach (Sticky_Note s in sn)
            {
                foreach (Bestuur b in bestuur)
                {
                    if (s.BestuursID == b.GetID)
                    {
                        s.AddBestuur(b);
                        stickynotes.Add(s);
                    }
                }
            }
            return stickynotes;
        }

    }
}