using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Consultants : System.Web.UI.Page
{
    //var to store the ConsultantID 
    Int32 ConsultantID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the consultant id from the session object
        ConsultantID = Convert.ToInt32(Session["ConsultantID"]);
        //if this is the first item the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (ConsultantID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayConsultants();
            }
        }
    }

    void DisplayConsultants()
    {
        //create an instance of the consultant collection class
        clsConsultantCollection Consultants = new clsConsultantCollection();
        //find the record we want to display
        Consultants.ThisConsultant.Find(ConsultantID);
        //display the consultant name
        txtConsultantName.Text = Consultants.ThisConsultant.ConsultantName;
        //display the consultant specialist 
        txtConsultantSpecialist.Text = Consultants.ThisConsultant.ConsultantSpecialist;
        //display the consultant comment 
        txtConsultantComment.Text = Consultants.ThisConsultant.ConsultantComment;
        //display the drug type 
        txtDrugType.Text = Consultants.ThisConsultant.DrugType;
        //display the date added 
        txtDateAdded.Text = Consultants.ThisConsultant.DateAdded.ToString("dd/MM/yyyy");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirects to the view consultants page
        Response.Redirect("ViewConsultants.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the consultant collection class
        clsConsultantCollection Consultants = new clsConsultantCollection();
        //use the objects validation method to test the data
        ErrorMsg = Consultants.ThisConsultant.Valid(txtConsultantName.Text, txtDrugType.Text, "F", txtConsultantSpecialist.Text, txtDateAdded.Text, txtConsultantComment.Text, txtConsultantID.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (ConsultantID == -1)
            {
                //set the consultant name property
                Consultants.ThisConsultant.ConsultantName = txtConsultantName.Text;
                //set the consultant specialist property
                Consultants.ThisConsultant.ConsultantSpecialist = txtConsultantSpecialist.Text;
                //set the consultant comment property
                Consultants.ThisConsultant.ConsultantComment = txtConsultantComment.Text;
                //set the drug type property
                Consultants.ThisConsultant.DrugType = txtDrugType.Text;
                //set the date added property
                Consultants.ThisConsultant.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //invoke the add method
                Consultants.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                Consultants.ThisConsultant.Find(ConsultantID);
                //set the consultant name property
                Consultants.ThisConsultant.ConsultantName = txtConsultantName.Text;
                //set the consultant specialist property
                Consultants.ThisConsultant.ConsultantSpecialist = txtConsultantSpecialist.Text;
                //set the consultant comment property
                Consultants.ThisConsultant.ConsultantComment = txtConsultantComment.Text;
                //set the drug type property
                Consultants.ThisConsultant.DrugType = txtDrugType.Text;
                //set the expiry date property
                Consultants.ThisConsultant.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //update the record with the new data
                Consultants.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("ViewConsultants.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = ErrorMsg;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main form
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the main page
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the view patients page
        Response.Redirect("ViewPatients.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirects to the orders page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the payments page
        Response.Redirect("Payments.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirects to the view drugs page
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void txtConsultantID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtConsultantName_TextChanged(object sender, EventArgs e)
    {

    }
}