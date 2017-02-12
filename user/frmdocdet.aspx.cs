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
        if(Page.IsPostBack ==false )
        {
            nsdoc.clsdoc obj = new nsdoc.clsdoc();
     List<nsdoc.clsdocprp> k = obj.find_rec(Convert.ToInt32(Request.QueryString["dcod"]));
            Label1.Text = k[0].doctit;
            Label2.Text = k[0].docupldat.ToShortDateString();
            //Label3.Text = "share data";
            Label4.Text = k[0].docdsc;
            if (k[0].docforsalsts == 'T')
                Label5.Text = "Document on sale for Rs." + k[0].docprc.ToString();
            String path = "../docfil" + "//" + k[0].doccod.ToString() + k[0].docfil;
            Session["path"] = path;
            nsdoc.clslst obj1 = new nsdoc.clslst();
            List<nsdoc.clslstprp> k1 = obj1.find_rec(k[0].doclstcod);
            if (k1[0].lstusrcod != Convert.ToInt32(Session["cod"]))
                LinkButton1.Visible = false;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmshr.aspx?dcod=" + Request.QueryString["dcod"]);
    }
}