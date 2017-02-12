using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsusr obj = new nsdoc.clsusr();
        nsdoc.clsusrprp objprp = new nsdoc.clsusrprp();
        objprp.usrnam = txtnam.Text;
        objprp.usreml = txteml.Text;
        objprp.usrpwd = txtpwd.Text;
        objprp.usrregdat = DateTime.Now;
        objprp.usrsecqst = drpqst.SelectedItem.Text;
        objprp.usrsecans = txtans.Text;
        objprp.usrsts = 'V';
        try
        {
            obj.Save_Rec(objprp);
            /*
            string bdy = "Please click the link below to verify your EmailID.";
            bdy += "<br><a href=frmvrf.aspx?eml=" + txteml.Text + " >Click Here</a>";
            MailMessage mm = new MailMessage("cssoft@sify.com", txteml.Text,
                "Confirmation Mail", bdy);
            mm.IsBodyHtml = true;
            SmtpClient c = new SmtpClient("mail.connectzone.in", 25);
            c.Send(mm);
            */
            Label1.Text = "Registration Successful.Verification mail has been sent on your Email ID";
            txtans.Text = String.Empty;
            txtnam.Text = String.Empty;
            txteml.Text = String.Empty;
        }
        catch(Exception exp)
        {
            //Label1.Text = "Email ID already registered.";
            Label1.Text = exp.Message;
        }
    }
}