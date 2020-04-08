using System;
using Class_Library;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsDrugCollection
    {
        //private data member for the Adding Method property
        private string mAddMethodOK;
        //private data member for the Updating Method property
        private string mUpdateMethodOK;
        //private data member for the Deleting Method property 
        private string mDeleteMethodOK; 
        //private data member for ThisDrug property
        private string mThisDrugOK;
        //private data member for the Drug List 
        private List<clsDrug> mDrugList = new List<clsDrug>();
        //private data member for ThisDrug
        clsDrug mThisDrug = new clsDrug();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member that stores the count of all records 
        private Int32 mRecordCount;

        //public constructor for the class
        public clsDrugCollection()
        {
            //new variable for the index 
            Int32 Index = 0;
            //new variable to store the record count 
            Int32 RecordCount = 0;
            //new instance of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDrug_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of clsDrug class
                clsDrug ADrug = new clsDrug();
                //read in the fields from the current record
                //ADrug.DrugID = Convert.ToInt32(DB.DataTable.Rows[Index]["DrugID"]);
                ADrug.DrugName = Convert.ToString(DB.DataTable.Rows[Index]["DrugName"]);
                ADrug.DrugType = Convert.ToString(DB.DataTable.Rows[Index]["DrugType"]);
                ADrug.DrugPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["DrugPrice"]);
                ADrug.IssuedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["IssuedDate"]);
                ADrug.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                ADrug.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member drug
                mDrugList.Add(ADrug);
                // Increment the index
                Index++;
            }
        }

        public void FilteredByDrugID(string DrugID)
        ///it accepts a single parameter drug id and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@DrugID", DrugID);
            //execute the stored procedure to delete the drug
            dBConnection.Execute("sproc_tblDrug_FilteredByDrugID");
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mDrugList.Count;
            }
            set
            {
                // later
            }
        }

        public clsDrug ThisDrug
        {
            get
            {
                //return the private data 
                return mThisDrug; 
            }
            set
            {
                //set the private data 
                mThisDrug = value;
            }
        }

        public List<clsDrug> DrugList
        {
            get
            {
                //return the private data
                return mDrugList;
            }
            set
            {
                //set the private data
                mDrugList = value;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of mDrug
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            // DB.AddParameter("@DrugID", mThisDrug.DrugID);
            DB.AddParameter("@DrugName", mThisDrug.DrugName);
            DB.AddParameter("@DrugType", mThisDrug.DrugType);
            DB.AddParameter("@DrugPrice", mThisDrug.DrugPrice);
            DB.AddParameter("@IssuedDate", mThisDrug.IssuedDate);
            DB.AddParameter("@ExpiryDate", mThisDrug.ExpiryDate);
            DB.AddParameter("@Quantity", mThisDrug.Quantity);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblDrug_Add");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisDrug
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DrugID", mThisDrug.DrugID);
            DB.AddParameter("@DrugName", mThisDrug.DrugName);
            DB.AddParameter("@DrugType", mThisDrug.DrugType);
            DB.AddParameter("@DrugPrice", mThisDrug.DrugPrice);
            DB.AddParameter("@IssuedDate", mThisDrug.IssuedDate);
            DB.AddParameter("@ExpiryDate", mThisDrug.ExpiryDate);
            DB.AddParameter("@Quantity", mThisDrug.Quantity);
            // execute the query returing the primary key value
            DB.Execute("sproc_tblDrug_Update");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisDrug
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@DrugID", mThisDrug.DrugID);
            //DB.AddParameter("@DrugName", mThisDrug.DrugName);
            //DB.AddParameter("@DrugType", mThisDrug.DrugType);
            //DB.AddParameter("@DrugPrice", mThisDrug.DrugPrice);
            //DB.AddParameter("@IssuedDate", mThisDrug.IssuedDate);
            //DB.AddParameter("@ExpiryDate", mThisDrug.ExpiryDate);
            //DB.AddParameter("@Quantity", mThisDrug.Quantity);
            //executre the stored procedure 
            DB.Execute("sproc_tblDrug_Delete");
        }
    }
}