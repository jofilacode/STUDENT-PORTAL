using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cbt_display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(Session["cbt_done"]==null)
        {
            Response.Redirect("home.aspx");
        }
        else
        {
            getscore.InnerText = Session["score"].ToString();
        }
        
    }
}