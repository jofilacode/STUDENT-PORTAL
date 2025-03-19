using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    account_api pci = new account_api();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["access"] = null;
        Session["admin"] = null;
        Session["regno"] = null;
        Session["package"] = null;
        Session["fullname"] = null;
        Session["email"] = null;
        Session["mobile"] = null;
    
    }

    protected void login_student(object sender, EventArgs e)
    {
        if (username.Value == "" || password.Value == "")
        {
            alert_false("Specify your username and password!");
        }
        else if (pci.login(username.Value, password.Value) == true)
        {
            Session["access"] = "1";
            Session["username"] = username.Value;
            pci.get_update(Session["username"].ToString());
            pci.get_update2(pci.g_regno);
            Session["regno"] = pci.g_regno;
            Session["fullname"] = pci.g_fullname;
            Session["email"] = pci.g_email;
            Session["mobile"] = pci.g_mobile;
            Session["package"] = pci.g_package;
            Response.Redirect("secure_account/home.aspx");

        }
        else
        {
            alert_false(pci.status);
        }
    }

    void alert_true(string info)
    {

        msg.InnerText = info;
        msg.Style.Add("color", "#16a085");
        msg.Style.Add("background-color", "#d0ece7");
        msg.Style.Add("display", "block");
    }

    void alert_false(string info)
    {
        msg.InnerText = info;
        msg.Style.Add("color", "#ec7063");
        msg.Style.Add("background-color", "#fadbd8");
        msg.Style.Add("display", "block");
    }
}