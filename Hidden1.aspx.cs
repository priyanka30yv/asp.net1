﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hidden1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(Page.IsPostBack)
        {
            TextBox1.Text = Hidden.Value;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Hidden.Value = TextBox1.Text;
    }
}