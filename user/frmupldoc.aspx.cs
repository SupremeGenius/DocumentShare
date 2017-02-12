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

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(RadioButtonList1.SelectedIndex==0)
        {
            Label1.Visible = true;
            TextBox3.Visible = true;
        }
        else
        {
            Label1.Visible = false;
            TextBox3.Visible = false;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        nsdoc.clslst obj = new nsdoc.clslst();
        nsdoc.clslstprp objprp = new nsdoc.clslstprp();
        objprp.lstnam = TextBox4.Text;
        objprp.lstcrtdat = DateTime.Now;
        objprp.lstusrcod = Convert.ToInt32(Session["cod"]);
        obj.Save_Rec(objprp);
        TextBox4.Text = String.Empty;
        DropDownList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsdoc obj = new nsdoc.clsdoc();
        nsdoc.clsdocprp objprp = new nsdoc.clsdocprp();
        objprp.doctit = TextBox1.Text;
        objprp.docdsc = TextBox2.Text;
        objprp.doclstcod = Convert.ToInt32(DropDownList1.SelectedValue);
        objprp.docupldat = DateTime.Now;
        if (RadioButtonList1.SelectedIndex == 0)
        {
            objprp.docforsalsts = 'T';
            objprp.docprc = Convert.ToSingle(TextBox3.Text);
        }
        else
        {
            objprp.docforsalsts = 'F';
            objprp.docprc = 0;
        }
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.docfil = s;
        Int32 a = obj.Save_Rec(objprp);
        if(s!="")
        {
      FileUpload1.PostedFile.SaveAs(Server.MapPath("../docfil") + "//" + a.ToString() + s);
        }
        Response.Redirect("frmmydoc.aspx");
    }
}