using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeletePayment : System.Web.UI.Page
{
    //variable to store the primary key of the record being deleted
    Int32 PaymentID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
    }
 
    void DeletePayments()
    {
        //create a new instance of the payment collection
        clsPaymentCollection Payments = new clsPaymentCollection();
        //find the record to delete
        Payments.ThisPayment.Find(PaymentID);
        //delete the record
        Payments.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeletePayments();
        //redirect back to the main page
        Response.Redirect("ViewPayments.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("ViewPayments.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Patients.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("ViewPayments.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Consultants.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirects to the page 
        Response.Redirect("Drugs.aspx");
    }
}