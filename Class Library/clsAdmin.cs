using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    //Admin class variable 
    public class clsAdmin
    {
        //private data member for the Admin ID property
        private int mAdminID;
        //private data member for the Admin Name property
        private string mAdminName;
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Deleting Method property
        private string mDeleteMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for ThisAdmin property
        private string mThisAdminOK;

        public int AdminID
        {
            get
            {
                //return the private data
                return mAdminID;
            }
            set
            {
                //set the value of the private data member 
                mAdminID = value;
            }
        }
        public string AdminName
        {
            get
            {
                //return the private data
                return mAdminName;
            }
            set
            {
                //set the value of the private data member 
                mAdminName = value;
            }
        }
        public string AddMethodOK
        {
            get
            {
                //return the private data 
                return mAddMethodOK;
            }
            set
            {
                //set the value of the private data memeber 
                mAddMethodOK = value;
            }
        }
        public string DeleteMethodOK
        {
            get
            {
                //return the private data 
                return mDeleteMethodOK;
            }
            set
            {
                //set the value of the private data memeber 
                mDeleteMethodOK = value;
            }
        }
        public string UpdateMethodOK
        {
            get
            {
                //return the private data 
                return mUpdateMethodOK;
            }
            set
            {
                //set the value of the private data memeber 
                mUpdateMethodOK = value;
            }
        }
        public string ThisAdminOK
        {
            get
            {
                // return the private data
                return mThisAdminOK;
            }
            set
            {
                // set the value of the private data member
                mThisAdminOK = value;
            }
        }
        public string Valid(string AdminName)
        {
            //if (AdminName == null)
            //{
            //    throw new ArgumentNullException(nameof(AdminName));
            //}
            //else if (AdminName >= 0)
            //{
            //    throw new ArgumentNullException("Don't leave admin name blank");
            //}

            //string variable to store the error message 
            string Error = "";
            //create a temporary variable to store data the admin id 

            try
            {
                Int32 AdminIDTemp = Convert.ToInt32(AdminID);
                //if the AdminID is blank 
                if (AdminIDTemp == 0)
                {
                    //record the error 
                    //Error = Error + "The AdminID shouldn't be blank!!!";
                }
                //if the AdminID is grater than 8 characters 
                if (AdminIDTemp > 10)
                {
                    Error = Error + "The AdminID should be less than 10 characters";
                }
            }
            catch
            {
                Error = Error + "The AdminID is not a number";
            }

            //if the Admin Name is blank 
            if (AdminName.Length == 0)
            {
                ////record the error
                //Error = Error + "The Admin Name shouldn't be blank!!!";
            }

            //if the Admin Name is greater than 15 character
            if (AdminName.Length > 15)
            {
                //record the error 
                Error = Error + "The Admin Name must be less than 15 chracter :)";
            }
            //return any error messages 
            return Error;
        }

        public bool Add(int AdminID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the appointment no to search for
            DB.AddParameter("@AdminID", AdminID);
            // execute the stored procedure
            DB.Execute("sproc_tblAdmin_Add");
            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // set the private data member for the AdminID property
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminName = Convert.ToString(DB.DataTable.Rows[0]["AdminName"]);

                //return if everything is working properly
                return true;
            }
            //if no record was found
            else
            {
                // return if there is any problem has indicated
                return false;
            }
        }

        public bool Find(int adminID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the AdminID to search for
            DB.AddParameter("@AdminID", AdminID);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_FilteredByAdminID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members 
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminName = Convert.ToString(DB.DataTable.Rows[0]["AdminName"]);
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