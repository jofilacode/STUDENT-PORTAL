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
                getData();
            }
           
        }
        else
        {
            Response.Redirect("../auth/secure_login.aspx");
        }
        
    }

    void getData()
    {
        pinData.DataSource = pci.get_pins();
        pinData.DataBind();
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

    protected void savepin(object sender, EventArgs e)
    {
        if (pin_no.Text == "")
        {
            alert_false("Specify the no of pins to generate");
        }
        else if (pin_no.SelectedIndex == 0)
        {
            alert_false("Select the number of pins to generate");
        }
        else
        {
            int x = int.Parse(pin_no.Text);

            for (int i = 1; i <= x; i++)
            {
                pci.save_pin(pci.generate_Pin(), "0");
            }
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                pin_no.SelectedIndex = 0;
                getData();
            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
   
}