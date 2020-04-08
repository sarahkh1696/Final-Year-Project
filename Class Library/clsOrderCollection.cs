using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsOrderCollection
    {
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Deleting Method property
        private string mDeleteMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for ThisOrder property
        private string mThisOrderOK;
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder 
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;
            }

        }
    
            public int Count
            {
                get
                {
                    //return the count of the list 
                    return mOrderList.Count;
                }
                set
                {
                    //we shall worry about this later 
                }

            }
            public clsOrder ThisOrder
            {
                get
                {
                    //return the private data 
                    return mThisOrder;
                }
                set
                {
                    //set the private data 
                    mThisOrder = value;
                }

            }

            //constructor for the class 
            public clsOrderCollection()
            {
                //var for the index 
                Int32 Index = 0;
                //var to store the record count 
                Int32 RecordCount = 0;
                //object for data connection 
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure 
                DB.Execute("sproc_tblOrder_SelectAll");
                //get the count of records 
                RecordCount = DB.Count;
                //while there are records to process 

                while (Index < RecordCount)
                {
                    //create a blank order no 
                    clsOrder AnOrder = new clsOrder();
                    //read in the fields from the current record 
                    //AnOrder.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                    AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                    AnOrder.DatePlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePlaced"]);
                    AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                    AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                    //AnOrder.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                    AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                    //add the record to the private data member 
                    mOrderList.Add(AnOrder);
                    //point at the next record 
                    Index++;
                }
            }

        public void FilteredByOrderID(string OrderID)
        ///it accepts a single parameter order id and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@OrderID", OrderID);
            //execute the stored procedure to delete the order
            dBConnection.Execute("sproc_tblOrder_FilteredByOrderID");
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisOrder 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure 
            //DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //DB.AddParameter("@OrderLineID", mThisOrder.OrderLineID);
              DB.AddParameter("@PatientID", mThisOrder.PatientID);
              DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
              DB.AddParameter("@Quantity", mThisOrder.Quantity);
              DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
              DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
              //execute the query returning the primary key value 
               return DB.Execute("sproc_tblOrder_Add");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //DB.AddParameter("@OrderLineID", mThisOrder.OrderLineID);
            //DB.AddParameter("@PatientID", mThisOrder.PatientID);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            // execute the query returing the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisOrder
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //DB.AddParameter("@OrderLineID", mThisOrder.OrderLineID);
            //DB.AddParameter("@PatientID", mThisOrder.PatientID);
            //DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            //DB.AddParameter("@Quantity", mThisOrder.Quantity);
            //DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            //DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            //executre the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }
    }
}
