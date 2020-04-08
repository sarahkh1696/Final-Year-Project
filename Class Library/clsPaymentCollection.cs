using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsPaymentCollection
    {
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for the Deleting Method property 
        private string mDeleteMethodOK;
        //private data member for ThisPayment property
        private string mThisPaymentOK;
        //private data member for the Payment List 
        private List<clsPayment> mPaymentList = new List<clsPayment>();
        //private data member for ThisPayment
        clsPayment mThisPayment = new clsPayment();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of all records 
        private Int32 mRecordCount;

        //public constructor for the class
        public clsPaymentCollection()
        {
            //new variable for the index 
            Int32 Index = 0;
            //new variable to store the record count 
            Int32 RecordCount = 0;
            //new instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of clsPayment class
                clsPayment APayment = new clsPayment();
                //read in the fields from the current record
                APayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                APayment.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                APayment.PaymentType = Convert.ToString(DB.DataTable.Rows[Index]["PaymentType"]);
                APayment.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                APayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                //add the record to the private data member payment
                mPaymentList.Add(APayment);
                // Increment the index
                Index++;
            }
        }
        public void FilteredByPaymentID(string PaymentID)
        ///it accepts a single parameter payment id and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@PaymentID", PaymentID);
            //execute the stored procedure to delete the patient
            dBConnection.Execute("sproc_tblPayment_FilterByPaymentID");
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                // later
            }
        }
        public clsPayment ThisPayment
        {
            get
            {
                //return the private data 
                return mThisPayment;
            }
            set
            {
                //set the private data 
                mThisPayment = value;
            }
        }
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data
                return mPaymentList;
            }
            set
            {
                //set the private data
                mPaymentList = value;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of mPayment
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@PatientID", mThisPayment.PatientID);
            DB.AddParameter("@PaymentType", mThisPayment.PaymentType);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@Price", mThisPayment.Price);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblPayment_Add");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@PatientID", mThisPayment.PatientID);
            DB.AddParameter("@PaymentType", mThisPayment.PaymentType);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@Price", mThisPayment.Price);
            // execute the query returing the primary key value
            DB.Execute("sproc_tblPayment_Update");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisPayment
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            //DB.AddParameter("@PatientID", mThisPayment.PatientID);
            //DB.AddParameter("@PaymentType", mThisPayment.PaymentType);
            //DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            //DB.AddParameter("@Price", mThisPayment.Price);
            //executre the stored procedure 
            DB.Execute("sproc_tblPayment_Delete");
        }
    }
}