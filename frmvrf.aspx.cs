using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack ==false )
        {
            nsdoc.clsusr obj = new nsdoc.clsusr();
            Int32 a = obj.vrfusr(Request.QueryString["eml"]);
            if (a == -1)
                Label1.Text = "Email ID not verified";
            else
            {
                Label1.Text = "Email Verification completed.";
                nsdoc.clslst obj1 = new nsdoc.clslst();
                nsdoc.clslstprp objprp1 = new nsdoc.clslstprp();
                objprp1.lstcrtdat = DateTime.Now;
                objprp1.lstnam = "Root";
                List<nsdoc.clsusrprp> k = obj.Find_Rec(Request.QueryString["eml"]);
                objprp1.lstusrcod = k[0].usrcod;
                obj1.Save_Rec(objprp1);
            }
        }
    }
}