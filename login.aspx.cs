using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsdoc.clsusr obj = new nsdoc.clsusr();
        Int32 a = obj.logincheck(TextBox1.Text, TextBox2.Text);
        if (a == -1)
            Label1.Text = "Email Password Incorrect";
        else
        {
   FormsAuthenticationTicket tk = new FormsAuthenticationTicket(
                TextBox1.Text, false,300);
            String s = FormsAuthentication.Encrypt(tk);
  HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName
                            , s);
            Response.Cookies.Add(ck);

            Session["cod"] = a;
            Response.Redirect("user/frmprf.aspx");

        }
    }
}