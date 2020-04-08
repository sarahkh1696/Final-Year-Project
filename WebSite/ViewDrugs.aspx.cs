using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ViewDrugs : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages 
        lblError.Text = "";
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //display the list and the number of records found
            lblError.Text = DisplayDrugs("") + "records in the database";
        }
    }

    Int32 DisplayDrugs(string DrugIDFilter)
    {
        //create an isntance of the drug collection class
        clsDrugCollection Drugs = new clsDrugCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the primary key value
        string DrugID;
        //var to store the drug name
        string DrugName;
        //var to store the drug type
        string DrugType;
        //var to store the drug price
        string DrugPrice;
        //var to store the expiry date
        string ExpiryDate;
        //var to store the issued date
        string IssuedDate;
        //var to store the quantity
        string Quantity;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstDrugs.Items.Clear();
        //call the filter by drug id method
        Drugs.FilteredByDrugID(DrugIDFilter);
        //get the count of records found
        RecordCount = Drugs.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the drug id from the query results
            DrugID = Convert.ToString(Drugs.DrugList[Index].DrugID);
            //get the drug name from the query results
            DrugName = Convert.ToString(Drugs.DrugList[Index].DrugName);
            //get the drug type from the query results
            DrugType = Convert.ToString(Drugs.DrugList[Index].DrugType);
            //get the drug price from the query results
            DrugPrice = Convert.ToString(Drugs.DrugList[Index].DrugPrice);
            //get the expiry date from the query results
            ExpiryDate = Convert.ToString(Drugs.DrugList[Index].ExpiryDate);
            //get the issued date from the query results
            IssuedDate = Convert.ToString(Drugs.DrugList[Index].IssuedDate);
            //get the quantity from the query results
            Quantity = Convert.ToString(Drugs.DrugList[Index].Quantity);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(DrugID + " " + DrugName + " " + DrugType + "" + DrugPrice, ExpiryDate );
            //add the new item to the list
            lstDrugs.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["DrugID"] = -1;
        //redirects to the drug page
        Response.Redirect("Drugs.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be updated
        Int32 DrugID;
        //if a record has been sleceted  from the list
        if (lstDrugs.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            DrugID = Convert.ToInt32(lstDrugs.SelectedIndex);
            //store the data in the session object
            Session["DrugID"] = DrugID;
            //redirect to the edit page
            Response.Redirect("Drugs.aspx");
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
        Int32 DrugID;
        //if a record has been slected from the list 
        if (lstDrugs.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            DrugID = Convert.ToInt32(lstDrugs.SelectedIndex);
            //store the data in the session object
            Session["DrugID"] = DrugID;
            //redirects to the delete page
            Response.Redirect("DeleteDrug.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void lstDrugs_SelectedIndexChanged(object sender, EventArgs e)
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
        //redirects to the orders page
        Response.Redirect("Orders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the payments page
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