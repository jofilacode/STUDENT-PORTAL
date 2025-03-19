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

    protected void UploadDoc(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("upload_docs/result/" + FileUpload1.PostedFile.FileName));
            filename.Value = FileUpload1.PostedFile.FileName;
            filepath.Value = "upload_docs/result/" + FileUpload1.PostedFile.FileName;
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
        if (regno.Value == "" || description.Value == "")
        {
            alert_false("All fields are required!");
        }
        else if (filename.Value == "" || filepath.Value == "" || filesize.Value == "")
        {
            alert_false("Upload the file before submission!");
        }
        else
        {
            pci.new_result(regno.Value, description.Value, filename.Value, filepath.Value, filesize.Value);
            if (pci.exe == 1)
            {
                alert_true(pci.status);
                regno.Value = "";
                description.Value = "";
                regno.Focus();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }


   
}