namespace Class_Library
{
    public class clsPharmacyCollection
    {
        //private data member for ThisPharmacist
        clsPharmacy mThisPharmacy = new clsPharmacy();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        public clsPharmacy ThisPharmacy
        {
            get
            {
                //return the private data 
                return mThisPharmacy;

            }
            set
            {
                // set the private data
                mThisPharmacy = value;
            }
        }
    }
}