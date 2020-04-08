using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ViewPayments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages 
        lblError.Text = "";
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //display the list and the number of records found
            lblError.Text = DisplayPayments("") + "records in the database";
        }
    }

    Int32 DisplayPayments(string PaymentIDFilter)
    {
        //create an isntance of the payment collection class
        clsPaymentCollection Payments = new clsPaymentCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the primary key value
        string PaymentID;
        //var to store the patient id 
        string PatientID;
        //var to stor the payment type 
        string PaymentType;
        //var to store the payment date 
        string PaymentDate;
        //var to store the price
        string Price;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstPayments.Items.Clear();
        //call the filter by payment id method
        Payments.FilteredByPaymentID(PaymentIDFilter);
        //get the count of records found
        RecordCount = Payments.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the payment id from the query results
            PaymentID = Convert.ToString(Payments.PaymentList[Index].PaymentID);
            //get the patient id from the query results
            PatientID = Convert.ToString(Payments.PaymentList[Index].PatientID);
            //get the payment type from the query results
            PaymentType = Convert.ToString(Payments.PaymentList[Index].PaymentType);
            //get the payment date from the query results
            PaymentDate = Convert.ToString(Payments.PaymentList[Index].PaymentDate);
            //get the price from the query results
            Price = Convert.ToString(Payments.PaymentList[Index].Price);
            //get the total price from the query results
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(PaymentID + " " + PatientID + " " + PaymentType + "" + PaymentDate, Price);
            //add the new item to the list
            lstPayments.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["PaymentID"] = -1;
        //redirects to the Payment page
        Response.Redirect("Payments.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be updated
        Int32 PaymentID;
        //if a record has been sleceted  from the list
        if (lstPayments.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            PaymentID = Convert.ToInt32(lstPayments.SelectedIndex);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //redirect to the update page
            Response.Redirect("Payments.aspx");
        }
        else
        {
            //didplay an error
            lblError.Text = "Please select a record first then update it from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 PaymentID;
        //if a record has been sleceted  from the list
        if (lstPayments.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            PaymentID = Convert.ToInt32(lstPayments.SelectedIndex);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //redirects to the delete page
            Response.Redirect("DeletePayment.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record first then delete it from the list";
        }
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
        Response.Redirect("ViewOrders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirects to the payments page
        Response.Redirect("Payments.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirects to the consultants page
        Response.Redirect("ViewConsultants.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirects to the drugs page
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}