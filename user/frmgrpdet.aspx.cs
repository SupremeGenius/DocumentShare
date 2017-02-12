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
            nsdoc.clsgrp obj = new nsdoc.clsgrp();
            List<nsdoc.clsgrpprp> k = obj.find_rec
                (Convert.ToInt32(Request.QueryString["gcod"]));
            if (k[0].grpownusrcod == Convert.ToInt32(Session["cod"]))
                Panel1.Visible = true;
            else
                Panel1.Visible = false;
        }
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public String getnam(Int32 usrcod)
    {
        nsdoc.clsusr obj = new nsdoc.clsusr();
        List<nsdoc.clsusrprp> k = obj.Find_info(usrcod);
        return k[0].usrnam;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsusr obj = new nsdoc.clsusr();
        GridView1.DataSource = obj.srcusr(TextBox1.Text, Convert
            .ToInt32(Request.QueryString["gcod"]));
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType==DataControlRowType.DataRow)
        {
            LinkButton lk1 = (LinkButton)(e.Row.FindControl("lk1"));
            Int32 sts = Convert.ToInt32(GridView1.
                                    DataKeys[e.Row.RowIndex][1]);
            if (sts == 0)
                lk1.Visible = true;
            else
                lk1.Visible = false;
        }
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        nsdoc.clsgrpmem obj = new nsdoc.clsgrpmem();
        nsdoc.clsgrpmemprp objprp = new nsdoc.clsgrpmemprp();
    objprp.grpmemgrpcod = Convert.ToInt32(Request.QueryString["gcod"]);
        objprp.grpmemusrcod = Convert.ToInt32(GridView1.DataKeys
            [e.NewEditIndex][0]);
        objprp.grpmemjondat = DateTime.Now;
        obj.Save_Rec(objprp);
        TextBox1.Text = String.Empty;
        nsdoc.clsusr obj1 = new nsdoc.clsusr();
        GridView1.DataSource = obj1.srcusr(TextBox1.Text, Convert
            .ToInt32(Request.QueryString["gcod"]));
        GridView1.DataBind();
        DataList2.DataBind();
    }

    protected void DataList2_EditCommand(object source, DataListCommandEventArgs e)
    {
        nsdoc.clsgrpmem obj = new nsdoc.clsgrpmem();
        nsdoc.clsgrpmemprp objprp = new nsdoc.clsgrpmemprp();
        objprp.grpmemcod = Convert.ToInt32(DataList2.DataKeys
            [e.Item.ItemIndex]);
        obj.delete_Rec(objprp);
        DataList2.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        nsdoc.clspst obj = new nsdoc.clspst();
        nsdoc.clspstprp objprp = new nsdoc.clspstprp();
        objprp.pstdat = DateTime.Now;
        objprp.pstdsc = TextBox2.Text;
        objprp.pstgrpcod = Convert.ToInt32(Request.QueryString["gcod"]);
        objprp.pstusrcod = Convert.ToInt32(Session["cod"]);
        obj.Save_Rec(objprp);
        TextBox2.Text = String.Empty;
        GridView2.DataBind();
    }
}