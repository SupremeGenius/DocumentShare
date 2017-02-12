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
        if(Page.IsPostBack==false )
        {
            nsdoc.clsprf obj = new nsdoc.clsprf();
       List<nsdoc.clsprfprp> k = obj.find_rec(Convert.ToInt32(Session["cod"]));
            if(k.Count>0)
            {
                TextBox1.Text = k[0].prfdob.ToString();
                TextBox2.Text = k[0].prfdsc;
                RadioButtonList1.SelectedIndex = -1;
 RadioButtonList1.Items.FindByValue(k[0].prfgnd.ToString()).Selected = true;
                DropDownList1.SelectedIndex = -1;
                DropDownList1.Items.FindByValue(k[0].prfloc).Selected = true;
                ViewState["pic"] = k[0].prfpic;
                ViewState["cod"] = k[0].prfcod;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsprf obj = new nsdoc.clsprf();
        nsdoc.clsprfprp objprp = new nsdoc.clsprfprp();
        objprp.prfloc = DropDownList1.SelectedValue;
        objprp.prfusrcod = Convert.ToInt32(Session["cod"]);
        objprp.prfgnd = Convert.ToChar(RadioButtonList1.SelectedValue);
        objprp.prfdsc = TextBox2.Text;
        objprp.prfdob = TextBox1.Text;
        String pic = FileUpload1.PostedFile.FileName;
        if(pic!="")
        {
            pic = pic.Substring(pic.LastIndexOf('.'));
        }
        objprp.prfpic = pic;
        if (ViewState["cod"] == null)
            obj.Save_Rec(objprp);
        else
        {
            objprp.prfcod = Convert.ToInt32(ViewState["cod"]);
            if (pic == "")
                objprp.prfpic = ViewState["pic"].ToString();
            obj.update_rec(objprp);
        }
        if (pic != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../prfpic") + "//" +
                Session["cod"].ToString() + pic);
    }
}