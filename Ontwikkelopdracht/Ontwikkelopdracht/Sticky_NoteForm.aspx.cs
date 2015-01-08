using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Classes;
using TextBox = System.Web.UI.WebControls.TextBox;

namespace Ontwikkelopdracht
{
    public partial class Sticky_NoteForm : System.Web.UI.Page
    {
        DataManager dm = new DataManager();
        private List<Sticky_Note> sn = new List<Sticky_Note>();
        List<Reactie> parents = new List<Reactie>();
        List<Reactie> childs = new List<Reactie>();
        private bool refresh = false;

        protected void Page_Init(object sender, EventArgs e)
        {
            lvReacties.ItemCommand += new EventHandler<ListViewCommandEventArgs>(lvReacties_ItemCommand);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sn.Add((Sticky_Note)Session["STICKY_NOTE"]);
                BindReacties();
            }
            if (sn.Count == 0)
            {
                sn.Add((Sticky_Note)Session["STICKY_NOTE"]);
            }
        }

        public void BindReacties()
        {
            UpdateSession();
            sn[0] = (Sticky_Note)Session["STICKY_NOTE"];
            stickynote.DataSource = sn;
            stickynote.DataBind();
            foreach(Reactie r in sn[0].Reacties)
            {
                parents.Add(r);
            }
            lvReacties.DataSource = parents;
            lvReacties.DataBind();
        }

        protected void lvReacties_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Table tb = e.Item.FindControl("reactietabel") as Table;
            tb.Visible = false;
        }

        protected void AddReactie_Click(object sender, EventArgs e)
        {
            Sticky_Note sn = (Sticky_Note)Session["STICKY_NOTE"];
            Bestuur b = (Bestuur)Session["BESTUUR"];
            if (dm.NieuweReactie(0, sn, tbBericht.Text, b, DateTime.Now))
            {
                MessageBox.Show("Reactie is toegevoegd");
                BindReacties();
            }
            else
            {
                FoutLabel.Text = "reactie niet geplaatst";
            }
        }

        protected void lvReacties_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Reageer")
            {
                Table tb = e.Item.FindControl("reactietabel") as Table;
                tb.Visible = true;
            }
            else if (e.CommandName == "Post")
            {
                Table tb1 = e.Item.FindControl("reactietabel") as Table;
                Sticky_Note sn = (Sticky_Note)Session["STICKY_NOTE"];
                Bestuur b = (Bestuur)Session["BESTUUR"];
                TextBox tb = e.Item.FindControl("tbBericht") as TextBox;
                if (dm.NieuweReactie(Convert.ToInt32(e.CommandArgument), sn, tb.Text, b, DateTime.Now))
                {
                    tb1.Visible = false;
                    UpdateSession();
                    MessageBox.Show("Reactie is toegevoegd");
                    BindReacties();
                }
                else
                {
                    FoutLabel.Text = "Reactie is niet geplaaatst";
                }
            }
        }

        public void UpdateSession()
        {
            foreach(Sticky_Note stn in dm.GetSticky_Notes())
            {
                if(stn.GetID == sn[0].GetID)
                {
                    Session["STICKY_NOTE"] = stn;
                }
            }
        }
    }
}