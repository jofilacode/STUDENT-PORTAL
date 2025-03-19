using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class secure_account_home : System.Web.UI.Page
{
    account_api pci = new account_api();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["admin"]!= null)
        {
            if(!IsPostBack)
            {
                
            }
           
        }
        else
        {
            Response.Redirect("../auth/secure_login.aspx");
        }
        
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

    protected void create_payment(object sender, EventArgs e)
    {
        if (regno.Value == "" || package.SelectedIndex == 0 || duration.SelectedIndex == 0 || amount.Value == "" || balance.Value == "" || pincode.Value == "" || status.SelectedIndex == 0)
        {
            alert_false("All fields are required!");
        }
        else if (pci.pin_verify(pincode.Value) == false)
        {
            alert_false("Invalid Pin Code/Pin code do not exist");
        }
        else if (pci.pin_available(pincode.Value) == false)
        {
            alert_false("Pin Code have been used");
        }
        else
        {
            pci.new_payment(regno.Value, package.Text, duration.Text, amount.Value, balance.Value, pincode.Value, status.Text);
            if (pci.exe == 1)
            {
                pci.update_pin(pincode.Value);
                alert_true(pci.status);
                regno.Value = "";
                package.SelectedIndex = 0;
                duration.SelectedIndex = 0;
                amount.Value = "";
                balance.Value = "";
                pincode.Value = ""; status.SelectedIndex = 0;
                regno.Focus();
            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
   
}