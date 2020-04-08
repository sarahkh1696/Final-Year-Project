using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ViewConsultants : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages 
        lblError.Text = "";
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //display the list and the number of records found
            lblError.Text = DisplayConsultants("") + "records in the database";
        }
    }

    Int32 DisplayConsultants(string ConsultantIDFilter)
    {
        //create an isntance of the consultant collection class
        clsConsultantCollection Consultants = new clsConsultantCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the primary key value
        string ConsultantID;
        //var to store the consultant name
        string ConsultantName;
        //var to store the consultant specialist
        string ConsultantSpecialist;
        //var to store the consultant comment
        string ConsultantComment;
        //var to store the drug type
        string DrugType;
        //var to store the date added
        string DateAdded;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstConsultants.Items.Clear();
        //call the filter by consultant id method
        Consultants.FilteredByConsultantID(ConsultantIDFilter);
        //get the count of records found
        RecordCount = Consultants.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the consultant id from the query results
            ConsultantID = Convert.ToString(Consultants.ConsultantList[Index].ConsultantID);
            //get the consultant name from the query results
            ConsultantName = Convert.ToString(Consultants.ConsultantList[Index].ConsultantName);
            //get the drug type from the query results
            DrugType = Convert.ToString(Consultants.ConsultantList[Index].DrugType);
            //get the consultant specialist from the query results
            ConsultantSpecialist = Convert.ToString(Consultants.ConsultantList[Index].ConsultantSpecialist);
            //get the consultant comment from the query results
            ConsultantComment = Convert.ToString(Consultants.ConsultantList[Index].ConsultantComment);
            //get the date added from the query results
            DateAdded = Convert.ToString(Consultants.ConsultantList[Index].DateAdded);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(ConsultantID + " " + ConsultantName + " " + DrugType + "" + ConsultantSpecialist, DateAdded);
            //add the new item to the list
            lstConsultants.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["ConsultantID"] = -1;
        //redirects to the drug page
        Response.Redirect("Consultants.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be updated
        Int32 ConsultantID;
        //if a record has been sleceted  from the list
        if (lstConsultants.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            ConsultantID = Convert.ToInt32(lstConsultants.SelectedIndex);
            //store the data in the session object
            Session["ConsultantID"] = ConsultantID;
            //redirect to the update page
            Response.Redirect("Consultants.aspx");
        }
        else
        {
            //didplay an error
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void lstConsultants_SelectedIndexChanged(object sender, EventArgs e)
    {

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
        //redirects to the view orders page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the view payments page
        Response.Redirect("Payments.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirects to the consultants page
        Response.Redirect("Consultants.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirects to the drugs page
        Response.Redirect("Drugs.aspx");
    }
}