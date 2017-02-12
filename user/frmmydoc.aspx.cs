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
        if(Page.IsPostBack ==false)
        {
            nsdoc.clsdoc obj = new nsdoc.clsdoc();
            GridView1.DataSource = obj.dspmydoc(Convert.ToInt32(Session["cod"]), 0);
            GridView1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        nsdoc.clsdoc obj = new nsdoc.clsdoc();
        GridView1.DataSource = obj.dspmydoc(Convert.ToInt32(Session["cod"]),
            Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]));
        GridView1.DataBind();
    }
}