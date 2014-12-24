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
    public partial class LedenWebPage : System.Web.UI.Page
    {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
                     "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                     "W", "X", "Y", "Z", "ALL"};

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["SelectedAlphabet"] = "ALL";
                rptAlphabet.DataSource = alphabet;
                rptAlphabet.DataBind();
                bindGridview();
            }
        }

        private void bindGridview()
        {
            GVleden.DataSource = Database.GetLeden((string)Session["SelectedAlphabet"]);
            GVleden.DataBind();
        }

        protected void rptAlphabet_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Alphabet")
            {
                LinkButton lnkbtn = e.CommandSource as LinkButton;

                Session["SelectedAlphabet"] = lnkbtn.Text;

                bindGridview();
            }
        }
    }

}