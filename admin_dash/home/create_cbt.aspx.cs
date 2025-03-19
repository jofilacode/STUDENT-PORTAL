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
        cbtData.DataSource = pci.get_cbt_data();
        cbtData.DataBind();

        course2.DataSource = pci.get_course();
        course2.DataTextField = "package";
        course2.DataBind();

        pci.fetch_cbt_settings(course2.Text);
        if (pci.exe == 1)
        {
          
            cbt_control.Text = pci.xcbt_status;
            cbt_mark.Value = pci.xcbt_mark;
            cbt_time.Value = pci.xcbt_time;
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


    protected void save_cbt(object sender, EventArgs e)
    {
        if (course.SelectedIndex == 0 || question.Value == "" || option_a.Value == "" || option_b.Value == "" || option_c.Value == "" || answer.Value == "")
        {
            alert_false("All fields are required!");
        }
        else
        {
            pci.new_cbt(course.Text, question.Value, option_a.Value, option_b.Value, option_c.Value, answer.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                course.SelectedIndex = 0;
                question.Value = "";
                option_a.Value = "";
                option_b.Value = "";
                option_c.Value = "";
                answer.Value = "";

                getData();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }


    protected void course2_SelectedIndexChanged(object sender, EventArgs e)
    {
        pci.fetch_cbt_settings(course2.Text);
        if(pci.exe==1)
        {
           
            cbt_control.Text = pci.xcbt_status;
            cbt_mark.Value = pci.xcbt_mark;
            cbt_time.Value = pci.xcbt_time;
        }
       
       
    }
    protected void updatebtn_Click(object sender, EventArgs e)
    {
        if(cbt_control.SelectedIndex==0 || cbt_mark.Value=="" || cbt_time.Value=="")
        {
            alert_false("Please specify Cbt control, time and mark accurately!");
        }
        else
        {
            pci.update_cbt_settings(cbt_control.Text, cbt_mark.Value, cbt_time.Value,course2.Text);
            if(pci.exe==1)
            {
                alert_true(pci.msg());
                getData();
            }
            else
            {
                alert_false(pci.msg());
            }
        }
    }
    protected void cbtData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "deletequestion") return;
        string id = e.CommandArgument.ToString();
        pci.delete_cbt_questions(id.ToString());
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
}