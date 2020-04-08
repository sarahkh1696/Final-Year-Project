using System;

namespace Class_Library
{
    public class clsPatient
    {
        //private data member for the patient id property
        private int mPatientID;
        //private data member for the first name property
        private string mFirstName;
        //private data member for the last name property
        private string mLastName;
        //private data member for the gender property
        private string mGender;
        //private data member for the age property
        private int mAge;
        //private data member for the addressline property
        private string mAddressLine; 
        //private data member for the date added property
        private DateTime mDateAdded;
        //private data member for the contact no property
        private string mContactNo;
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member 
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member 
                mLastName = value;
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

        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the value of the private data member 
                mGender = value;
            }
        }

        public int Age
        {
            get
            {
                //return the private data
                return mAge;
            }
            set
            {
                //set the value of the private data member 
                mAge = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member 
                mDateAdded = value;
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

        public string AddressLine
        {
            get
            {
                //return the private data
                return mAddressLine;
            }
            set
            {
                //set the value of the private data member 
                mAddressLine = value;
            }
        }

        public string Valid(string FirstName, string LastName, string Gender, string Age, string AddressLine, string DateAdded, string ContactNo, string PatientID)
        {
            //string variable to store the error message 
            string Error = "";

            //if FirstName is blank 
            if (FirstName.Length == 0)
            {
                //record an error message 
                //Error = "First Name can't be blank"; 
            }
            //if FirstName is more than 10 characters long
            if (FirstName.Length > 10)
            {
                //record the error
                // Error = "First Name can't be more than 10 characters";
            }
            //if FirstName is more than 20 characters long
            else if (FirstName.Length > 20)
            {
                //return an error message
                //Error = "First Name can't be more than 20 characters";
            }
            //if LastName is blank 
            if (LastName.Length == 0)
            {
                //record an error message 
                //Error = "Last Name can't be blank"; 
            }
            //if LastName is more than 15 characters long
            if (LastName.Length > 15)
            {
                //record the error
                // Error = "Last Name can't be more than 10 characters";
            }
            //if LastName is more than 20 characters long
            else if (LastName.Length > 20)
            {
                //return an error message
                //Error = "Last Name can't be more than 20 characters";
            }
            //if Gender is blank 
            if (Gender.Length == 0)
            {
                //record an error message 
                //Error = "Gender can't be blank"; 
            }
            //if Gender is more than 9 characters long
            if (Gender.Length > 9)
            {
                //record the error
                // Error = "Gender can't be more than 9 characters";
            }
            //if Age is blank 
            if (Age.Length == 0)
            {
                //record an error message 
                //Error = "Age can't be blank"; 
            }
            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {
                //copy the datePlaced value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date can't be in the past : ";
                }
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
            //if AddressLine is blank
            if (AddressLine.Length == 0)
            {
                //return an error message  
                //Error = "AddressLine cant be blank";
            }
            //if AddressLine is more than 100 characters long 
            else if (AddressLine.Length > 100)
            {
                //return an error message  
                //Error = "AddressLine can't be more than 100 characters long";
            }

            //return the result
            return Error;
        }

        public bool Find(int primaryKey)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PatientID to search for
            DB.AddParameter("@PatientID", PatientID);
            //execute the stored procedure
            DB.Execute("sproc_tblPatient_FilteredByPatientID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members 
                mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mAge = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);
                mAddressLine = Convert.ToString(DB.DataTable.Rows[0]["AddressLine"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mContactNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);
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