using System;

namespace Class_Library
{
    public class clsConsultant
    {
        //private data member for the Consultant ID property
        private int mConsultantID;
        //private data member for the Consultant Name property
        private string mConsultantName;
        //private data member for the Consultant Specialist property
        private string mConsultantSpecialist;
        //private data member for the Consultant Comment property
        private string mConsultantComment;
        //private data member for the Date Added property
        private DateTime mDateAdded;
        //private data member for the Drug Type property
        private string mDrugType;

        public string ConsultantName
        {
            get
            {
                //return the private data
                return mConsultantName;
            }
            set
            {
                //set the value of the private data member 
                mConsultantName = value;
            }
        }

        public int ConsultantID
        {
            get
            {
                //return the private data
                return mConsultantID;
            }
            set
            {
                //set the value of the private data member 
                mConsultantID = value;
            }
        }

        public string ConsultantSpecialist
        {
            get
            {
                //return the private data
                return mConsultantSpecialist;
            }
            set
            {
                //set the value of the private data member 
                mConsultantSpecialist = value;
            }
        }

        public string ConsultantComment
        {
            get
            {
                //return the private data
                return mConsultantComment;
            }
            set
            {
                //set the value of the private data member 
                mConsultantComment = value;
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

        public string Valid(string ConsultantName, string ConsultantComment, string ConsultantSpecialist, string PatientID, string DrugType, string DateAdded, string ConsultantID)
        {
            //string variable to store the error message 
            string Error = "";
            //create a temporary variable to store data the Consultant id 

            try
            {
                Int32 ConsultantIDTemp = Convert.ToInt32(ConsultantID);
                //if the PharmacistID is blank 
                if (ConsultantIDTemp == 0)
                {
                    //record the error 
                    Error = Error + "The ConsultantID shouldn't be blank!!!";
                }
                //if the ConsultantID is grater than 8 characters 
                if (ConsultantIDTemp > 10)
                {
                    //Error = Error + "The ConsultantID should be less than 10 characters";
                }
            }
            catch
            {
                //Error = Error + "The ConsultantID is not a number";
            }


            //if the Consultant Name is blank
            if (ConsultantName.Length == 0)
            {
                //record the error
                // Error = "The Consultant Name shouldn't be blank!!!";
            }

            //if the Consultant Name is less than 3 characters
            else if (ConsultantName.Length < 15)
            {
                //record the error 
                // Error = "The Consultant Name must be more than 3 characters :)";
            }

            //if the Consultant Name is more than 30 characters long
            else if (ConsultantName.Length > 15)
            {
                //return an error message 
                //  Error = "Consultant name can't be more than 30 characters"; 
            }

            //if Consultant Specialist is blank
            if (ConsultantSpecialist.Length == 0)
            {
                //return an error message  
                // Error = "Consultant Specialist cant be blank";
            }
            //if Consultant Specialist is less than 14 characters long 
            else if (ConsultantSpecialist.Length < 15)
            {
                //return an error message  
                //Error = "Consultant Specialist must be at least 15 characters long";
            }
            //if Consultant Specialist is more than 25 characters long 
            else if (ConsultantSpecialist.Length > 25)
            {
                //return an error message 
                // Error = "Consultant Specialist can't be 25 characters long";
            }

            //if Consultant Comment is blank
            if (ConsultantComment.Length == 0)
            {
                //return an error message  
                // Error = "Consultant Comment cant be blank";
            }
            //if Consultant Comment is less than 40 characters long 
            else if (ConsultantComment.Length < 40)
            {
                //return an error message  
                //Error = "Consultant Comment must be at least 40 characters long";
            }
            //if Consultant Comment is more than 25 characters long 
            else if (ConsultantComment.Length > 80)
            {
                //return an error message 
                // Error = "Consultant Comment can't be 80 characters long";
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
               // Error = Error + "The date wasn't a valid date : ";
            }

            //return any error messages 
            return Error;
        }
    
        public bool Find(int ConsultantID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the ConsultantID to search for
            DB.AddParameter("@ConsultantID", ConsultantID);
            //execute the stored procedure
            DB.Execute("sproc_tblConsultant_FilteredByConsultantID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members 
                mConsultantID = Convert.ToInt32(DB.DataTable.Rows[0]["ConsultantID"]);
                mConsultantName = Convert.ToString(DB.DataTable.Rows[0]["ConsultantName"]);
                mConsultantSpecialist = Convert.ToString(DB.DataTable.Rows[0]["ConsultantSpecialist"]);
                mConsultantComment = Convert.ToString(DB.DataTable.Rows[0]["ConsultantComment"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDrugType = Convert.ToString(DB.DataTable.Rows[0]["DrugType"]);

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


