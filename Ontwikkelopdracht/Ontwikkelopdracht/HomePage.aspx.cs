using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace Ontwikkelopdracht
{
    public partial class HomePage : System.Web.UI.Page
    {
        public DataManager dm = new DataManager();
        List<Sticky_Note> snList = new List<Sticky_Note>(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            snList = dm.GetSticky_Notes();
            if (!IsPostBack)
            {
                snList = dm.GetSticky_Notes();
                lvStickynotes.DataSource = snList;
                lvStickynotes.DataBind();
            }
        }

        protected void btnLedenInfo_Click(object sender, EventArgs e)
        {

        }

        protected void btnNieuwLid_Click(object sender, EventArgs e)
        {

        }

        protected void btnPrijsLijst_Click(object sender, EventArgs e)
        {

        }

        protected void btnEvent_Click(object sender, EventArgs e)
        {

        }

        protected void lvStickynotes_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
        }

        protected void lvStickynotes_OnItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Sticky_Note stickynote;
            if (e.CommandName == "Select")
            {
                Label lbl = (Label)e.Item.FindControl("ID");
                foreach (Sticky_Note sn in snList)
                {
                    if (sn.GetID == Convert.ToInt32(e.CommandArgument))
                    {
                        Session["STICKY_NOTE"] = sn;
                    }
                }
                Response.Redirect("Sticky_NoteForm.aspx");
            }
        }
    }
    
}