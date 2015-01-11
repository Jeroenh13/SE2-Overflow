using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ontwikkelopdracht
{
    public partial class Prijslijst : System.Web.UI.Page
    {
        private DataManager dm = new DataManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVprijslijstDrank.DataSource = dm.GetItems("dranken");
                GVprijslijstDrank.DataBind();
                GVprijslijstSnacks.DataSource = dm.GetItems("snacks");
                GVprijslijstSnacks.DataBind();
            }
        }
    }
}