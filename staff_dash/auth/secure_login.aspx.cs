using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class auth_secure_login : System.Web.UI.Page
{
    account_api pci = new account_api();
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
        else if (pci.staff_login(username.Value, password.Value) == true)
        {
            Session["staff"] = "1";
            Session["name"] = pci.g_staff_name;
            Response.Redirect("../home/home.aspx");
        }
        else
        {
            alert_false(pci.status);
        }
    }
}