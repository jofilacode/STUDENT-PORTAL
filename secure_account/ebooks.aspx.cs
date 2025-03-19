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
        if (Session["access"] != null)
        {
            if (!IsPostBack)
            {
                getData();
            }

        }
        else
        {
            Response.Redirect("../login.aspx");
        }
        
    }

    void getData()
    {
        string student_class = pci.get_class(Session["regno"].ToString());
        Repeater1.DataSource = my_ebook.get_ebooks("e-Books", student_class, true);
        Repeater1.DataBind();

        Repeater2.DataSource = my_ebook.get_ebooks("Forms/Special File", student_class, true);
        Repeater2.DataBind();
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

    void download_file(string filename)
    {
        Response.Redirect(filename);
    }

   

    protected void search_file(object sender, EventArgs e)
    {
        if (searchbookname.Value == "")
        {
            alert_false("Enter ebook-name to be searched for");
        }
        else
        {
            string student_class = pci.get_class(Session["regno"].ToString());
            Repeater1.DataSource = my_ebook.get_ebooks(searchbookname.Value, student_class);
            Repeater1.DataBind();
            alert_true("Operation Completed...");
        }
    }

    protected void all_file(object sender, EventArgs e)
    {
        string student_class = pci.get_class(Session["regno"].ToString());
        Repeater1.DataSource = my_ebook.get_ebooks("e-Books", student_class, true);
        Repeater1.DataBind();
        alert_true("Operation Completed...");

    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "download")
        {
            string filename = e.CommandArgument.ToString();
            string path = MapPath("../admin_dash/home/" +filename);
            byte[] bts = System.IO.File.ReadAllBytes(path);
            Response.Clear();
            Response.ClearHeaders();
            Response.AddHeader("Content-Type", "Application/octet-stream");
            Response.AddHeader("Content-Length", bts.Length.ToString());
            Response.AddHeader("Content-Disposition", "attachment; filename=" +
            filename);
            Response.BinaryWrite(bts);
            Response.Flush();
        }
    }

   
}