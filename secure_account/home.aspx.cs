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
        pci.get_update(Session["username"].ToString());
        regno.InnerText = pci.g_regno;
        username.InnerHtml = pci.g_username;
        fullname.InnerText = pci.g_fullname;
        email.InnerText = pci.g_email;
        mobile.InnerText = pci.g_mobile;
        address.InnerText = pci.g_address;
        age.InnerText = pci.g_age;
        gender.InnerText = pci.g_gender;
        studpassport.Src = pci.g_passport;
        filepath.Value = pci.g_passport;
        pci.get_update2(regno.InnerText);
        package.InnerText = pci.g_package;
        duration.InnerText = pci.g_duration;

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
            FileUpload1.SaveAs(Server.MapPath("profile/" + FileUpload1.PostedFile.FileName));
            filename.Value = FileUpload1.PostedFile.FileName;
            filepath.Value = "../../secure_account/profile/" + FileUpload1.PostedFile.FileName;
            int size = FileUpload1.PostedFile.ContentLength;
            filesize.Value = size.ToString() + "kb";
            alert_true("file uploaded successfully");
            studpassport.Src = filepath.Value;
        }
        else
        {
            alert_false("Browse or Select a file before upload");
        }
    }

    protected void update(object sender, EventArgs e)
    {

        if (xfullname.Value == "" || xemail.Value == "" || xmobile.Value == "" || xaddress.Value == "" || xage.Value == "" || xgender.SelectedIndex == 0)
        {
            editbox.Style.Add("display", "none");
            mainbox.Style.Add("display", "block");
            alert_false("Click Edit Button before you click update and ensure all boxes are filled");
        }
        else
        {

                pci.update_profile(xfullname.Value, xemail.Value, xmobile.Value, xaddress.Value, xage.Value, xgender.Text, filepath.Value, username.InnerText);
                if (pci.exe == 1)
                {
                    editbox.Style.Add("display", "block");
                    mainbox.Style.Add("display", "none");
                    alert_true(pci.status);

                    pci.get_update(Session["username"].ToString());
                    fullname.InnerText = pci.g_fullname;
                    email.InnerText = pci.g_email;
                    mobile.InnerText = pci.g_mobile;
                    address.InnerText = pci.g_address;
                    age.InnerText = pci.g_age;
                    gender.InnerText = pci.g_gender;
                    studpassport.Src = pci.g_passport;

                    xfullname.Value = pci.g_fullname;
                    xemail.Value = pci.g_email;
                    xmobile.Value = pci.g_mobile;
                    xaddress.Value = pci.g_address;
                    xage.Value = pci.g_age;
                    xgender.Text = pci.g_gender;

                }
                else
                {
                    editbox.Style.Add("display", "block");
                    mainbox.Style.Add("display", "none");
                    alert_false(pci.status);
                }
          

        }
    }


    protected void editbtn_Click(object sender, EventArgs e)
    {
        mainbox.Style.Add("display","none");
        editbox.Style.Add("display","block");
        
        xfullname.Value = fullname.InnerText;
        xemail.Value = email.InnerText;
        xmobile.Value = mobile.InnerText;
        xaddress.Value = address.InnerText;
        xgender.Text = gender.InnerText;
        xage.Value = age.InnerText;
    }
}