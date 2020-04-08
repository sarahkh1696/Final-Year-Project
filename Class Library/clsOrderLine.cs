using System;

namespace Class_Library
{
    public class clsOrderLine
    {
        //private data member for the Order ID property
        private Int32 mOrderID;
        //private data member for the OrderLine ID property
        private Int32 mOrderLineID;
        //private data member for the Drug ID property
        private Int32 mDrugID;

        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member 
                mOrderID = value;
            }
        }

        public int OrderLineID
        {
            get
            {
                //return the private data
                return mOrderLineID;
            }
            set
            {
                //set the value of the private data member 
                mOrderLineID = value;
            }
        }

        public int DrugID { get; set; }

        public string Valid(object OrderLineID, string OrderID, object DrugID)
        {
            throw new NotImplementedException();
        }
    }
}