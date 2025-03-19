using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.IO;

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
        resultData.DataSource = pci.get_result();
        resultData.DataBind();

        cbtData.DataSource = pci.get_cbt_result_admin();
        cbtData.DataBind();

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



    protected void cbtData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "deletedata") return;
        string id = e.CommandArgument.ToString();
        pci.delete_cbt_result(id.ToString());
        if (pci.exe == 1)
        {
            alert_true(pci.msg());
        }
        else
        {
            alert_false(pci.msg());
        }
        getData();
    }

    protected void resultData_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete" && e.CommandArgument.ToString() != "")
        {

            try
            {
                File.Delete(Server.MapPath(pci.get_result_file_path(e.CommandArgument.ToString())));
                pci.delete_results(e.CommandArgument.ToString());
                if (pci.exe == 1)
                {
                    alert_true(pci.msg());
                    getData();
                }
                else
                {
                    alert_false(pci.msg());
                }

            }catch
            {

            }

        }
    }
            
               
       
}