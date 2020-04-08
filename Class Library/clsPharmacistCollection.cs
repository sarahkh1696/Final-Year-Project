using System;

namespace Class_Library
{
    public class clsPharmacistCollection
    {
        //private data member for ThisPharmacist
        clsPharmacist mThisPharmacist = new clsPharmacist();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        public clsPharmacist ThisPharmacist
        {
            get
            {
                //return the private data 
                return mThisPharmacist;

            }
            set
            {
                // set the private data
                mThisPharmacist = value;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of mPharmacist
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            //DB.AddParameter("@PharmacistID", mThisPharmacist.PharmacistID);
            DB.AddParameter("@PharmacistName", mThisPharmacist.PharmacistName);
            DB.AddParameter("@ContactNo", mThisPharmacist.ContactNo);
            // execute the query returing the primary key value
            return DB.Execute("sproc_tblPharmacist_Add");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisPharmacist
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PharmacistID", mThisPharmacist.PharmacistID);
            //executre the stored procedure 
            DB.Execute("sproc_tblPharmacist_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisPharmacist
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PharmacistID", mThisPharmacist.PharmacistID);
            DB.AddParameter("@PharmacistName", mThisPharmacist.PharmacistName);
            DB.AddParameter("@ContactNo", mThisPharmacist.ContactNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblPharmacist_Update");
        }
    }
}