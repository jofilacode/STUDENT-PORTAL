using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contact : System.Web.UI.Page
{
    account_api pci = new account_api();
    protected void Page_Load(object sender, EventArgs e)
    {

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


    protected void savecontact(object sender, EventArgs e)
    {
        double k;
        if (fullname.Value == "" || email.Value == "" || mobile.Value == "" || description.Value == "")
        {
            alert_false("All fields are required!");
        }
        else if (email.Value.Contains("@") == false || email.Value.Contains(".com") == false)
        {
            alert_false("invalid Email Address");
        }
        else if (double.TryParse(mobile.Value, out k) == false)
        {
            alert_false("Invalid Mobile number - enter number");
        }
        else if (mobile.Value.Length < 11 || mobile.Value.Length > 11)
        {
            alert_false("Incomplete Mobile Number (e.g 08132571643)");
        }

        else
        {
            pci.new_request(fullname.Value, email.Value, mobile.Value, description.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                fullname.Value = "";
                email.Value = "";
                mobile.Value = "";
                description.Value = "";
                fullname.Focus();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
}