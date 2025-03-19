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
    Library_Api my_ebook = new Library_Api();
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
        GridView1.DataSource = my_ebook.get_ebooks_admin();
        GridView1.DataBind();
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


    protected void uploadnow(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            FileUpload1.SaveAs(Server.MapPath("upload_docs/ebook/" + FileUpload1.PostedFile.FileName));
            fileName.Value = "upload_docs/ebook/" + FileUpload1.PostedFile.FileName;
            alert_true("file Uploaded - Proceed to submit file");
        }
        else
        {
            fileName.Value = "";
            alert_false("No file browsed yet");
        }
    }

    protected void search_all(object sender, EventArgs e)
    {

        getData();
        alert_true("successful!");
    }
    protected void search_file(object sender, EventArgs e)
    {
        if (searchtxt.Value == "")
        {
            alert_false("No filename specified to search for");
        }
        else
        {

            GridView1.DataSource = my_ebook.get_ebooks_admin(searchtxt.Value);
            GridView1.DataBind();
            if (my_ebook.exe == 1)
            {
                alert_true(my_ebook.msg());
            }
            else
            {
                alert_false(my_ebook.msg());
            }
        }
    }

    protected void switchdel(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            GridView1.Columns[0].Visible = true;
        }
        else
        {
            GridView1.Columns[0].Visible = false;
        }
    }

    protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "removefile") return;
        int id = Convert.ToInt32(e.CommandArgument);
        my_ebook.delete_ebook(id.ToString());
        if (my_ebook.exe == 1)
        {
            alert_true(my_ebook.msg());
        }
        else
        {
            alert_false(my_ebook.msg());
        }
        getData();
    }

    protected void uploadbooks(object sender, EventArgs e)
    {
        if (fileOption.SelectedIndex == 0 || studentClass.SelectedIndex == 0 || fileName.Value == "")
        {
            alert_false("All fields are required");
        }
        else
        {
            my_ebook.new_ebook(uploadfilename.Value, fileOption.Text, studentClass.Text, fileName.Value);
            if (my_ebook.exe == 1)
            {
                alert_true(my_ebook.msg());
                fileOption.SelectedIndex = 0;
                studentClass.SelectedIndex = 0;
            }
            else
            {
                alert_false(my_ebook.msg());
            }
        }

        getData();
    }

   
}