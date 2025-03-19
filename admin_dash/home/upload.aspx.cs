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
        uploadData.DataSource = pci.get_uploads();
        uploadData.DataBind();

        submissionData.DataSource = pci.get_student_uploads();
        submissionData.DataBind();
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
            FileUpload1.SaveAs(Server.MapPath("upload_docs/uploads/" + FileUpload1.PostedFile.FileName));
            filename.Value = FileUpload1.PostedFile.FileName;
            filepath.Value = "upload_docs/uploads/" + FileUpload1.PostedFile.FileName;
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
        if (package.SelectedIndex == 0 || uploadtype.SelectedIndex == 0 || description.Value == "")
        {
            alert_false("All fields are required!");
        }
        else if (filename.Value == "" || filepath.Value == "" || filesize.Value == "")
        {
            alert_false("Upload the file before submission!");
        }
        else
        {
            pci.new_uploads(package.Text, uploadtype.Text, description.Value, filename.Value, filepath.Value, filesize.Value);
            if (pci.exe == 1)
            { 
                alert_true(pci.status);
                package.SelectedIndex = 0;
                uploadtype.SelectedIndex = 0;
                description.Value = "";
                getData();

            }
            else
            {
                alert_false(pci.status);
            }
        }
    }


    protected void uploadData_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete" && e.CommandArgument.ToString() != "")
        {

            try
            {
                File.Delete(Server.MapPath(pci.get_uploads_file_path(e.CommandArgument.ToString())));
                pci.delete_uploads(e.CommandArgument.ToString());
                if (pci.exe == 1)
                {
                    alert_true(pci.msg());
                    getData();
                }
                else
                {
                    alert_false(pci.msg());
                }

            }
            catch
            {

            }

        }
    }

    protected void submissionData_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete" && e.CommandArgument.ToString() != "")
        {
           
            try
            {
                //alert_true(Server.MapPath( "../" + pci.get_student_uploads_file_path(e.CommandArgument.ToString())));
                File.Delete(Server.MapPath("../" + pci.get_student_uploads_file_path(e.CommandArgument.ToString())));
                pci.delete_student_uploads(e.CommandArgument.ToString());
                if (pci.exe == 1)
                {
                    alert_true(pci.msg());
                    getData();
                }
                else
                {
                    alert_false(pci.msg());
                }
                

            }
            catch
            {

            }

        }
    }
}