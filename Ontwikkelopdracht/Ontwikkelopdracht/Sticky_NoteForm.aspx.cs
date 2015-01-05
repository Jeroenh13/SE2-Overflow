using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace Ontwikkelopdracht
{
    public partial class Sticky_NoteForm1 : System.Web.UI.Page
    {
        DataManager dm = new DataManager();
        private List<Sticky_Note> sn;
        List<Reactie> parents = new List<Reactie>();
        List<Reactie> childs = new List<Reactie>();
        private bool refresh = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            sn = new List<Sticky_Note>();
            if (Session["STICKY_NOTE"] == null)
            {
            }
            sn.Add((Sticky_Note)Session["STICKY_NOTE"]);
            BindReacties();
        }

        public void BindReacties()
        {
            refresh = false;
            ListView childview = lvReacties.FindControl("lvReactieChild") as ListView;
            stickynote.DataSource = sn;
            stickynote.DataBind();
            foreach (Reactie r in sn[0].Reacties)
            {
                if (r.ParentID == 0)
                {
                    parents.Add(r);
                }
            }
            lvReacties.DataSource = parents;
            lvReacties.DataBind();
        }

        protected void lvReacties_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (refresh == false)
            {
                ListView childview = e.Item.FindControl("lvReactieChild") as ListView;
                foreach (Reactie r in sn[0].Reacties)
                {
                    foreach (Reactie rparent in parents)
                    {
                        if (r.ParentID == rparent.GetID)
                        {

                            childs.Add(r);
                        }
                    }
                }
                childview.DataSource = childs;
                childview.DataBind();
                refresh = true;
            }
        }

        protected void AddReactie_Click(object sender, EventArgs e)
        {
            Sticky_Note sn = (Sticky_Note)Session["STICKY_NOTE"];
            Bestuur b = (Bestuur)Session["BESTUUR"];
            dm.NieuweReactie(sn,tbBericht.Text,b,DateTime.Now);
            BindReacties();
        }
    }
}