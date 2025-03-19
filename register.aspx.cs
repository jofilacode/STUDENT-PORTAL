using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
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

    protected void saveRecord(object sender, EventArgs e)
    {
        double k;
        if (regno.Value == "" || pincode.Value == "" || fullname.Value == "" || email.Value == "" || mobile.Value == "" || address.Value == "" || age.Value == "" || gender.SelectedIndex == 0 || username.Value == "" || password.Value == "" || confirmpassword.Value == "")
        {
            alert_false("All fields are required!");
        }

        else if (regno.Value != pci.regno_check(regno.Value))
        {
            alert_false("Invalid Registration Number!");
        }
        else if (pci.pin_verify(pincode.Value) == false)
        {
            alert_false("Invalid Pin Code/Pin code do not exist");
        }
        else if (pincode.Value != pci.pin_check(regno.Value))
        {
            alert_false("The Pin-code specify is not linked to your account - contact admin!");
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

        else if (double.TryParse(age.Value, out k) == false)
        {
            alert_false("Invalid age - enter number (e.g 20)");
        }
        else if (confirmpassword.Value != password.Value)
        {
            alert_false("Password Mismatch!");
        }
        else
        {
            pci.save_account(regno.Value, pincode.Value, fullname.Value, email.Value, mobile.Value, address.Value, age.Value, gender.Text, username.Value, password.Value);

            if (pci.exe == 1)
            {
                alert_true(pci.status + " to access your portal");
                regno.Value = "";
                pincode.Value = "";
                fullname.Value = "";
                email.Value = "";
                mobile.Value = "";
                address.Value = "";
                age.Value = "";
                gender.SelectedIndex = 0;
                username.Value = "";
                password.Value = "";
                confirmpassword.Value = "";
                regno.Focus();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
}