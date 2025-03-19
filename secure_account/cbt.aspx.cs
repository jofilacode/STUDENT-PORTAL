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
    int score;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["access"] != null)
        {
            if (!IsPostBack)
            {
                getData();
                if (pci.cbt_done(Session["regno"].ToString()) == true)
                {
                    cbtresult.Style.Add("display", "block");
                }
            }

         

        }
        else
        {
            Response.Redirect("../login.aspx");
        }
        
    }

    void getData()
    {
        course.Value = pci.get_package_cbt(Session["regno"].ToString());
        course_title.InnerText = "Package : " + pci.get_package_cbt(Session["regno"].ToString());

        cbtData.DataSource = pci.get_cbt_result_student(Session["regno"].ToString());
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


    protected void btn_start_Click(object sender, EventArgs e)
    {
        if (course.Value == "")
        {
            alert_false("No course selected!");
        }
        else
        {

            
            if (pci.check_cbt_settings(course.Value) == "Enable")
            {

                if (pci.cbt_done(Session["regno"].ToString()) == true)
                {
                    alert_false("You have previously attempted CBT for this package. Please contact admin!");
                }
                else
                {
                    cbt_open.Style.Add("display", "block");
                    pci.fetch_cbt_settings(course.Value);
                    mark.InnerText = pci.xcbt_mark;
                    timecount.InnerText = pci.xcbt_time;
                    cbt_display.DataSource = pci.get_cbt_course_data(course.Value);
                    if (pci.exe == 0)
                    {
                        alert_false(pci.msg());
                    }
                    else
                    {
                        cbt_display.DataBind();
                        alert_true(pci.msg());
                        startbox.Style.Add("display", "none");

                        TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(int.Parse(timecount.InnerText)) * 60);
                        string str = time.ToString(@"hh\:mm\:ss");
                        timecount.InnerText = str;

                        
                       

                    }
                }
            }
            else
            {
                alert_false("CBT is currently disabled by admin");
            }
            
            
            

            
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        TimeSpan result = TimeSpan.FromSeconds(TimeSpan.Parse(timecount.InnerText).TotalSeconds - 1);
        string fromTimeString = result.ToString(@"hh\:mm\:ss");
        timecount.InnerText = fromTimeString;

        if(timecount.InnerText=="00:00:00")
        {
            Timer1.Enabled = false;

            int getmark = int.Parse(mark.InnerText);
            foreach (RepeaterItem item in cbt_display.Items)
            {
                RadioButton option_1 = (RadioButton)item.FindControl("opt_a");
                RadioButton option_2 = (RadioButton)item.FindControl("opt_b");
                RadioButton option_3 = (RadioButton)item.FindControl("opt_c");
                RadioButton answer = (RadioButton)item.FindControl("ans");
                if (option_1.Checked == true)
                {
                    if (option_1.Text == answer.Text)
                    {
                        score += getmark;
                        holdscore.Value = score.ToString();
                    }
                }
                else if (option_2.Checked == true)
                {
                    if (option_2.Text == answer.Text)
                    {
                        score += getmark;
                        holdscore.Value = score.ToString();
                    }
                }
                else if (option_3.Checked == true)
                {
                    if (option_3.Text == answer.Text)
                    {
                        score += getmark;
                        holdscore.Value = score.ToString();
                    }
                }


            }

            if (holdscore.Value == "")
            {
                holdscore.Value = "0";
            }
            pci.save_cbt_result(Session["regno"].ToString(), pci.get_package_cbt(Session["regno"].ToString()), holdscore.Value);
            if (pci.exe == 1)
            {
                Session["cbt_done"] = 1;
                Session["score"] = holdscore.Value;
                Response.Redirect("cbt_display.aspx");

            }
            else
            {
                alert_false(pci.msg());
            }
            
        }
        
    }



    protected void btn_submit_Click(object sender, EventArgs e)
    {
        int getmark = int.Parse(mark.InnerText);
        foreach (RepeaterItem item in cbt_display.Items)
        {
            RadioButton option_1 = (RadioButton)item.FindControl("opt_a");
            RadioButton option_2 = (RadioButton)item.FindControl("opt_b");
            RadioButton option_3 = (RadioButton)item.FindControl("opt_c");
            RadioButton answer = (RadioButton)item.FindControl("ans");
            if (option_1.Checked == true)
            {
                if(option_1.Text==answer.Text)
                {
                    score += getmark ;
                    holdscore.Value = score.ToString();
                }
            }
            else if (option_2.Checked == true)
            {
                if (option_2.Text == answer.Text)
                {
                    score += getmark;
                    holdscore.Value = score.ToString();
                }
            }
            else if (option_3.Checked == true)
            {
                if (option_3.Text == answer.Text)
                {
                    score += getmark;
                    holdscore.Value = score.ToString();
                }
            }


        }

        if(holdscore.Value=="")
        {
            holdscore.Value = "0";
        }
        pci.save_cbt_result(Session["regno"].ToString(), pci.get_package_cbt(Session["regno"].ToString()), holdscore.Value);
        if (pci.exe == 1)
        {
            Session["cbt_done"] = 1;
            Session["score"] = holdscore.Value;
            Response.Redirect("cbt_display.aspx");

        }
        else
        {
            alert_false(pci.msg());
        }
    }




}