using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QTPharmacyMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPatients_Click(object sender, EventArgs e)
    {
        //redirects to the patient page
        Response.Redirect("Patients.aspx");
    }

    protected void btnDrugs_Click(object sender, EventArgs e)
    {
        //redirects to the drugs page
        Response.Redirect("Drugs.aspx");
    }

    protected void btnConsultants_Click(object sender, EventArgs e)
    {
        //redirects to the consultant page
        Response.Redirect("Consultants.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirects to the order page
        Response.Redirect("Orders.aspx");
    }

    protected void btnPayments_Click(object sender, EventArgs e)
    {
        //redirects to the payments page
        Response.Redirect("Payments.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        //redirects to the  page
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        //redirects to the  page
        Response.Redirect("Patients.aspx");
    }
}
