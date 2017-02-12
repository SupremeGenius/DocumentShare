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
            if(Request.QueryString["dcod"]!=null )
            {
                nsdoc.clsdoc obj = new nsdoc.clsdoc();
                List<nsdoc.clsdocprp> k = obj.find_rec(
                    Convert.ToInt32(Request.QueryString["dcod"]));
                Label1.Text = k[0].doctit;
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsshr obj = new nsdoc.clsshr();
        nsdoc.clsshrprp objprp = new nsdoc.clsshrprp();
        objprp.shrdat = DateTime.Now;
        objprp.shrdoc = Convert.ToInt32(Request.QueryString["dcod"]);
        if (RadioButtonList1.SelectedIndex == 0)
            objprp.shrgrpcod = -1;
        else
            objprp.shrgrpcod = Convert.ToInt32(DropDownList1.
                SelectedValue);
     objprp.shrtyp = Convert.ToChar(RadioButtonList1.SelectedValue);
        objprp.shrrgt = 'R';
        if (RadioButtonList1.SelectedIndex == 1)
            objprp.shrusrcod = -1;
        else
        {
            nsdoc.clsusr obj1 = new nsdoc.clsusr();
            Int32 a = obj1.srcusrs(TextBox1.Text, Convert.ToInt32
                (Request.QueryString["dcod"]));
            if (a == 0)
                Label4.Text = "Email ID does not exist.";
            else if (a == -1)
                Label4.Text = "Document already shared.";
            else
                objprp.shrusrcod = a;
        }
        if (Label4.Text == String.Empty)
            obj.Save_Rec(objprp);
        GridView1.DataBind();
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(RadioButtonList1.SelectedIndex==0)
        {
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button1.Visible = true;
            Label3.Visible = false;
            DropDownList1.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            TextBox1.Visible = false;
            Button1.Visible = true;
            Label3.Visible = true;
            DropDownList1.Visible = true;
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsdoc.clsshr obj = new nsdoc.clsshr();
        nsdoc.clsshrprp objprp = new nsdoc.clsshrprp();
        objprp.shrcod = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex][0]);
        obj.del_Rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}