﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace Ontwikkelopdracht
{
    public partial class InlogForm : System.Web.UI.Page
    {
        DataManager dm = new DataManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Bestuur b = null;
            try
            {
                b = dm.Login(tbUserName.Text, tbPassword.Text);
            }
            catch
            {
                lblError.Text = "Inlog gegevens incorrect";
            }
            finally
            {
                Session["Bestuur"] = b;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}