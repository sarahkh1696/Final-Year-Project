using System;

namespace Class_Library
{
    public class clsPayment
    {
        //private data member for the payment id property
        private int mPaymentID;
        //private data member for the patient id property
        private int mPatientID;
        //private data member for the payment type property
        private string mPaymentType;
        //private data member for the payment date property
        private DateTime mPaymentDate;
        //private data member for the price property
        private decimal mPrice; 

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

        public int PaymentID
        {
            get
            {
                //return the private data
                return mPaymentID;
            }
            set
            {
                //set the value of the private data member 
                mPaymentID = value;
            }
        }

        public string PaymentType
        {
            get
            {
                //return the private data
                return mPaymentType;
            }
            set
            {
                //set the value of the private data member 
                mPaymentType = value;
            }
        }

        public Decimal Price
        {
            get
            {
                //return the private data 
                return mPrice; 
            }
            set
            {
                //set the value of the private data member 
                mPrice = value; 
            }
        }

        public DateTime PaymentDate
        {
            get
            {
                //return the private data
                return mPaymentDate;
            }
            set
            {
                //set the value of the private data member 
                mPaymentDate = value;
            }
        }

        public string Valid(string PaymentID, string PaymentType, string PaymentDate, string Price, string PatientID)
        {
            //string variable to store the error message 
            string Error = "";

            //if PaymentType is more than 50 character long 
            if (PaymentType.Length > 50)
            {
                //record the error 
                //Error = "Payment Type can't be more than 50 characters"; 
            }
            //if PaymentType is less than 50 character long 
            else if (PaymentType.Length < 50)
            {
                //record the error 
                // Error = "Payment Type can't be less than 50 characters";
            }
            try
            {
                decimal PriceTemp = Convert.ToDecimal(Price);
                //if Price is empty 
                if (PriceTemp < 0)
                {
                    //record the error 
                    //Error = "The Drug Price cannot be less than £0.00";
                }
                if (PriceTemp > 50)
                {
                    //record the error 
                    //Error = "The Drug Price cannot be greater than £50";
                }
            }
            catch
            {
                // Error = Error + "The Drug Price is not a number";
            }
            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {
                //copy the Issued date value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(PaymentDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    //Error = Error + "The date can't be in the past : ";
                }
                //check to see if the date is greater than toaday's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    //Error = Error + "The date can't be in the future : ";
                }
            }
            catch
            {
                //record the error 
                // Error = Error + "The date wasn't a valid date : ";
            }

            //return the result
            return Error;
        }

        public bool Find(int PaymentID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PaymentID in order to look for it 
            DB.AddParameter("@PaymentID", PaymentID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPayment_FilterByPaymentID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mPaymentType = Convert.ToString(DB.DataTable.Rows[0]["PaymentType"]);
                mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
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