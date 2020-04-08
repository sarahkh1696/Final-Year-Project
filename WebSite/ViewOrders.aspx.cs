using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ViewOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages 
        lblError.Text = "";
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //display the list and the number of records found
            lblError.Text = DisplayOrders("") + "records in the database";
        }
    }

    Int32 DisplayOrders(string OrderIDFilter)
    {
        //create an isntance of the order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the primary key value
        string OrderID;
        //var to store the patient id 
        string PatientID;
        //var to store the date placed
        string DatePlaced;
        //var to store the quantity
        string Quantity;
        //var to store the shipping address
        string ShippingAddress;
        //var to store the total price
        string TotalPrice;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstOrders.Items.Clear();
        //call the filter by order id method
        Orders.FilteredByOrderID(OrderIDFilter);
        //get the count of records found
        RecordCount = Orders.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the order id from the query results
            OrderID = Convert.ToString(Orders.OrderList[Index].OrderID);
            //get the patient id from the query results
            PatientID = Convert.ToString(Orders.OrderList[Index].PatientID);
            //get the date placed from the query results
            DatePlaced = Convert.ToString(Orders.OrderList[Index].DatePlaced);
            //get the quantity from the query results
            Quantity = Convert.ToString(Orders.OrderList[Index].Quantity);
            //get the total price from the query results
            TotalPrice = Convert.ToString(Orders.OrderList[Index].TotalPrice);
            //get the shipping address from the query results
            ShippingAddress = Convert.ToString(Orders.OrderList[Index].ShippingAddress);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(OrderID + " " + DatePlaced + " " + ShippingAddress + "" + Quantity, TotalPrice);
            //add the new item to the list
            lstOrders.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["OrderID"] = -1;
        //redirects to the order page
        Response.Redirect("Orders.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be updated
        Int32 OrderID;
        //if a record has been sleceted  from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            OrderID = Convert.ToInt32(lstOrders.SelectedIndex);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the update page
            Response.Redirect("Orders.aspx");
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
        Int32 OrderID;
        //if a record has been sleceted  from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to update
            OrderID = Convert.ToInt32(lstOrders.SelectedIndex);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirects to the delete page
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record first then delete it from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
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
        Response.Redirect("ViewPayments.aspx");
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

    protected void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}