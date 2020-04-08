using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsPatientCollection
    {
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for the Deleting Method property 
        private string mDeleteMethodOK;
        //private data member for ThisPatient property
        private string mThisPatientOK;
        //private data member for the Patient List 
        private List<clsPatient> mPatientList = new List<clsPatient>();
        //private data member for ThisPatient
        clsPatient mThisPatient = new clsPatient();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of all records 
        private Int32 mRecordCount;

        //public constructor for the class
        public clsPatientCollection()
        {
            //new variable for the index 
            Int32 Index = 0;
            //new variable to store the record count 
            Int32 RecordCount = 0;
            //new instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPatient_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of clsPatient class
                clsPatient APatient = new clsPatient();
                //read in the fields from the current record
                APatient.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                APatient.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                APatient.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                APatient.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                APatient.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                APatient.AddressLine = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine"]);
                APatient.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                APatient.ContactNo = Convert.ToString(DB.DataTable.Rows[Index]["ContactNo"]);
                //add the record to the private data member patient
                mPatientList.Add(APatient);
                // Increment the index
                Index++;
            }
        }

        public void FilteredByPatientID(string PatientID)
        ///it accepts a single parameter patient id and returns no value
        {
            //initialise the DBConnection
           clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@PatientID", PatientID);
            //execute the stored procedure to delete the patient
            dBConnection.Execute("sproc_tblPatient_FilteredByPatientID");
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mPatientList.Count;
            }
            set
            {
                // later
            }
        }
        public clsPatient ThisPatient
        {
            get
            {
                //return the private data 
                return mThisPatient;
            }
            set
            {
                //set the private data 
                mThisPatient = value;
            }
        }
        public List<clsPatient> PatientList
        {
            get
            {
                //return the private data
                return mPatientList;
            }
            set
            {
                //set the private data
                mPatientList = value;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of mPatient
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            //DB.AddParameter("@PatientID", mThisPatient.PatientID);
            DB.AddParameter("@FirstName", mThisPatient.FirstName);
            DB.AddParameter("@LastName", mThisPatient.LastName);
            DB.AddParameter("@Gender", mThisPatient.Gender);
            DB.AddParameter("@Age", mThisPatient.Age);
            DB.AddParameter("@AddressLine", mThisPatient.AddressLine);
            DB.AddParameter("@DateAdded", mThisPatient.DateAdded);
            DB.AddParameter("@ContactNo", mThisPatient.ContactNo);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblPatient_Add");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisPatient
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PatientID", mThisPatient.PatientID);
            DB.AddParameter("@FirstName", mThisPatient.FirstName);
            DB.AddParameter("@LastName", mThisPatient.LastName);
            DB.AddParameter("@Gender", mThisPatient.Gender);
            DB.AddParameter("@Age", mThisPatient.Age);
            DB.AddParameter("@AddressLine", mThisPatient.AddressLine);
            DB.AddParameter("@DateAdded", mThisPatient.DateAdded);
            DB.AddParameter("@ContactNo", mThisPatient.ContactNo);
            // execute the query returing the primary key value
            DB.Execute("sproc_tblPatient_Update");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisPatient
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PatientID", mThisPatient.PatientID);
            //DB.AddParameter("@FirstName", mThisPatient.FirstName);
            //DB.AddParameter("@LastName", mThisPatient.LastName);
            //DB.AddParameter("@Gender", mThisPatient.Gender);
            //DB.AddParameter("@Age", mThisPatient.Age);
            //DB.AddParameter("@AddressLine", mThisPatient.AddressLine);
            //DB.AddParameter("@DateAdded", mThisPatient.DateAdded);
            //DB.AddParameter("@ContactNo", mThisPatient.ContactNo);
            //executre the stored procedure 
            DB.Execute("sproc_tblPatient_Delete");
        }
    }
}