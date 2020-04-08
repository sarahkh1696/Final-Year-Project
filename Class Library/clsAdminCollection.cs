using System;
using System.Collections.Generic;

namespace Class_Library
{
    //this is a test class for AdminCollection
    public class clsAdminCollection
    {
        //private data member for ThisAdmin 
        clsAdmin mThisAdmin = new clsAdmin();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        //public constructor for the class 
        public clsAdminCollection()
        {

        }
        public clsAdmin ThisAdmin 
        {
          get
          {
                //return the private data 
                return mThisAdmin; 

          }
          set
          {
                // set the private data
                mThisAdmin = value;  
          }  
        }

        public int Add()
        {
            //add a new record to the database based on the values of mAdmin
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            DB.AddParameter("@AdminName", mThisAdmin.AdminName);
            // execute the query returing the primary key value
            return DB.Execute("sproc_tblAdmin_Add");
        }

        public void Delete()
        {
            //delete the record that is pointed by ThisAdmin 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            //executre the stored procedure 
            DB.Execute("sproc_tblAdmin_Delete");
           
        }

        public void Update()
        {
            //update an existing record based on the values of ThisAdmin
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            DB.AddParameter("@AdminName", mThisAdmin.AdminName);
            //execute the stored procedure 
            DB.Execute("sproc_tblAdmin_Update"); 
        }
    }
}