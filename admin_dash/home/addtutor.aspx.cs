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
        tutorData.DataSource = pci.get_tutors();
        tutorData.DataBind();
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

    protected void savetutor(object sender, EventArgs e)
    {
        if (tutorname.Value == "" || coursetaken.Value == "" || package.SelectedIndex == 0 || contactno.Value == "")
        {
            alert_false("All fields are required!");
        }
        else
        {
            pci.new_tutor(tutorname.Value, coursetaken.Value, package.Text, "user" + pci.generateID(), "pass" + pci.generateID(), contactno.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                tutorname.Value = "";
                coursetaken.Value = "";
                package.SelectedIndex = 0;
                contactno.Value = "";
                tutorname.Focus();

                getData();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
   
}