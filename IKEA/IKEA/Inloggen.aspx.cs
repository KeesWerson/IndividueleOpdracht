﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IKEA
{
    public partial class Inloggen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registreer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registreren.aspx");
        }
    }
}