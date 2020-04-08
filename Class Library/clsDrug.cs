using System;

namespace Class_Library
{
    public class clsDrug
    {
        //private data member for the Drug ID property
        private int mDrugID;
        //private data member for the Drug Name property
        private string mDrugName;
        //private data member for the Drug Type property
        private string mDrugType;
        //private data member for the Drug Price property
        private decimal mDrugPrice;
        //private data member for the Issued Date property
        private DateTime mIssuedDate;
        //private data member for the Expiry Date property
        private DateTime mExpiryDate;
        //private data member for the Quantity property
        private int mQuantity;
    
        public string DrugName

        {
            get
            {
                //return the private data
                return mDrugName;
            }
            set
            {
                //set the value of the private data member 
                mDrugName = value;
            }
        }

        public int DrugID
        {
            get
            {
                //return the private data
                return mDrugID;
            }
            set
            {
                //set the value of the private data member 
                mDrugID = value;
            }
        }

        public string DrugType
        {
            get
            {
                //return the private data
                return mDrugType;
            }
            set
            {
                //set the value of the private data member 
                mDrugType = value;
            }
        }
        public decimal DrugPrice
        {
            get
            {
                //return the private data
                return mDrugPrice;
            }
            set
            {
                //set the value of the private data member 
                mDrugPrice = value;
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

        public DateTime IssuedDate 
        {
            get
            {
                //return the private data
                return mIssuedDate;
            }
            set
            {
                //set the value of the private data member 
                mIssuedDate = value;
            }
        }

        public DateTime ExpiryDate
        {
            get
            {
                //return the private data
                return mExpiryDate;
            }
            set
            {
                //set the value of the private data member 
                mExpiryDate = value;
            }
        }

        public string Valid(string DrugName, string DrugType, string DrugPrice, string IssuedDate, string ExpiryDate, string Quantity, string DrugID)
        {
            //string variable to store the error message 
            string Error = "";

            //if DrugName is blank 
            if (DrugName.Length == 0)
            {
                //record an error message 
                //Error = "Drug Name can't be blank"; 
            }
            //if DrugName is more than 50 characters long
            if (DrugName.Length > 50)
            {
                //record the error
               // Error = "Drug Name can't be more than 50 characters";
            }
            //if DrugName is more than 80 characters long
            else if (DrugName.Length > 80)
            {
                // Return an error message
                //Error = "Drug Name can't be more than 80 characters";
            }
            //if DrugType is more than 50 character long 
            else if (DrugType.Length > 50)
            {
                //record the error 
                //Error = "Drug Type can't be more than 50 characters"; 
            }
            //if DrugType is less than 50 character long 
            else if (DrugType.Length < 50)
            {
                //record the error 
               // Error = "Drug Type can't be less than 50 characters";
            }
            try
            {
                decimal DrugPriceTemp = Convert.ToDecimal(DrugPrice);
                //if DrugPrice is empty 
                if (DrugPriceTemp < 0)
                {
                    //record the error 
                    Error = "The Drug Price cannot be less than £0.00";
                }
                if (DrugPriceTemp > 50)
                {
                    //record the error 
                    Error = "The Drug Price cannot be greater than £50";
                }
            }
            catch
            {
               // Error = Error + "The Drug Price is not a number";
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

            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {
                //copy the Issued date value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(IssuedDate);

                //check to see if the date is greater than toaday's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date can't be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date wasn't a valid date : ";
            }

            try
            {
                //copy the Expiry date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(ExpiryDate);
                if (DateTemp > DateTime.Now.Date.AddYears(5))
                {
                    //record the error 
                    Error = Error + "The date can't be more than 5 years : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date wasn't a valid date : ";
            }

            //return the result
            return Error;
        }

        public bool Find(int drugID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the DrugID to search for
            DB.AddParameter("@DrugID", DrugID);
            //execute the stored procedure
            DB.Execute("sproc_tblDrug_FilteredByDrugID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members 
                mDrugID = Convert.ToInt32(DB.DataTable.Rows[0]["DrugID"]);
                mDrugName = Convert.ToString(DB.DataTable.Rows[0]["DrugName"]);
                mDrugType = Convert.ToString(DB.DataTable.Rows[0]["DrugType"]);
                mDrugPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["DrugPrice"]);
                mIssuedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["IssuedDate"]);
                mExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false if a problem has indicated 
                return false;
            }
        }
    }
}