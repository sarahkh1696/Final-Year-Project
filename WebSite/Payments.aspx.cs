using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Payments : System.Web.UI.Page
{
    //var to store the PaymentID 
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the payment id from the session object
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        //if this is the first item the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (PaymentID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayPayments();
            }
        }
    }

    void DisplayPayments()
    {
        //create an instance of the payment collection class
        clsPaymentCollection Payments = new clsPaymentCollection();
        //find the record we want to display
        Payments.ThisPayment.Find(PaymentID);
        //display the patient id
        txtPatientID.Text = Convert.ToString(Payments.ThisPayment.PatientID);
        //display the payment type 
        ddlPaymentType.Text = Payments.ThisPayment.PaymentType;
        //display the payment date 
        txtPaymentDate.Text = Payments.ThisPayment.PaymentDate.ToString("dd/MM/yyyy");
        //display the price 
        txtPrice.Text = Convert.ToString(Payments.ThisPayment.Price);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the payment collection class
        clsPaymentCollection Payments = new clsPaymentCollection();
        //use the objects validation method to test the data
        ErrorMsg = Payments.ThisPayment.Valid(txtPatientID.Text, "F", ddlPaymentType.Text, txtPaymentDate.Text, txtPrice.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (PaymentID == -1)
            {
                //set the patient id property
                Payments.ThisPayment.PatientID = Convert.ToInt32(txtPatientID.Text);
                //set the payment type property
                Payments.ThisPayment.PaymentType = ddlPaymentType.Text;
                //set the price property
                Payments.ThisPayment.Price = Convert.ToDecimal(txtPrice.Text);
                //set the payment date property
                Payments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                //invoke the add method
                Payments.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                Payments.ThisPayment.Find(PaymentID);
                //set the patient id property
                Payments.ThisPayment.PatientID = Convert.ToInt32(txtPatientID.Text);
                //set the payment type property
                Payments.ThisPayment.PaymentType = ddlPaymentType.Text;
                //set the price property
                Payments.ThisPayment.Price = Convert.ToDecimal(txtPrice.Text);
                //set the payment date property
                Payments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                //update the record with the new data
                Payments.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("ViewPayments.aspx");
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
}