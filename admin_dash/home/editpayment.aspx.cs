﻿using System;
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

    protected void search(object sender, EventArgs e)
    {
        if (searchbox.Value == "")
        {
            alert_false("Specify Reg-No");
        }
        else
        {
            pci.search_payment(searchbox.Value);
            if (pci.exe == 1)
            {
                package.Text = pci.p_package;
                duration.Text = pci.p_duration;
                amount.Value = pci.p_amount;
                balance.Value = pci.p_balance;
                paystatus.Text = pci.p_paystatus;
                alert_true(pci.status);

            }
            else
            {
                alert_false(pci.status);
            }

        }
    }

    protected void update(object sender, EventArgs e)
    {
        if (searchbox.Value == "")
        {
            alert_false("Specify Reg-No");
        }
        else
        {
            pci.update_payment(package.Text, duration.Text, amount.Value, balance.Value, paystatus.Text, searchbox.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                package.SelectedIndex = 0;
                duration.SelectedIndex = 0;
                amount.Value = "";
                balance.Value = "";
                paystatus.SelectedIndex = 0;

            }
            else
            {
                alert_false(pci.status);
            }

        }
    }

    protected void delete(object sender, EventArgs e)
    {
        if (searchbox.Value == "")
        {
            alert_false("Specify Reg-No");
        }
        else
        {
            pci.delete_payment(searchbox.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                package.SelectedIndex = 0;
                duration.SelectedIndex = 0;
                amount.Value = "";
                balance.Value = "";
                paystatus.SelectedIndex = 0;


            }
            else
            {
                alert_false(pci.status);
            }

        }
    }
   
}