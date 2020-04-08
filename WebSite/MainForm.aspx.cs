using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the default page 
        Response.Redirect("Default.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the default page 
        Response.Redirect("SignUp.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirects to the default page 
        Response.Redirect("Reset.aspx");
    }

    protected void imgbtnPatients_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to the patients page
        Response.Redirect("ViewPatients.aspx");
    }

    protected void imgbtnDrugs_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to the drugs page
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void imgbtnConsultants_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to the consultants page
        Response.Redirect("ViewConsultants.aspx");
    }

    protected void imgbtnOrders_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to the orders page
        Response.Redirect("ViewOrders.aspx");
    }

    protected void imgbtnPayments_Click(object sender, ImageClickEventArgs e)
    {
        //redirects to the payments page
        Response.Redirect("ViewPayments.aspx");
    }
}