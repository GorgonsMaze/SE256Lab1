﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_IArsenault_Lab1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Makes password input entry hidden from plain view
            txtPassword.Attributes["type"] = "password";

            //btnSignIn.Attributes["type"] = "submit";
        }
    }
}