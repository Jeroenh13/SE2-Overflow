using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace Ontwikkelopdracht
{
    public partial class Leden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database.GetLeden();
        }
    }
}