using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class auth_secure_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["admin"] = null;
    }


    void alert_true(string message)
    {
        msg.InnerText = message;
        msg.Style.Add("background-color", "#d1f2eb");
        msg.Style.Add("color", " #148f77");
        msg.Style.Add("display", "block");

    }

    void alert_false(string message)
    {
        msg.InnerText = message;
        msg.Style.Add("background-color", " #fdedec");
        msg.Style.Add("color", " #cd6155");
        msg.Style.Add("display", "block");
    }
    protected void login_admin(object sender, EventArgs e)
    {
        if(username.Value =="" || password.Value =="")
        {
            alert_false("Enter username and password");
        }
        else if (username.Value == "admin_nimda@2018" && password.Value == "pci_secure@2018")
        {
            Session["admin"] = "1";
            Response.Redirect("../home/home.aspx");
        }
        else
        {
            alert_false("Invalid username or Password please verify.");
            Session["admin"] = null;
        }
    }
}