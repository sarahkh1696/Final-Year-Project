using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ViewPatients : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages 
        lblError.Text = "";
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //display the list and the number of records found
            lblError.Text = DisplayPatients("") + "  Records in the Database";
        }
    }
    Int32 DisplayPatients(string PatientIDFilter)
    {
        //create an isntance of the patient collection class
        clsPatientCollection Patients = new clsPatientCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the primary key value
        string PatientID;
        //var to store the first name
        string FirstName;
        //var to store the last name
        string LastName;
        //var to store the age
        string Age;
        //var to store the gender
        string Gender;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstPatients.Items.Clear();
        //call the filter by patient id method
        Patients.FilteredByPatientID(PatientIDFilter);
        //get the count of records found
        RecordCount = Patients.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the house no from the query results
            PatientID = Convert.ToString(Patients.PatientList[Index].PatientID);
            //get the first name from the query results
            FirstName = Convert.ToString(Patients.PatientList[Index].FirstName);
            //get the last name from the query results
            LastName = Convert.ToString(Patients.PatientList[Index].LastName);
            //get the age from the query results
            Age = Convert.ToString(Patients.PatientList[Index].Age);
            //get the age from the query results
            Gender = Convert.ToString(Patients.PatientList[Index].Gender);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(PatientID + " " + FirstName + " " + LastName + "" + Age, Gender);
            //add the new item to the list
            lstPatients.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["PatientID"] = -1;
        //redirects to the patient page
        Response.Redirect("Patients.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be updated
        Int32 PatientID;
        //if a record has been sleceted  from the list
        if (lstPatients.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            PatientID = Convert.ToInt32(lstPatients.SelectedIndex);
            //store the data in the session object
            Session["PatientID"] = PatientID;
            //redirect to the update page
            Response.Redirect("Patients.aspx");
        }
        else
        {
            //didplay an error
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 PatientID;
        //if a record has been slected from the list 
        if (lstPatients.SelectedIndex != -1)
        {
            //get the primary key value of the record to dlete 
            PatientID = Convert.ToInt32(lstPatients.SelectedIndex);
            //store the data in the session object
            Session["PatientID"] = PatientID;
            //redirects to the delete page
            Response.Redirect("DeletePatient.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirects to the page
        Response.Redirect("Patients.aspx");
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

    protected void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

}


    




