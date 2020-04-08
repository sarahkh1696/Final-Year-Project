using System;

namespace Class_Library
{
    public class clsPharmacy
    {
        //private data member for the Pharmacy ID property
        private int mPharmacyID;
        //private data member for the Pharmacy Name property
        private string mPharmacyName;
        //private data member for the Pharmacy Address property
        private string mPharmacyAddress;

        public string PharmacyName
        {
            get
            {
                //return the private data
                return mPharmacyName;
            }
            set
            {
                //set the value of the private data member 
                mPharmacyName = value;
            }
        }

        public int PharmacyID
        {
            get
            {
                //return the private data
                return mPharmacyID;
            }
            set
            {
                //set the value of the private data member 
                mPharmacyID = value;
            }
        }

        public string PharmacyAddress
        {
            get
            {
                //return the private data
                return mPharmacyAddress;
            }
            set
            {
                //set the value of the private data member 
                mPharmacyAddress = value;
            }
        }

        public string Valid(string PharmacyName, string PharmacyAddress)
        {
            //string variable to store the error message 
            string Error = "";
            //create a temporary variable to store data the pharmacist id 

            try
            {
                Int32 PharmacyIDTemp = Convert.ToInt32(PharmacyID);
                //if the PharmacyID is blank 
                if (PharmacyIDTemp == 0)
                {
                    ////record the error 
                    //Error = Error + "The PharmacyID shouldn't be blank!!!";
                }
                //if the PharmacyID is grater than 8 characters 
                if (PharmacyIDTemp > 10)
                {
                    Error = Error + "The PharmacyID should be less than 10 characters";
                }
            }
            catch
            {
                Error = Error + "The PharmacyID is not a number";
            }


            //if the Pharmacy Name is blank
            if (PharmacyName.Length == 0)
            {
                ////record the error
                //Error = "The Pharmacy Name shouldn't be blank!!!";
            }

            //if the Pharmacy Name is less than 15 characters
            else if (PharmacyName.Length < 15)
            {
                ////record the error 
                //Error = "The Pharmacy Name must be 15 chracters or more :)";
            }

            //if the Pharmacy Name is more than 15 characters long
            else if (PharmacyName.Length > 15)
            {
                ////return an error message 
                //Error = "Pharmacy name can't be more than 15 characters"; 
            }

            //if Pharmacy Address is more than 50 characters long
            if (PharmacyAddress.Length > 50)
            {
                //return an error message
                Error = "Pharmacy Address can't have more than 50 characters";
            }
            //if Pharmacy Address is more than 100 characters long
            else if (PharmacyAddress.Length > 100)
            {
                //return an error message
                Error = "Pharmacy Address can't have more than 100 characters";
            }
            //return any error messages 
            return Error;
        }
    }
}