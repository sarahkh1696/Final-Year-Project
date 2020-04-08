using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Orders : System.Web.UI.Page
{
    //var to store the OrderID 
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the order id from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
        //if this is the first item the page is displayed
        if (IsPostBack == false)
        {
            //if we are not adding a new record
            if (OrderID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an isntance of the order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record we want to display
        Orders.ThisOrder.Find(OrderID);
        //display the patient id
        txtPatientID.Text = Convert.ToString(Orders.ThisOrder.PatientID);
        //display the date placed
        txtDatePlaced.Text = Orders.ThisOrder.DatePlaced.ToString("dd/MM/yyyy");
        //display the quantity
        txtQuantity.Text = Orders.ThisOrder.Quantity.ToString("");
        //display the shipping address
        txtShippingAddress.Text = Orders.ThisOrder.ShippingAddress;
        //display the total price 
        txtTotalPrice.Text = Convert.ToString(Orders.ThisOrder.TotalPrice);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an isntance of the order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //use the objects validation method to test the data
        ErrorMsg = Orders.ThisOrder.Valid(txtPatientID.Text, txtDatePlaced.Text, "F", txtShippingAddress.Text, "" ,txtQuantity.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (OrderID == -1)
            {
                //set the drug name property
                Orders.ThisOrder.PatientID = Convert.ToInt32(txtPatientID.Text);
                //set the date placed property
                Orders.ThisOrder.DatePlaced = Convert.ToDateTime(txtDatePlaced.Text);
                //set the quantity property
                Orders.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
                //set the shipping address property
                Orders.ThisOrder.ShippingAddress = txtShippingAddress.Text;
                //set the total price property
                //Orders.ThisOrder.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
                //invoke the add method
                Orders.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                Orders.ThisOrder.Find(OrderID);
                //set the drug name property
                Orders.ThisOrder.PatientID = Convert.ToInt32(txtPatientID.Text);
                //set the date placed property
                Orders.ThisOrder.DatePlaced = Convert.ToDateTime(txtDatePlaced.Text);
                //set the quantity property
                Orders.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
                //set the drug type property
                Orders.ThisOrder.ShippingAddress = txtShippingAddress.Text;
                //set the drug price property
                Orders.ThisOrder.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
                //update the record with the new data
                Orders.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("ViewOrders.aspx");
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
        Response.Redirect("Payments.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //redirect to the consultants form
        Response.Redirect("Consultants.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //redirect to the main form
        Response.Redirect("ViewDrugs.aspx");
    }

    protected void txtDatePlaced_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }
}