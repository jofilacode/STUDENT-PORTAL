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
        recordData.DataSource = pci.get_record();
        recordData.DataBind();

        paymentData.DataSource = pci.get_payment();
        paymentData.DataBind();

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
            alert_false("Specify package to search for");
        }
        else
        {
            paymentData.DataSource = pci.get_payment(searchbox.Value);
            paymentData.DataBind();
        }
    }


   
}