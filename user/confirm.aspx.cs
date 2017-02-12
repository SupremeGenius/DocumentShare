using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["amt"]!=null )
        {
            nsdoc.clspur obj = new nsdoc.clspur();
            nsdoc.clspurprp objprp = new nsdoc.clspurprp();
            objprp.purdat = DateTime.Now;
            objprp.purusrcod = Convert.ToInt32(Session["cod"]);
            objprp.purdoccod = Convert.ToInt32(Session["dcod"]);
            obj.Save_Rec(objprp);
            String eml = User.Identity.Name;
            MailMessage mm = new MailMessage("admin@docshare.com",
                eml, "Purchase Document", "Please find attached copy of your purchased document.");
            String fn = Server.MapPath("../docfil");
            nsdoc.clsdoc obj1 = new nsdoc.clsdoc();
            List<nsdoc.clsdocprp> k = obj1.find_rec
                                    (Convert.ToInt32(Session["dcod"]));
            fn += "//" + k[0].doccod + k[0].docfil;
            Attachment at = new Attachment(fn);
            mm.Attachments.Add(at);
            SmtpClient c = new SmtpClient("mail.connectzone.in", 25);
            c.Send(mm);
            Label1.Text = "Document has been sent on your registered email.";
            Session["dcod"] = null;
            Session["amt"] = null;
        }
    }
}