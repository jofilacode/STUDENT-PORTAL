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
    protected void search(object sender, EventArgs e)
    {
        if (searchbox.Value == "")
        {
            alert_false("Specify ID");
        }
        else
        {
            pci.search_tutor(searchbox.Value);
            if (pci.exe == 1)
            {
                tutorname.Value = pci.t_tutor_name;
                coursetaken.Value = pci.t_course_taken;
                package.Text = pci.t_package;
                contactno.Value = pci.t_contact_no;
                username.Value = pci.t_username;
                password.Value = pci.t_password;
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
            alert_false("Specify ID");
        }
        else
        {
            pci.update_tutor(tutorname.Value, coursetaken.Value, package.Text, contactno.Value, username.Value, password.Value, searchbox.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                tutorname.Value = "";
                coursetaken.Value = "";
                package.SelectedIndex = 0;
                contactno.Value = "";
                username.Value = "";
                password.Value = "";
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
            alert_false("Specify ID");
        }
        else
        {
            pci.delete_tutor(searchbox.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                tutorname.Value = "";
                coursetaken.Value = "";
                package.SelectedIndex = 0;
                contactno.Value = "";
                username.Value = "";
                password.Value = "";


            }
            else
            {
                alert_false(pci.status);
            }

        }
    }

   
}