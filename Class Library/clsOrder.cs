using System;

namespace Class_Library
{
    public class clsOrder
    {
        //private data member for the Order ID property
        private Int32 mOrderID;
        //private data member for the OrderLine ID property
        //private Int32 mOrderLineID;
        //private data member for the Patient ID property
        private Int32 mPatientID;
        //private data member for the date placed property
        private DateTime mDatePlaced;
        //private data member for the quantity property
        private Int32 mQuantity;
        //private data member for the shipping address property
        private string mShippingAddress;
        //private data member for the Pharmacist total price property
        private decimal mTotalPrice;
        
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member 
                mOrderID = value;
            }
        }


        public DateTime DatePlaced
        {
            get
            {
                //return private data 
                return mDatePlaced;
            }

            set
            {
                //set the value of the private data member 
                mDatePlaced = value;
            }
        }
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member 
                mQuantity = value;
            }
        }
        public string ShippingAddress
        {
            get
            {
                //return private data
                return mShippingAddress;
            }

            set
            {
                //set the value of the private data member 
                mShippingAddress = value;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                //return private data
                return mTotalPrice;
            }

            set
            {
                //set the value of the private data member 
                mTotalPrice = value;
            }
        }

        public int PatientID
        {
            get
            {
                //return the private data
                return mPatientID;
            }
            set
            {
                //set the value of the private data member 
                mPatientID = value;
            }
        }

        //public int OrderLineID
        //{
        //    get
        //    {
        //        //return the private data
        //        return mOrderLineID;
        //    }
        //    set
        //    {
        //        //set the value of the private data member 
        //        mOrderLineID = value;
        //    }
       // }

        public string Valid(string PatientID, string DatePlaced, string ShippingAddress, string Quantity, string TotalPrice, string OrderID)
        {
            //create a string variable to store the error 
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {
                //copy the datePlaced value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(DatePlaced);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    //Error = Error + "The date can't be in the past : ";
                }
                //check to see if the date is greater than toaday's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                   // Error = Error + "The date can't be in the future : ";
                }
            }
            catch
            {
                //record the error 
                //Error = Error + "The date wasn't a valid date : ";
            }

            //try
            //{
            //    Int32 OrderLineIDTemp = Convert.ToInt32(OrderLineID);
            //    //if the OrderID is blank 
            //    if (OrderLineIDTemp == 0)
            //    {
            //        //record the error 
            //        // Error = Error + "The OrderLineID might be less than 1 : ";
            //    }
            //    //if the order line id is grater than 7 characters 
            //    if (OrderLineIDTemp > 10)
            //    {
            //        //record the error 
            //        Error = Error + "The OrderLineID might be less than 10 char. : ";
            //    }
            //}

            //catch
            //{
            //    Error = Error + "The OrderLineID is not a number";
            //}

            try
            {
                Int32 PatientIDTemp = Convert.ToInt32(PatientID);
                //if the OrderID is blank 
                if (PatientIDTemp == 0)
                {
                    //record the error 
                    // Error = Error + "The PatientID might be less than 1 : ";
                }
                //if the order line id is grater than 7 characters 
                if (PatientIDTemp > 10)
                {
                    //record the error 
                    //Error = Error + "The PatientID might be less than 10 char. : ";
                }
            }

            catch
            {
                //Error = Error + "The PatientID is not a number";
            }


            try
            {
                Int32 QuantityTemp = Convert.ToInt32(Quantity);
                //if the Quantity is blank 
                if (QuantityTemp == 0)
                {
                    //record the error 
                    // Error = Error + "The Quantity might not be blank : ";
                }
                //if the quantity is grater than 7 characters 
                if (QuantityTemp > 7)
                {
                    //record the error 
                    // Error = Error + "The Quantity might be less than 7 char. : ";
                }

            }

            catch
            {
                // Error = Error + "The quantity is not a number";
            }

            //try
            //{
            //    //decimal DrugPriceTemp = Convert.ToDecimal(DrugPrice);
            //    //if TotalPrice is empty 
            //    if (DrugPriceTemp < 0)
            //    {
            //        //record the error 
            //        Error = Error + "The Drug Price cannot be less than £0.00";
            //    }
            //    if (DrugPriceTemp > 50)
            //    {
            //        //record the error 
            //        Error = Error + "The Drug Price cannot be greater than £50";
            //    }
            //}

            //catch
            //{
            //    Error = Error + "The Drug Price is not a number";
            //}

            //if shipping Address is more than 50 characters long
            if (ShippingAddress.Length > 50)
            {
                //return an error message
                //Error = "Shipping Address can't have more than 50 characters";
            }
            //if Shipping Address is more than 100 characters long
            else if (ShippingAddress.Length > 100)
            {
                //return an error message
                Error = "Shipping Address can't have more than 100 characters";
            }

            //return any error messages 
            return Error;
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the orderno in order to look for it 
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilteredByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                //mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                //mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mDatePlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePlaced"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                //return that the whole thing function well 
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
    }
}

