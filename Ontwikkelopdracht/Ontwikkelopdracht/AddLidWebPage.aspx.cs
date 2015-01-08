using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ontwikkelopdracht
{
    public partial class AddLidWebPage : System.Web.UI.Page
    {
        DataManager dm = new DataManager();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (dm.NieuwLid(tbVoornaam.Text, tbAchternaam.Text, Convert.ToDateTime(tbGeregistreerd.Text, new CultureInfo("en-GB")), tbEmail.Text, Convert.ToDateTime(tbGeboortedatum.Text, new CultureInfo("en-GB")), Convert.ToChar(ddlGeslacht.SelectedValue), false))
            {

            }
        }
    }
}