using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class DeleteDrug : System.Web.UI.Page
{ 
    //variable to store the primary key of the record being deleted
    Int32 DrugID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the drug id to be deleted from the session object
        DrugID = Convert.ToInt32(Session["DrugID"]);
    }

    void DeleteDrugs()
    {
        //create a new instance of the drug collection
        clsDrugCollection Drugs = new clsDrugCollection();
        //find the record to delete
        Drugs.ThisDrug.Find(DrugID);
        //delete the record
        Drugs.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeleteDrugs();
        //redirect back to the main page
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Drugs.aspx");
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