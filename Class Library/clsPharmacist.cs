using System;

namespace Class_Library
{
    public class clsPharmacist
    {
        //private data member for the Pharmacist ID property
        private int    mPharmacistID;
        //private data member for the Pharmacist Name property
        private string mPharmacistName;
        //private data member for the Pharmacist Contact No property
        private string mContactNo;
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Deleting Method property
        private string mDeleteMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for ThisPharmacist property
        private string mThisPharmacistOK;
       
        public string PharmacistName
        {
            get
            {
                //return the private data
                return mPharmacistName;
            }
            set
            {
                //set the value of the private data member 
                mPharmacistName = value;
            }
        } 
        public int PharmacistID
        {
            get
            {
                //return the private data
                return mPharmacistID;
            }
            set
            {
                //set the value of the private data member 
                mPharmacistID = value;
            }
        }

        public string ContactNo
        {
            get
            {
                //return the private data
                return mContactNo;
            }
            set
            {
                //set the value of the private data member 
                mContactNo = value;
            }

        }

        public string Valid(string PharmacistName, string ContactNo, string PharmacistID)
        {
            //string variable to store the error message 
            string Error = "";
            //create a temporary variable to store data the pharmacist id 

            try
            {
                Int32 PharmacistIDTemp = Convert.ToInt32(PharmacistID);
                //if the PharmacistID is blank 
                if (PharmacistIDTemp == 0)
                {
                    //record the error 
                   // Error = Error + "The PharmacistID shouldn't be blank!!!";
                }
                //if the PharmacistID is grater than 8 characters 
                if (PharmacistIDTemp > 10)
                {
                    //Error = Error + "The PharmacistID should be less than 10 characters";
                }
            }
            catch
            {
                //Error = Error + "The PharmacistID is not a number";
            }


            //if the Pharmacist Name is blank
            if (PharmacistName.Length == 0)
            {
                ////record the error
                //Error = "The Pharmacist Name shouldn't be blank!!!";
            }

            //if the Pharmacist Name is less than 15 characters
            else if (PharmacistName.Length < 15)
           {
                ////record the error 
                //Error = "The Pharmacist Name must be 15 chracters or more :)";
           }

            //if the Pharmacist Name is more than 15 characters long
            else if (PharmacistName.Length > 15)
            {
                ////return an error message 
                //Error = "Pharmacist name can't be more than 15 characters"; 
            }

            //if Contact No is blank
            if (ContactNo.Length == 0)
            {
                //return an error message  
                //Error = "Contact Number cant be blank";
            }
            //if Contact number is less than 11 characters long 
            else if (ContactNo.Length < 11)
            {
                //return an error message  
                //Error = "Contact number must be at least 11 characters long";
            }
            //if contact number is more than 25 characters long 
            else if (ContactNo.Length > 25)
            {
                //return an error message 
                //Error = "Contact number can't be 25 characters long";
            }
                //return any error messages 
                return Error;
        }

        public bool Find(int PharmacistID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the AdminID to search for
            DB.AddParameter("@PharmacistID", PharmacistID);
            //execute the stored procedure
            
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members 
                mPharmacistID = Convert.ToInt32(DB.DataTable.Rows[0]["PharmacistID"]);
                mPharmacistName = Convert.ToString(DB.DataTable.Rows[0]["PharmacistName"]);
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
