using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Drugs : System.Web.UI.Page
{
    //var to store the DrugID 
    Int32 DrugID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the drug id from the session object
        DrugID = Convert.ToInt32(Session["DrugID"]);
        //if this is the first item the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (DrugID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayDrugs();
            }
        }
    }
    void DisplayDrugs()
    {
        //create an instance of the drug collection class
        clsDrugCollection Drugs = new clsDrugCollection();
        //find the record we want to display
        Drugs.ThisDrug.Find(DrugID);
        //display the drug name
        txtDrugName.Text = Drugs.ThisDrug.DrugName;
        //display the drug type 
        txtDrugType.Text = Drugs.ThisDrug.DrugType;
        //display the drug price 
        txtDrugPrice.Text = Convert.ToString(Drugs.ThisDrug.DrugPrice);
        //display the expiry date 
        txtExpiryDate.Text = Drugs.ThisDrug.ExpiryDate.ToString("dd/MM/yyyy");
        //display the issued date 
        txtIssuedDate.Text = Drugs.ThisDrug.IssuedDate.ToString("dd/MM/yyyy");
        //display the quantity
        txtQuantity.Text = Drugs.ThisDrug.Quantity.ToString("");
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the drug collection class
        clsDrugCollection Drugs = new clsDrugCollection();
        //use the objects validation method to test the data
        ErrorMsg = Drugs.ThisDrug.Valid(txtDrugName.Text, txtDrugType.Text, "F", txtDrugPrice.Text, txtExpiryDate.Text, txtIssuedDate.Text, txtQuantity.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (DrugID == -1)
            {
                //set the drug name property
                Drugs.ThisDrug.DrugName = txtDrugName.Text;
                //set the drug type property
                Drugs.ThisDrug.DrugType = txtDrugType.Text;
                //set the drug price property
               // Drugs.ThisDrug.DrugPrice = Convert.ToDecimal(txtDrugPrice.Text);
                //set the expiry date property
                Drugs.ThisDrug.ExpiryDate = Convert.ToDateTime(txtExpiryDate.Text);
                //set the issued date property
                Drugs.ThisDrug.IssuedDate = Convert.ToDateTime(txtIssuedDate.Text);
                //set the quantity property
                //Drugs.ThisDrug.Quantity = Convert.ToInt32(txtQuantity.Text);
                //invoke the add method
                Drugs.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                Drugs.ThisDrug.Find(DrugID);
                //set the drug name property
                Drugs.ThisDrug.DrugName = txtDrugName.Text;
                //set the drug type property
                Drugs.ThisDrug.DrugType = txtDrugType.Text;
                //set the drug price property
                Drugs.ThisDrug.DrugPrice = Convert.ToDecimal(txtDrugPrice.Text);
                //set the expiry date property
                Drugs.ThisDrug.ExpiryDate = Convert.ToDateTime(txtExpiryDate.Text);
                //set the issued date property
                Drugs.ThisDrug.IssuedDate = Convert.ToDateTime(txtIssuedDate.Text);
                //set the quantity property
                Drugs.ThisDrug.Quantity = Convert.ToInt32(txtQuantity.Text);
                //update the record with the new data
                Drugs.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("ViewDrugs.aspx");
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
        //redirect to the main form
        Response.Redirect("MainForm.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //redirect to the view patients form
        Response.Redirect("ViewPatients.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //redirect to the orders form
        Response.Redirect("ViewOrders.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //redirect to the payments form
        Response.Redirect("ViewPayments.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirect to the consultants form
        Response.Redirect("ViewConsultants.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirect to the main form
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void txtDrugID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDrugName_TextChanged(object sender, EventArgs e)
    {

    }
}
