using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsgrp obj = new nsdoc.clsgrp();
        nsdoc.clsgrpprp objprp = new nsdoc.clsgrpprp();
        objprp.grpcrtdat = DateTime.Now;
        objprp.grpnam = TextBox1.Text;
        objprp.grpdsc = TextBox2.Text;
        objprp.grpownusrcod = Convert.ToInt32(Session["cod"]);
        obj.Save_Rec(objprp);
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        GridView1.DataBind();
    }
}