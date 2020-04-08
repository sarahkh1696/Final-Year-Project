using System;
using Class_Library;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsConsultantCollection
    {
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for ThisConsultant property
        private string mThisConsultantOK;
        //private data member for the Consultant List 
        private List<clsConsultant> mConsultantList = new List<clsConsultant>();
        //private data member for ThisConsultant
        clsConsultant mThisConsultant = new clsConsultant();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of all records 
        private Int32 mRecordCount;

        //public constructor for the class
        public clsConsultantCollection()
        {
            //new variable for the index 
            Int32 Index = 0;
            //new variable to store the record count 
            Int32 RecordCount = 0;
            //new instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblConsultant_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                //new instance of consultant class
                clsConsultant AConsultant = new clsConsultant();
                //read in the fields from the current record
                //AConsultant.ConsultantID = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsultantID"]);
                AConsultant.ConsultantName = Convert.ToString(DB.DataTable.Rows[Index]["ConsultantName"]);
                AConsultant.ConsultantSpecialist = Convert.ToString(DB.DataTable.Rows[Index]["ConsultantSpecialist"]);
                AConsultant.ConsultantComment = Convert.ToString(DB.DataTable.Rows[Index]["ConsultantComment"]);
                AConsultant.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //AConsultant.DrugType = Convert.ToString(DB.DataTable.Rows[Index]["DurgType"]);
                //add the record to the private data member consultant
                mConsultantList.Add(AConsultant);
                // Increment the index
                Index++;
            }
        }
        public clsConsultant ThisConsultant
        {
            get
            {
                //return the private data 
                return mThisConsultant;

            }
            set
            {
                //set the private data
                mThisConsultant = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mConsultantList.Count;
            }
            set
            {
                // later
            }
        }

        public List<clsConsultant> ConsultantList
        {
            get
            {
                //return the private data
                return mConsultantList;
            }
            set
            {
                //set the private data
                mConsultantList = value;
            }
        }

        public void FilteredByConsultantID(string ConsultantID)
        ///it accepts a single parameter consultant id and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@ConsultantID", ConsultantID);
            //execute the stored procedure to delete the consultant
            dBConnection.Execute("sproc_tblConsultant_FilteredByConsultantID");
        }
        public int Add()
        {
            //add a new record to the database based on the values of mConsultant
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            //DB.AddParameter("@ConsultantID", mThisConsultant.ConsultantID);
            DB.AddParameter("@ConsultantName", mThisConsultant.ConsultantName);
            DB.AddParameter("@ConsultantSpecialist", mThisConsultant.ConsultantSpecialist);
            DB.AddParameter("@ConsultantComment", mThisConsultant.ConsultantComment);
            DB.AddParameter("@DateAdded", mThisConsultant.DateAdded);
            DB.AddParameter("@DrugType", mThisConsultant.DrugType);
            // execute the query returing the primary key value
            return DB.Execute("sproc_tblConsultant_Add");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisConsultant
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ConsultantID", mThisConsultant.ConsultantID);
            DB.AddParameter("@ConsultantName", mThisConsultant.ConsultantName);
            DB.AddParameter("@ConsultantSpecialist", mThisConsultant.ConsultantSpecialist);
            DB.AddParameter("@ConsultantComment", mThisConsultant.ConsultantComment);
            DB.AddParameter("@DateAdded", mThisConsultant.DateAdded);
            DB.AddParameter("@DrugType", mThisConsultant.DrugType);
            // execute the query returing the primary key value
            DB.Execute("sproc_tblConsultant_Update");
        }

        public void FindAllConsultants()
        {
            //reset the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user no of the current record
            Int32 ConsultantID;
            //var to flag that user was found
            Boolean ConsultantFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblConsultant_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsConsultant NewConsultant = new clsConsultant();
                //get the user number from the database
                ConsultantID = Convert.ToInt32(myDB.DataTable.Rows[Index]["ConsultantID"]);
                //invokes find method
                ConsultantFound = NewConsultant.Find(ConsultantID);
                if (ConsultantFound == true)
                {
                    //add the user to the list
                    mConsultantList.Add(NewConsultant);
                }
                //increment the index
                Index++;
            }
        }
    }
}