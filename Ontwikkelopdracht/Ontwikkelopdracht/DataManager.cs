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

        public bool NieuweStickyNote(string titel, string bericht, Bestuur b, DateTime datum)
        {
            bool done = false;
            if(db.AddStickyNote(titel, bericht, b.GetID, datum))
            {
                done = true;
            }
            else
            {
                done = false;
            }
            return done;
        }

        public bool NieuweReactie(int parent, Sticky_Note sn, string bericht, Bestuur b, DateTime datum)
        {
            bool done = false;
            if(db.AddReactie(parent, sn.GetID, bericht, b.GetID, datum))
            {
                done = true;
            }
            else
            {
                done = false;
            }
            return done;
        }

        public bool NieuwLid(string naam, string achternaam, DateTime datum_geregistreerd, string email, DateTime geboortedatum, char geslacht, bool isbestuur)
        {
            bool done = false;
            if(db.AddLid(naam, achternaam, datum_geregistreerd, email, geboortedatum, geslacht, isbestuur))
            {
                done = true;
            }
            else            {
                done = false;
            }
            return done;
        }

        public List<Persoon> GetLeden(string alph)
        {
            return db.GetLeden(alph);
        }

        public List<Item> GetItems(string categorie)
        {
            List<Item> items = new List<Item>();
            if (categorie == "dranken")
            {
                items = db.GetItems(1);
            }
            else if (categorie == "snacks")
            {
                items = db.GetItems(2);
            }
            return items;
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