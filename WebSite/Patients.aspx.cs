using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library; 
public partial class Patients : System.Web.UI.Page
{
    //var to store the PatientID 
    Int32 PatientID;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //get the patient id from the session object
        PatientID = Convert.ToInt32(Session["PatientID"]);
        //if this is the first item the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (PatientID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayPatients();
            }
            else//this is a new record
            {
                //set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/MM/yyyy"); ;
            }
        }
    }

    void DisplayPatients()
    {
        //create an instance of the patient collection class
        clsPatientCollection Patients = new clsPatientCollection();
        //find the record we want to display
        Patients.ThisPatient.Find(PatientID);
        //display the first name
        txtFirstName.Text = Patients.ThisPatient.FirstName;
        //display the last name 
        txtLastName.Text = Patients.ThisPatient.LastName;
        //display the address line 
        txtAddressLn.Text = Patients.ThisPatient.AddressLine;
        //display the contact no 
        txtContactNo.Text = Patients.ThisPatient.ContactNo;
        //display the age 
        txtAge.Text = Patients.ThisPatient.Age.ToString("");
        //display the date added
        txtDateAdded.Text = Patients.ThisPatient.DateAdded.ToString("dd/MM/yyyy");
        //display the gender 
        ddlGender.SelectedValue = Convert.ToString(Patients.ThisPatient.Gender);
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the  page
        Response.Redirect("MainForm.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main form
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("ViewPatients.aspx");
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the patient collection class
        clsPatientCollection Patients = new clsPatientCollection();
        //use the objects validation method to test the data
        ErrorMsg = Patients.ThisPatient.Valid(txtFirstName.Text, txtLastName.Text, "F", txtAge.Text, txtAddressLn.Text, txtDateAdded.Text, txtContactNo.Text, txtPatientID.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (PatientID == -1)
            {
                //set the first name property
                Patients.ThisPatient.FirstName = txtFirstName.Text;
                //set the last name property
                Patients.ThisPatient.LastName = txtLastName.Text;
                //set the address line property
                Patients.ThisPatient.AddressLine = txtAddressLn.Text;
                //set the contact no property
                Patients.ThisPatient.ContactNo = txtContactNo.Text;
                //set the age property
                Patients.ThisPatient.Age = Convert.ToInt32(txtAge.Text);
                //set the data added property
                Patients.ThisPatient.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //set the gender property
                Patients.ThisPatient.Gender = Convert.ToString(ddlGender.SelectedValue);
                //invoke the add method
                Patients.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                Patients.ThisPatient.Find(PatientID);
                //set the first name property
                Patients.ThisPatient.FirstName = txtFirstName.Text;
                //set the last name property
                Patients.ThisPatient.LastName = txtLastName.Text;
                //set the address line property
                Patients.ThisPatient.AddressLine = txtAddressLn.Text;
                //set the contact no property
                Patients.ThisPatient.ContactNo = txtContactNo.Text;
                //set the date added property
                Patients.ThisPatient.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //set the gender property
                Patients.ThisPatient.Gender = Convert.ToString(ddlGender.SelectedValue);
                //update the record with the new data
                Patients.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("ViewPatients.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = ErrorMsg;
        }
    }


    protected void txtPatientID_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }
}