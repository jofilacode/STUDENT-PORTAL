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
        tutorname.DataSource = pci.get_tutorsName();
        tutorname.DataTextField = "tutor_name";
        tutorname.DataBind();
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

    protected void UploadDoc(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("../admin_dash/home/upload_docs/submission/" + FileUpload1.PostedFile.FileName));
            filename.Value = FileUpload1.PostedFile.FileName;
            filepath.Value = "../admin_dash/home/upload_docs/submission/" + FileUpload1.PostedFile.FileName;
            int size = FileUpload1.PostedFile.ContentLength;
            filesize.Value = size.ToString() + "kb";
            alert_true("file uploaded successfully");
        }
        else
        {
            alert_false("Browse or Select a file before upload");
        }
    }

    protected void saveupload(object sender, EventArgs e)
    {
        if (tutorname.Text == "" || uploadtype.SelectedIndex == 0 || description.Value == "")
        {
            alert_false("All fields are required!");
        }
        else if (filename.Value == "" || filepath.Value == "" || filesize.Value == "")
        {
            alert_false("Upload the file before submission!");
        }
        else
        {
            pci.new_student_uploads(Session["fullname"].ToString(), tutorname.Text, uploadtype.Text, description.Value, filename.Value, filepath.Value, filesize.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                uploadtype.SelectedIndex = 0;
                description.Value = "";


            }
            else
            {
                alert_false(pci.status);
            }
        }
    }
   
}