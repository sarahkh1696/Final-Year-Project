using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class DeletePatient : System.Web.UI.Page
{
    //variable to store the primary key of the record being deleted
    Int32 PatientID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the patient id to be deleted from the session object
        PatientID = Convert.ToInt32(Session["PatientID"]);
    }

    void DeletePatients()
    {
        //create a new instance of the patient collection
        clsPatientCollection Patients = new clsPatientCollection();
        //find the record to delete
        Patients.ThisPatient.Find(PatientID);
        //delete the record
        Patients.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeletePatients();
        //redirect back to the main page
        Response.Redirect("ViewPatients.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Patients.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("ViewPatient.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Payments.aspx");
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